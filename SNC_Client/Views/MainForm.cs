
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using SNC_Client.Views.Modals;

namespace SNC_Client.Views;

public partial class MainForm : MaterialForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly EmployeeServiceRef.EmployeeServiceClient _employeeService;
    public MainForm(IServiceProvider serviceProvider, MaterialSkinManager materialSkinManager, EmployeeServiceRef.EmployeeServiceClient employeeService)
    {
        _serviceProvider = serviceProvider;
        _materialSkinManager = materialSkinManager;
        _employeeService = employeeService;
        InitializeComponent();

        _materialSkinManager.AddFormToManage(this);

        BuildDataGridViewHeader();
    }

    #region datagrid
    public virtual Guid GetSelectedRowID()
    {
        if (dataGridView.Rows.Count == 0)
        {
            throw new Exception("List is empty");
        }

        var firstSelectedRow = dataGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

        if (firstSelectedRow?.Cells["ID"]?.Value is null)
        {
            throw new Exception("Not found selected item");
        }

        return new Guid(firstSelectedRow.Cells["ID"].Value.ToString());
    }
    private void BuildDataGridViewHeader()
    {
        dataGridView.ColumnCount = 7;
        dataGridView.ColumnHeadersVisible = true;

        dataGridView.Columns[0].Name = "ID";
        dataGridView.Columns[0].Visible = false;

        dataGridView.Columns[1].Name = "FullName";
        dataGridView.Columns[2].Name = "DRFO";
        dataGridView.Columns[3].Name = "PhoneNumber";
        dataGridView.Columns[4].Name = "Email";
        dataGridView.Columns[5].Name = "CreateDate";
        dataGridView.Columns[6].Name = "UpdateDate";
    }
    #endregion

    private async Task UpdateDataGridView()
    {
        dataGridView.Rows.Clear();
        var employess = (await _employeeService.GetEmpoyesAsync()).Data;
        foreach (var employee in employess)
        {
            dataGridView.Rows.Add(new string[]
            {
                employee.ID.ToString(),
                $"{employee.FirstName} {employee.LastName} {employee.Patronymic}",
                employee.DRFO.ToString(),
                employee.PhoneNumber,
                employee.Email,
                employee.CreateDate.ToString(),
                employee.UpdateDate.ToString()
            });
        }
    }

    private async void materialButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            EmployeeActionForm employeeActionForm = _serviceProvider.GetRequiredService<EmployeeActionForm>();
            employeeActionForm.ConfigureAddMode();
            DialogResult dialogResult = this.OpenDialogWithShadow(employeeActionForm);
            if (dialogResult == DialogResult.OK)
            {
                await UpdateDataGridView();
                new MaterialSnackBar($"Employee is added.", 1000).Show(this);
            }
        }
        catch (Exception error)
        {
            new MaterialSnackBar(error.Message, 1000).Show(this);
        }
    }

    private async void materialButtonEdit_Click(object sender, EventArgs e)
    {
        try
        {
            EmployeeActionForm employeeActionForm = _serviceProvider.GetRequiredService<EmployeeActionForm>();
            await employeeActionForm.ConfigureEditeMode(GetSelectedRowID());
            DialogResult dialogResult = this.OpenDialogWithShadow(employeeActionForm);
            if (dialogResult == DialogResult.OK)
            {
                await UpdateDataGridView();
                new MaterialSnackBar($"Employee is updated.", 1000).Show(this);
            }
        }
        catch (Exception error)
        {
            new MaterialSnackBar(error.Message, 1000).Show(this);
        }
    }

    private async void materialButtonDelete_Click(object sender, EventArgs e)
    {
        string resultMessage;
        try
        {
            DialogResult resultToDelete = new MaterialDialog(this, "Delete item", "Are you sure you want to delete the item?", "Delete", true, "Cancel").ShowDialog(this);
            if (resultToDelete == DialogResult.Cancel)
            {
                return;
            }

            await _employeeService.DeleteEmpoyeeAsync(GetSelectedRowID());

            resultMessage = "Employee is deleted.";
            await UpdateDataGridView();
        }
        catch (Exception ex)
        {
            resultMessage = ex.Message;
        }
        new MaterialSnackBar(resultMessage, 1000).Show(this);
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        await UpdateDataGridView();
    }
}
