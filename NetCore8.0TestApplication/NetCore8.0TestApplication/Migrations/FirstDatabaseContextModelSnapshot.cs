﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore8TestApplication.Data;

#nullable disable

namespace NetCore8TestApplication.Migrations
{
    [DbContext(typeof(FirstDatabaseContext))]
    partial class FirstDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NetCore8TestApplication.Data.FirstDataModel", b =>
                {
                    b.Property<int>("FirstDataModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirstDataModelID"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirstDataModelID");

                    b.ToTable("FirstDataModels");

                    b.HasData(
                        new
                        {
                            FirstDataModelID = 1,
                            LastName = "",
                            Name = "First name",
                            SecondName = "",
                            ThirdName = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
