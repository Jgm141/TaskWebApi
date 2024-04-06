using Microsoft.EntityFrameworkCore;
using TaskWebApi.Service.Interfaces.configure;
using TaskWebApi.DTO;

namespace TaskWebApi.Repository.database.Configuration;

public class RelativePersonConfiguration : IEntityConfiguration
{
    public bool Configure(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<RelativePerson>()
            .HasKey(rp => new { rp.PersonId, rp.RelativeToId });

        modelBuilder.Entity<RelativePerson>()
            .HasOne(rp => rp.Person)
            .WithMany(p => p.Persons)
            .IsRequired();

        modelBuilder.Entity<RelativePerson>()
            .HasOne(rp => rp.RelativeTo)
            .WithMany(p => p.Relatives)
            .IsRequired();

        modelBuilder.Entity<RelativePerson>()
            .Property(rp => rp.RelativePersonType)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        return true;
    }
}
