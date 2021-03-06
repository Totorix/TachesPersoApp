// <auto-generated />
using System;
using EFDataAccessLibrary.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFDataAccessLibrary.Migrations
{
    [DbContext(typeof(TacheContext))]
    [Migration("20220501181632_initBase")]
    partial class initBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFDataAccessLibrary.Models.Acte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TacheId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TacheId");

                    b.ToTable("Actes");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Tache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Taches");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Acte", b =>
                {
                    b.HasOne("EFDataAccessLibrary.Models.Tache", null)
                        .WithMany("Actions")
                        .HasForeignKey("TacheId");
                });
#pragma warning restore 612, 618
        }
    }
}
