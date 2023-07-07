using Application.Services;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Mapping;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IDepartmentAndEmployeeRepository, DepartmentAndEmployeeRepository>();
        builder.Services.AddScoped<DepartmentAndEmployeeService>();

        builder.Services.AddControllers();
        IConfiguration config = GetConfig();
        string connectionString = config.GetConnectionString("DepartmentAndEmployee");
        builder.Services.AddDbContext<AppDBContext>(options => options.UseNpgsql(connectionString,
            x => x.MigrationsAssembly("Infrastructure")));

        builder.Services.AddAutoMapper(typeof(MappingProfile));

        var app = builder.Build();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseRouting();

        app.Run();
    }

    private static IConfiguration GetConfig()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        return builder.Build();
    }
}