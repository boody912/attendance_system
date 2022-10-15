using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace attendance_system.Models
{
    public partial class attendance_systemContext : DbContext
    {
        public attendance_systemContext()
        {
        }

        public attendance_systemContext(DbContextOptions<attendance_systemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAttendance> TbAttendances { get; set; }
        public virtual DbSet<TbClassroom> TbClassrooms { get; set; }
        public virtual DbSet<TbClassroomStudent> TbClassroomStudents { get; set; }
        public virtual DbSet<TbDoctor> TbDoctors { get; set; }
        public virtual DbSet<TbRebort> TbReborts { get; set; }
        public virtual DbSet<TbStudent> TbStudents { get; set; }
        public virtual DbSet<TbSubject> TbSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-532GCGK;Database=attendance_system;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAttendance>(entity =>
            {
                entity.ToTable("TbAttendance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Boolean)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DocId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Doc_Id");

                entity.Property(e => e.StudId).HasColumnName("stud_Id");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.TbAttendances)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAttendance_TbDoctor");

                entity.HasOne(d => d.Stud)
                    .WithMany(p => p.TbAttendances)
                    .HasForeignKey(d => d.StudId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAttendance_TbStudent");
            });

            modelBuilder.Entity<TbClassroom>(entity =>
            {
                entity.ToTable("TbClassroom");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.TbClassrooms)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbClassroom_TbDoctor");
            });

            modelBuilder.Entity<TbClassroomStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TbClassroom_Student");

                entity.Property(e => e.ClassroomId).HasColumnName("Classroom_Id");

                entity.Property(e => e.StudId).HasColumnName("Stud_Id");

                entity.HasOne(d => d.Classroom)
                    .WithMany()
                    .HasForeignKey(d => d.ClassroomId)
                    .HasConstraintName("FK_TbClassroom_Student_TbClassroom");

                entity.HasOne(d => d.Stud)
                    .WithMany()
                    .HasForeignKey(d => d.StudId)
                    .HasConstraintName("FK_TbClassroom_Student_TbStudent");
            });

            modelBuilder.Entity<TbDoctor>(entity =>
            {
                entity.ToTable("TbDoctor");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRebort>(entity =>
            {
                entity.ToTable("TbRebort");

                entity.Property(e => e.AttendId).HasColumnName("Attend_Id");

                entity.Property(e => e.StudId).HasColumnName("Stud_Id");

                entity.Property(e => e.SubId).HasColumnName("Sub_Id");

                entity.HasOne(d => d.Attend)
                    .WithMany(p => p.TbReborts)
                    .HasForeignKey(d => d.AttendId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbRebort_TbAttendance");

                entity.HasOne(d => d.Stud)
                    .WithMany(p => p.TbReborts)
                    .HasForeignKey(d => d.StudId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbRebort_TbStudent");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.TbReborts)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbRebort_TbSubject");
            });

            modelBuilder.Entity<TbStudent>(entity =>
            {
                entity.ToTable("TbStudent");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSubject>(entity =>
            {
                entity.ToTable("TbSubject");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
