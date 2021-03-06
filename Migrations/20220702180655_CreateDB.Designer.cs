// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSFInventory.Models;

namespace SSFInventory.Migrations
{
    [DbContext(typeof(SSFInventoryDbContext))]
    [Migration("20220702180655_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SSFInventory.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatgDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatgNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LockedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("LockedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Storeid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
