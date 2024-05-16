using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTask.Models
{
    public partial class DatabaseTaskContext : DbContext
    {
        public DatabaseTaskContext()
        {
        }

        public DatabaseTaskContext(DbContextOptions<DatabaseTaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<BranchOffice> BranchOffices { get; set; } = null!;
        public virtual DbSet<AccessPermission> AccessPermissions { get; set; } = null!;
        public virtual DbSet<EmployeesChild> EmployeesChildren { get; set; } = null!;
        public virtual DbSet<Firm> Firms { get; set; } = null!;
        public virtual DbSet<HealthInspection> HealthInspections { get; set; } = null!;
        public virtual DbSet<Hint> Hints { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<Object> Objects { get; set; } = null!;
        public virtual DbSet<ParentChild> ParentChildren { get; set; } = null!;
        public virtual DbSet<Renting> Rentings { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<SickLeave> SickLeaves { get; set; } = null!;
        public virtual DbSet<WorkingHistory> WorkingHistories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= WINDOWS-1DCGN01;Database=DatabaseTask;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(255);
                entity.Property(e => e.LastName).HasMaxLength(255);
                entity.Property(e => e.Address).HasMaxLength(255);
                entity.Property(e => e.EmailAddress).HasMaxLength(255);
                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.HasOne(e => e.JobTitle)
                      .WithMany(j => j.Employees)
                      .HasForeignKey(e => e.JobTitleID);
                entity.HasOne(e => e.BranchOffice)
                      .WithMany(b => b.Employees)
                      .HasForeignKey(e => e.BranchOfficeID);
            });

            modelBuilder.Entity<AccessPermission>(entity =>
            {
                entity.Property(a => a.Comment).HasMaxLength(255);

                entity.HasOne(a => a.JobTitle)
                      .WithMany(j => j.AccessPermissions)
                      .HasForeignKey(a => a.JobTitleID)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(a => a.Employee)
                      .WithMany(e => e.AccessPermissions)
                      .HasForeignKey(a => a.EmployeeID)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<BranchOffice>(entity =>
            {
                entity.Property(b => b.Name).HasMaxLength(255);
                entity.Property(b => b.Address).HasMaxLength(255);
                entity.Property(b => b.ContactPerson).HasMaxLength(255);
                entity.Property(b => b.EmailAddress).HasMaxLength(255);
                entity.Property(b => b.Comment).HasMaxLength(255);

                entity.HasOne(b => b.Firm)
                      .WithMany(f => f.BranchOffices)
                      .HasForeignKey(b => b.FirmID);
            });

            modelBuilder.Entity<EmployeesChild>(entity =>
            {
                entity.Property(ec => ec.Name).HasMaxLength(255);
                entity.Property(ec => ec.SurName).HasMaxLength(255);
                entity.Property(ec => ec.Comment).HasMaxLength(255);
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(f => f.Name).HasMaxLength(255);
                entity.Property(f => f.Registry).HasMaxLength(255);
                entity.Property(f => f.ContactPerson).HasMaxLength(255);
                entity.Property(f => f.Address).HasMaxLength(255);
                entity.Property(f => f.EmailAddress).HasMaxLength(255);
                entity.Property(f => f.Comment).HasMaxLength(255);
            });

            modelBuilder.Entity<HealthInspection>(entity =>
            {
                entity.Property(hi => hi.Comment).HasMaxLength(255);

                entity.HasOne(hi => hi.Employee)
                      .WithMany(e => e.HealthInspections)
                      .HasForeignKey(hi => hi.EmployeeID);
            });

            modelBuilder.Entity<Hint>(entity =>
            {
                entity.Property(h => h.Description).HasMaxLength(255);
                entity.Property(h => h.Comment).HasMaxLength(255);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.Property(hd => hd.Comment).HasMaxLength(255);

                entity.HasOne(hd => hd.Employee)
                      .WithMany(e => e.Holidays)
                      .HasForeignKey(hd => hd.EmployeeID);
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(j => j.Title).HasMaxLength(255);
                entity.Property(j => j.Unit).HasMaxLength(255);
                entity.Property(j => j.Comment).HasMaxLength(255);
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.Property(o => o.ObjectLocation).HasMaxLength(255);
                entity.Property(o => o.History).HasMaxLength(255);
                entity.Property(o => o.Comment).HasMaxLength(255);
            });

            modelBuilder.Entity<ParentChild>(entity =>
            {
                entity.HasKey(pc => new { pc.EmployeeID, pc.EmployeesChildID });

                entity.HasOne(pc => pc.Employee)
                      .WithMany(e => e.ParentChildren)
                      .HasForeignKey(pc => pc.EmployeeID);

                entity.HasOne(pc => pc.EmployeesChild)
                      .WithMany(ec => ec.ParentChildren)
                      .HasForeignKey(pc => pc.EmployeesChildID);
            });

            modelBuilder.Entity<Renting>(entity =>
            {
                entity.Property(r => r.Comment).HasMaxLength(255);

                entity.HasOne(r => r.Employee)
                      .WithMany(e => e.Rentings)
                      .HasForeignKey(r => r.EmployeeID);
                entity.HasOne(r => r.Object)
                      .WithMany(o => o.Rentings)
                      .HasForeignKey(r => r.ObjectID);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(rq => rq.Description).HasMaxLength(255);
                entity.Property(rq => rq.Comment).HasMaxLength(255);

                entity.HasOne(rq => rq.Employee)
                      .WithMany(e => e.Requests)
                      .HasForeignKey(rq => rq.EmployeeID);
            });

            modelBuilder.Entity<SickLeave>(entity =>
            {
                entity.Property(s => s.Comment).HasMaxLength(255);

                entity.HasOne(s => s.Employee)
                      .WithMany(e => e.SickLeaves)
                      .HasForeignKey(s => s.EmployeeID);
            });

            modelBuilder.Entity<WorkingHistory>(entity =>
            {
                entity.Property(w => w.Comment).HasMaxLength(255);

                entity.HasOne(w => w.Employee)
                      .WithMany(e => e.WorkingHistories)
                      .HasForeignKey(w => w.EmployeeID)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(w => w.JobTitle)
                      .WithMany(j => j.WorkingHistories)
                      .HasForeignKey(w => w.JobTitleID)
                      .OnDelete(DeleteBehavior.NoAction);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
