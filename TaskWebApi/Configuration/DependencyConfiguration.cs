using Microsoft.EntityFrameworkCore;
using TaskWebApi.DTO;
using TaskWebApi.Repository;
using TaskWebApi.Service;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Configuration;

public static class DependencyConfiguration
{
    public static void ConfigureDependency(this WebApplicationBuilder builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddDbContext<TaskWebApiDbContext>(options => options.UseSqlServer(connectionString));
    }
}
