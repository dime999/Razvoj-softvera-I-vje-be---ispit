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
    [Migration("20210503220906_student3")]
    partial class student3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FIT_Api_Examples.Models.Employee", b =>
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
#pragma warning restore 612, 618
        }
    }
}