using MaterialSkin;
using MaterialSkin.Controls;

namespace SNC_Client.Views.Modals;

public partial class EmployeeActionForm : MaterialForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly MaterialSkinManager _materialSkinManager;
    public EmployeeActionForm(IServiceProvider serviceProvider, MaterialSkinManager materialSkinManager)
    {
        _serviceProvider = serviceProvider;
        _materialSkinManager = materialSkinManager;
        InitializeComponent();
    }
}
