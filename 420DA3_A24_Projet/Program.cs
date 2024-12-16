
using _420DA3_A24_Projet.Business.Services.Implementations;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
using _420DA3_A24_Projet.Presentation.Views.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace _420DA3_A24_Projet;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        IServiceCollection services = ConfigureServices();
        using (ServiceProvider serviceProvider = services.BuildServiceProvider()) {
            MenuForm mainForm = serviceProvider.GetRequiredService<MenuForm>();
            Application.Run(mainForm);
        }
    }
    private static IServiceCollection ConfigureServices() {

        IServiceCollection service = new ServiceCollection();
        _ = service.AddDbContext<AppDbContexte>();

        _ = service.AddScoped<UserDao, UserDao>();
        _ = service.AddScoped<RoleDao, RoleDao>();
        _ = service.AddScoped<WarehouseDao, WarehouseDao>();


        _ = service.AddScoped<UserService, UserService>();
        _ = service.AddScoped<RoleService, RoleService>();
        _ = service.AddScoped<WarehouseService, WarehouseService>();

        _ = service.AddScoped<MenuForm>();

        return service;
    }
}