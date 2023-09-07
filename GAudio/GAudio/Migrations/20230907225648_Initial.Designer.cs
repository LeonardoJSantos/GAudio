﻿// <auto-generated />
using System;
using GAudio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GAudio.Migrations
{
    [DbContext(typeof(GAudioContext))]
    [Migration("20230907225648_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GAudio.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("GAudio.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Admission")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Birdhday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FunctionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("GAudio.Models.Enums.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cnae")
                        .HasColumnType("int");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RiskDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("GAudio.Models.Function", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("GAudio.Models.Ghe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Ghe");
                });

            modelBuilder.Entity("GAudio.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GheId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GheId");

                    b.HasIndex("UnitId");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("GAudio.Models.Employee", b =>
                {
                    b.HasOne("GAudio.Models.Function", "Function")
                        .WithMany("employees")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Function");
                });

            modelBuilder.Entity("GAudio.Models.Enums.Unit", b =>
                {
                    b.HasOne("GAudio.Models.Company", "Company")
                        .WithMany("Units")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("GAudio.Models.Function", b =>
                {
                    b.HasOne("GAudio.Models.Sector", "Sector")
                        .WithMany("functions")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("GAudio.Models.Ghe", b =>
                {
                    b.HasOne("GAudio.Models.Enums.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("GAudio.Models.Sector", b =>
                {
                    b.HasOne("GAudio.Models.Ghe", "Ghe")
                        .WithMany("sectors")
                        .HasForeignKey("GheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GAudio.Models.Enums.Unit", null)
                        .WithMany("Sectors")
                        .HasForeignKey("UnitId");

                    b.Navigation("Ghe");
                });

            modelBuilder.Entity("GAudio.Models.Company", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("GAudio.Models.Enums.Unit", b =>
                {
                    b.Navigation("Sectors");
                });

            modelBuilder.Entity("GAudio.Models.Function", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("GAudio.Models.Ghe", b =>
                {
                    b.Navigation("sectors");
                });

            modelBuilder.Entity("GAudio.Models.Sector", b =>
                {
                    b.Navigation("functions");
                });
#pragma warning restore 612, 618
        }
    }
}