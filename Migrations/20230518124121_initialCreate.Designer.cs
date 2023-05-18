﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ogrenci_Not_Kayit_Sistemi.DataAccess;

namespace Ogrenci_Not_Kayit_Sistemi.Migrations
{
    [DbContext(typeof(StudentsContext))]
    [Migration("20230518124121_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ogrenci_Not_Kayit_Sistemi.Entities.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("Numara")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<decimal>("Ortalama")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sinav1")
                        .HasColumnType("int");

                    b.Property<int>("Sinav2")
                        .HasColumnType("int");

                    b.Property<int>("Sinav3")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}