using Microsoft.EntityFrameworkCore;
using TaskWebApi.Service.Interfaces.configure;
using TaskWebApi.DTO;

namespace TaskWebApi.Repository.database.Configuration;

public class PersonConfiguration : IEntityConfiguration
{
    public bool Configure(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Person>()
            .Property(a => a.FirstName)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.LastName)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.Address)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.Gender)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.PersonalNumber)
            .HasColumnType("nvarchar(11)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.Birthday)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        modelBuilder.Entity<Person>()
            .Property(a => a.picture)
            .HasColumnType("nvarchar(115)")
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        modelBuilder.Entity<Person>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        modelBuilder.Entity<Person>()
            .HasOne(a => a.City)
            .WithMany(a => a.Person)
            .IsRequired();

        modelBuilder.Entity<Person>()
            .HasMany(a => a.PhoneNumber)
            .WithOne(a => a.Person)
            .IsRequired();

        modelBuilder.Entity<Person>()
            .HasMany(a => a.Persons)
            .WithOne(a => a.Person)
            .IsRequired(false);

        modelBuilder.Entity<Person>()
            .HasMany(a => a.Relatives)
            .WithOne(a => a.RelativeTo)
            .IsRequired(false);

        return true;
    }
}
