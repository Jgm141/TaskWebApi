using TaskWebApi.DTO;
using Microsoft.EntityFrameworkCore;
using TaskWebApi.Repository.database.Configuration;

namespace TaskWebApi.Repository;

public class TaskWebApiDbContext : DbContext
{
    public TaskWebApiDbContext(DbContextOptions options) : base(options)
    {

    }

    #region OldEntityConfiguration
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<City>().Property(a => a.Name).HasColumnType("nvarchar(20)").IsRequired();
    //    modelBuilder.Entity<City>().HasIndex(a => a.Name).IsUnique(true);
    //    modelBuilder.Entity<City>().Property(a => a.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValue(false);
    //    modelBuilder.Entity<City>().Property(a => a.CreateDate).HasColumnType("date").HasDefaultValueSql("GetDate()");
    //    modelBuilder.Entity<City>().HasMany(p => p.Person).WithOne(p => p.City).IsRequired();

    //    modelBuilder.Entity<RelativePerson>().HasKey(rp => new { rp.PersonId, rp.RelativeToId });
    //    modelBuilder.Entity<RelativePerson>().HasOne(rp => rp.Person).WithMany(p => p.Persons).IsRequired();
    //    modelBuilder.Entity<RelativePerson>().HasOne(rp => rp.RelativeTo).WithMany(p => p.Relatives).IsRequired();
    //    modelBuilder.Entity<RelativePerson>().Property(rp => rp.RelativePersonType).HasColumnType("nvarchar(15)").IsRequired();

    //    modelBuilder.Entity<PhoneNumber>().Property(a => a.Number).HasColumnType("nvarchar(25)").IsRequired();
    //    modelBuilder.Entity<PhoneNumber>().Property(a => a.PhoneNumberType).HasColumnType("nvarchar(15)").IsRequired();
    //    modelBuilder.Entity<PhoneNumber>().Property(a => a.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValue(false);
    //    modelBuilder.Entity<PhoneNumber>().Property(a => a.CreateDate).HasColumnType("date").HasDefaultValueSql("GetDate()");
    //    modelBuilder.Entity<PhoneNumber>().HasOne(a => a.Person).WithMany(a=>a.PhoneNumber).IsRequired();

    //    modelBuilder.Entity<Person>().Property(a => a.FirstName).HasColumnType("nvarchar(35)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.LastName).HasColumnType("nvarchar(35)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.Address).HasColumnType("nvarchar(35)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.Gender).HasColumnType("nvarchar(15)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.PersonalNumber).HasColumnType("nvarchar(11)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.Birthday).HasColumnType("date").HasDefaultValueSql("GetDate()");
    //    modelBuilder.Entity<Person>().Property(a => a.picture).HasColumnType("nvarchar(115)").IsRequired();
    //    modelBuilder.Entity<Person>().Property(a => a.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValue(false);
    //    modelBuilder.Entity<Person>().Property(a => a.CreateDate).HasColumnType("date").HasDefaultValueSql("GetDate()");
    //    modelBuilder.Entity<Person>().HasOne(a => a.City).WithMany(a => a.Person).IsRequired();
    //    modelBuilder.Entity<Person>().HasMany(a => a.PhoneNumber).WithOne(a => a.Person).IsRequired();
    //    modelBuilder.Entity<Person>().HasMany(a=> a.Persons).WithOne(a=> a.Person).IsRequired(false);
    //    modelBuilder.Entity<Person>().HasMany(a => a.Relatives).WithOne(a => a.RelativeTo).IsRequired(false);
    //} 
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigureEntities();
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    public DbSet<RelativePerson> RelativePersons { get; set; }
}
