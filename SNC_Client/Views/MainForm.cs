
using MaterialSkin;
using MaterialSkin.Controls;

namespace SNC_Client.Views;

public partial class MainForm : MaterialForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly MaterialSkinManager _materialSkinManager;
    public MainForm(IServiceProvider serviceProvider, MaterialSkinManager materialSkinManager)
    {
        _serviceProvider = serviceProvider;
        _materialSkinManager = materialSkinManager;
        InitializeComponent();
    }
}
