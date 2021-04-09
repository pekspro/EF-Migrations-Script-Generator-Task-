﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore5TestApplication.Data;

namespace NetCore5TestApplication.Migrations
{
    [DbContext(typeof(FirstDatabaseContext))]
    [Migration("20210408185844_AddSecondName")]
    partial class AddSecondName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NetCore5TestApplication.Data.FirstDataModel", b =>
                {
                    b.Property<int>("FirstDataModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirstDataModelID");

                    b.ToTable("FirstDataModels");

                    b.HasData(
                        new
                        {
                            FirstDataModelID = 1,
                            LastName = "Last name",
                            Name = "First name"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
