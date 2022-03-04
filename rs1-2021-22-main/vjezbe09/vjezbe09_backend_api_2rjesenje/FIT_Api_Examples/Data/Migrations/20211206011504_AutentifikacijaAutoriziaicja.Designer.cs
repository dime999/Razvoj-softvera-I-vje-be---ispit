﻿// <auto-generated />
using System;
using FIT_Api_Examples.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIT_Api_Examples.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211206011504_AutentifikacijaAutoriziaicja")]
    partial class AutentifikacijaAutoriziaicja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_korisnika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator<string>("Discriminator").HasValue("KorisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("employee_age")
                        .HasColumnType("int");

                    b.Property<string>("employee_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("employee_salary")
                        .HasColumnType("real");

                    b.Property<string>("profile_image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20210601Posalji", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicniBrojKupca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Upit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ispit20210601Posalji");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20210702Posalji", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ispit20210702Posalji");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.ProjectTask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<float?>("original_estimated_hours")
                        .HasColumnType("real");

                    b.Property<int>("percent_completed")
                        .HasColumnType("int");

                    b.Property<int>("project_id")
                        .HasColumnType("int");

                    b.Property<float?>("spent_hours")
                        .HasColumnType("real");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("employee_id");

                    b.HasIndex("project_id");

                    b.ToTable("ProjectTask");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.TimeTracking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("project_task_id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("spent_time")
                        .HasColumnType("time");

                    b.Property<DateTime>("start_time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("project_task_id");

                    b.ToTable("TimeTracking");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("drzava_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("drzava_id");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("broj_indeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datum_rodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("opstina_rodjenja_id")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_studenta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("opstina_rodjenja_id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIspita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.ToTable("Ispit");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ECTS")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IspitID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PrijavaIspita");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Nastavnik", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Nastavnik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.ProjectTask", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul1.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("project_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.TimeTracking", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Models.ProjectTask", "project_task")
                        .WithMany()
                        .HasForeignKey("project_task_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzava_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Opstina", "opstina_rodjenja")
                        .WithMany()
                        .HasForeignKey("opstina_rodjenja_id");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul3.Models.Predmet", "predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
