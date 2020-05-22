﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zestaw11.Models;

namespace Zestaw11.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200522195017_Dolna_Partia")]
    partial class Dolna_Partia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Zestaw11.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Zestaw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Zestaw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("doctorId")
                        .HasColumnType("int");

                    b.Property<int?>("patientIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientIdPatient");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Zestaw11.Models.Prescription", b =>
                {
                    b.HasOne("Zestaw11.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");

                    b.HasOne("Zestaw11.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientIdPatient");
                });
#pragma warning restore 612, 618
        }
    }
}