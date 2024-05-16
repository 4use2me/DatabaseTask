﻿// <auto-generated />
using System;
using DatabaseTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Migrations
{
    [DbContext(typeof(DatabaseTaskContext))]
    partial class DatabaseTaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Models.AccessPermission", b =>
                {
                    b.Property<int>("AccessPermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessPermissionID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleID")
                        .HasColumnType("int");

                    b.Property<int>("PermissionNr")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidSince")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("AccessPermissionID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("JobTitleID");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("DatabaseTask.Models.BranchOffice", b =>
                {
                    b.Property<int>("BranchOfficeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchOfficeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ContactPhone")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FirmID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("BranchOfficeID");

                    b.HasIndex("FirmID");

                    b.ToTable("BranchOffices");
                });

            modelBuilder.Entity("DatabaseTask.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("BranchOfficeID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactPhone")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("JobTitleID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PersonalIdentificationCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("WorkingSince")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WorkingUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeID");

                    b.HasIndex("BranchOfficeID");

                    b.HasIndex("JobTitleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Models.EmployeesChild", b =>
                {
                    b.Property<int>("EmployeesChildID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeesChildID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PersonalIdentificationCode")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("EmployeesChildID");

                    b.ToTable("EmployeesChildren");
                });

            modelBuilder.Entity("DatabaseTask.Models.Firm", b =>
                {
                    b.Property<int>("FirmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirmID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ContactPhone")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Registry")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("FirmID");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("DatabaseTask.Models.HealthInspection", b =>
                {
                    b.Property<int>("HealthInspectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthInspectionID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastInspection")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NewInspectionDue")
                        .HasColumnType("datetime2");

                    b.HasKey("HealthInspectionID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("HealthInspections");
                });

            modelBuilder.Entity("DatabaseTask.Models.Hint", b =>
                {
                    b.Property<int>("HintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HintID"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("HintID");

                    b.ToTable("Hints");
                });

            modelBuilder.Entity("DatabaseTask.Models.Holiday", b =>
                {
                    b.Property<int>("HolidayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HolidayID"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HolidayID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("DatabaseTask.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobTitleID"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("JobTitleID");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("DatabaseTask.Models.Object", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjectID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("History")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ObjectLocation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("PurchasingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ObjectID");

                    b.ToTable("Objects");
                });

            modelBuilder.Entity("DatabaseTask.Models.ParentChild", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesChildID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "EmployeesChildID");

                    b.HasIndex("EmployeesChildID");

                    b.ToTable("ParentChildren");
                });

            modelBuilder.Entity("DatabaseTask.Models.Renting", b =>
                {
                    b.Property<int>("RentingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentingID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObjectID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RentingID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ObjectID");

                    b.ToTable("Rentings");
                });

            modelBuilder.Entity("DatabaseTask.Models.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestID"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("RequestID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DatabaseTask.Models.SickLeave", b =>
                {
                    b.Property<int>("SickLeaveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SickLeaveID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SickLeaveID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("SickLeaves");
                });

            modelBuilder.Entity("DatabaseTask.Models.WorkingHistory", b =>
                {
                    b.Property<int>("WorkingHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkingHistoryID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobTitleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkingHistoryID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("JobTitleID");

                    b.ToTable("WorkingHistories");
                });

            modelBuilder.Entity("DatabaseTask.Models.AccessPermission", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("AccessPermissions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Models.JobTitle", "JobTitle")
                        .WithMany("AccessPermissions")
                        .HasForeignKey("JobTitleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("DatabaseTask.Models.BranchOffice", b =>
                {
                    b.HasOne("DatabaseTask.Models.Firm", "Firm")
                        .WithMany("BranchOffices")
                        .HasForeignKey("FirmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("DatabaseTask.Models.Employee", b =>
                {
                    b.HasOne("DatabaseTask.Models.BranchOffice", "BranchOffice")
                        .WithMany("Employees")
                        .HasForeignKey("BranchOfficeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Models.JobTitle", "JobTitle")
                        .WithMany("Employees")
                        .HasForeignKey("JobTitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BranchOffice");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("DatabaseTask.Models.HealthInspection", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("HealthInspections")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Models.Holiday", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("Holidays")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Models.ParentChild", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("ParentChildren")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Models.EmployeesChild", "EmployeesChild")
                        .WithMany("ParentChildren")
                        .HasForeignKey("EmployeesChildID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("EmployeesChild");
                });

            modelBuilder.Entity("DatabaseTask.Models.Renting", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("Rentings")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Models.Object", "Object")
                        .WithMany("Rentings")
                        .HasForeignKey("ObjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Object");
                });

            modelBuilder.Entity("DatabaseTask.Models.Request", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("Requests")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Models.SickLeave", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("SickLeaves")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Models.WorkingHistory", b =>
                {
                    b.HasOne("DatabaseTask.Models.Employee", "Employee")
                        .WithMany("WorkingHistories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Models.JobTitle", "JobTitle")
                        .WithMany("WorkingHistories")
                        .HasForeignKey("JobTitleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("DatabaseTask.Models.BranchOffice", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Models.Employee", b =>
                {
                    b.Navigation("AccessPermissions");

                    b.Navigation("HealthInspections");

                    b.Navigation("Holidays");

                    b.Navigation("ParentChildren");

                    b.Navigation("Rentings");

                    b.Navigation("Requests");

                    b.Navigation("SickLeaves");

                    b.Navigation("WorkingHistories");
                });

            modelBuilder.Entity("DatabaseTask.Models.EmployeesChild", b =>
                {
                    b.Navigation("ParentChildren");
                });

            modelBuilder.Entity("DatabaseTask.Models.Firm", b =>
                {
                    b.Navigation("BranchOffices");
                });

            modelBuilder.Entity("DatabaseTask.Models.JobTitle", b =>
                {
                    b.Navigation("AccessPermissions");

                    b.Navigation("Employees");

                    b.Navigation("WorkingHistories");
                });

            modelBuilder.Entity("DatabaseTask.Models.Object", b =>
                {
                    b.Navigation("Rentings");
                });
#pragma warning restore 612, 618
        }
    }
}
