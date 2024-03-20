﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskWebApi.Repository;

#nullable disable

namespace TaskWebApi.Repository.Migrations
{
    [DbContext(typeof(TaskWebApiDbContext))]
    [Migration("20240320071008_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskWebApi.DTO.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CityId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TaskWebApi.DTO.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)");

                    b.Property<DateTime>("Birthday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(115)");

                    b.HasKey("PersonId");

                    b.HasIndex("CityId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TaskWebApi.DTO.PhoneNumber", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneNumberId"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberType")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("PhoneNumberId");

                    b.HasIndex("PersonId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("TaskWebApi.DTO.RelativePerson", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("RelativeToId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("RelativePersonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("PersonId", "RelativeToId");

                    b.HasIndex("RelativeToId");

                    b.ToTable("RelativePersons");
                });

            modelBuilder.Entity("TaskWebApi.DTO.Person", b =>
                {
                    b.HasOne("TaskWebApi.DTO.City", "City")
                        .WithMany("Person")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("TaskWebApi.DTO.PhoneNumber", b =>
                {
                    b.HasOne("TaskWebApi.DTO.Person", "Person")
                        .WithMany("PhoneNumber")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TaskWebApi.DTO.RelativePerson", b =>
                {
                    b.HasOne("TaskWebApi.DTO.Person", "Person")
                        .WithMany("Persons")
                        .HasForeignKey("PersonId");

                    b.HasOne("TaskWebApi.DTO.Person", "RelativeTo")
                        .WithMany("Relatives")
                        .HasForeignKey("RelativeToId");

                    b.Navigation("Person");

                    b.Navigation("RelativeTo");
                });

            modelBuilder.Entity("TaskWebApi.DTO.City", b =>
                {
                    b.Navigation("Person");
                });

            modelBuilder.Entity("TaskWebApi.DTO.Person", b =>
                {
                    b.Navigation("Persons");

                    b.Navigation("PhoneNumber");

                    b.Navigation("Relatives");
                });
#pragma warning restore 612, 618
        }
    }
}
