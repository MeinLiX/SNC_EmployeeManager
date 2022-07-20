using MaterialSkin;
using MaterialSkin.Controls;

namespace SNC_Client.Views.Modals;

public partial class EmployeeActionForm : MaterialForm
{
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly EmployeeServiceRef.EmployeeServiceClient _employeeService;

    private EmployeeServiceRef.EmployeeModel? _employeeModel;

    public EmployeeActionForm(MaterialSkinManager materialSkinManager, EmployeeServiceRef.EmployeeServiceClient employeeService)
    {
        _materialSkinManager = materialSkinManager;
        _employeeService = employeeService;
        InitializeComponent();

        _materialSkinManager.AddFormToManage(this);
    }

    // TODO: need optimize => transfer this method in employee service and use ef request;
    private async Task<EmployeeServiceRef.EmployeeModel?> GetEmployee(Guid ID)
    {
        return (await _employeeService.GetEmpoyesAsync()).Data.FirstOrDefault(emp => emp.ID == ID);
    }

    public void ParseModelToFields()
    {
        materialTextBox2FirstName.Text = _employeeModel.FirstName;
        materialTextBox2LastName.Text = _employeeModel.LastName;
        materialTextBox2Patronymic.Text = _employeeModel.Patronymic;
        materialTextBox2DRFO.Text = _employeeModel.DRFO.ToString();
        materialMaskedTextBoxPhoneNumber.Text = _employeeModel.PhoneNumber;
        materialTextBox2Email.Text = _employeeModel.Email;
        dateTimePickerCreated.Value = _employeeModel.CreateDate;
        dateTimePickerLastUpdate.Value = _employeeModel.UpdateDate;
    }

    public async Task ConfigureEditeMode(Guid ID)
    {
        _employeeModel = await GetEmployee(ID) ?? throw new Exception("Not found employee for editing");

        materialButtonAction.Text = "Update";

        ParseModelToFields();
    }

    public void ConfigureAddMode()
    {
        materialButtonAction.Text = "Add";
    }


    private async void materialButtonAction_Click(object sender, EventArgs e)
    {
        try
        {
            if (_employeeModel is not null)
            {
                _employeeModel.FirstName = materialTextBox2FirstName.Text;
                _employeeModel.LastName = materialTextBox2LastName.Text;
                _employeeModel.Patronymic = materialTextBox2Patronymic.Text;
                _employeeModel.DRFO = int.Parse(materialTextBox2DRFO.Text);
                _employeeModel.PhoneNumber = materialMaskedTextBoxPhoneNumber.Text;
                _employeeModel.Email = materialTextBox2Email.Text;
                _employeeModel.UpdateDate = DateTime.Now;
            }
            await (_employeeModel switch
            {
                null => _employeeService.AddEmpoyeeAsync(new EmployeeServiceRef.EmployeeModel()
                {
                    ID = Guid.NewGuid(),
                    FirstName = materialTextBox2FirstName.Text,
                    LastName = materialTextBox2LastName.Text,
                    Patronymic = materialTextBox2Patronymic.Text,
                    DRFO = int.Parse(materialTextBox2DRFO.Text),
                    PhoneNumber = materialMaskedTextBoxPhoneNumber.Text,
                    Email = materialTextBox2Email.Text,
                    CreateDate = dateTimePickerCreated.Value,
                    UpdateDate = dateTimePickerLastUpdate.Value,
                }),
                _ => _employeeService.UpdateEmpoyeeAsync(_employeeModel)
            });
        }
        catch (Exception error)
        {
            new MaterialSnackBar(error.Message, 1000).Show(this);
            return;
        }

        this.DialogResult = DialogResult.OK;
        BeforeExit();
        this.Close();
    }

    private void materialButtonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        BeforeExit();
        this.Close();
    }

    public void BeforeExit()
    {
        materialTextBox2FirstName.Clear();
        materialTextBox2LastName.Clear();
        materialTextBox2Patronymic.Clear();
        materialTextBox2Email.Clear();
        materialMaskedTextBoxPhoneNumber.Clear();
        materialTextBox2DRFO.Clear();
        dateTimePickerCreated.Value = DateTime.Now;
        dateTimePickerLastUpdate.Value = DateTime.Now;
    }

    private void materialTextBox2DRFO_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}
