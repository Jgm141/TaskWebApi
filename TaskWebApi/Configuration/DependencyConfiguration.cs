using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;
using TaskWebApi.DTO;
using TaskWebApi.Repository;
using TaskWebApi.Service;
using TaskWebApi.Service.Interfaces.Repository;
using TaskWebApi.Service.Interfaces.Services;

namespace TaskWebApi.Configuration;

public static class DependencyConfiguration
{
    public static void ConfigureDependency(this WebApplicationBuilder builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<ICityService, CityService>();
        builder.Services.AddScoped<IPersonService, PersonService>();
        builder.Services.AddScoped<IPhoneNumberService, PhoneNumberService>();
        builder.Services.AddScoped<IRelativePersonService,  RelativePersonService>();
        builder.Services.AddDbContext<TaskWebApiDbContext>(options => options.UseSqlServer(connectionString));
    }
}
