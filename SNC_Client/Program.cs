using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using SNC_Client.Views;
using SNC_Client.Views.Modals;

namespace SNC_Client;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static async Task Main()
    {
        ApplicationConfiguration.Initialize();

        using ServiceProvider serviceProvider = ConfigureServices(new ServiceCollection());

        ConfigureMaterialSkin(serviceProvider.GetRequiredService<MaterialSkinManager>());


        Application.Run(serviceProvider.GetRequiredService<MainForm>());
    }

    private static ServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddSingleton(x => MaterialSkinManager.Instance)
                .AddSingleton<MainForm>()
                .AddSingleton<EmployeeActionForm>()
                .AddSingleton<EmployeeServiceRef.EmployeeServiceClient> ();
        //TODO ADD DB SERVICE;


        return services.BuildServiceProvider();
    }

    private static void ConfigureMaterialSkin(MaterialSkinManager materialSkinManager)
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey400, Primary.BlueGrey600, Primary.BlueGrey200, Accent.LightBlue200, TextShade.WHITE);
    }
}