using Microsoft.EntityFrameworkCore;
using TaskWebApi.Service.Interfaces.configure;
using TaskWebApi.DTO;

namespace TaskWebApi.Repository.database.Configuration;

public class CityConfiguration : IEntityConfiguration
{
    public bool Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>()
            .Property(a => a.Name)
            .HasColumnType("nvarchar(20)")
            .IsRequired();

        modelBuilder.Entity<City>()
            .HasIndex(a => a.Name)
            .IsUnique(true);

        modelBuilder.Entity<City>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        modelBuilder.Entity<City>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        modelBuilder.Entity<City>().
            HasMany(p => p.Person)
            .WithOne(p => p.City)
            .IsRequired();

        return true;
    }
}
