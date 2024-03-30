using Microsoft.EntityFrameworkCore;
using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.configure;


namespace TaskWebApi.Repository.database.Configuration;

public class PhoneNumberConfiguration : IEntityConfiguration
{
    public bool Configure()
    {
        ModelBuilder modelBuilder = new();

        modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.Number)
            .HasColumnType("nvarchar(25)")
            .IsRequired();

        modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.PhoneNumberType)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        modelBuilder.Entity<PhoneNumber>()
            .HasOne(a => a.Person)
            .WithMany(a => a.PhoneNumber)
            .IsRequired();

        return true;
    }
}
