using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFASS.Iti;
using EFASS.Models;
using Microsoft.EntityFrameworkCore;


namespace EFASS
{
    internal class ItiDBContext : DbContext
    {
        public DbSet<Student>Students{ set; get; }
        public DbSet<Course>courses{ set; get; }
        public DbSet<Instructor>instructors{ set; get; }
        public DbSet<Course_Inst> course_Insts {  set; get; }
        public DbSet<Topic>topics { set; get; }

        public DbSet<Department> departments { set; get; }
        public DbSet<Stud_Course>stud_Courses { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnection");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(builder =>
            {
                builder.ToTable("Student").HasKey(x=>x.Id);
                builder.Property(x=>x.LName).IsRequired().HasMaxLength(50);
                builder.Property(x => x.FName).IsRequired().HasMaxLength(50);
                builder.Property(x=>x.Address).IsRequired().HasMaxLength(50);
            });
            modelBuilder.Entity<Course>(builder =>
            {
                builder.ToTable("Course").HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
                builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
                builder.Property(x => x.Duration).IsRequired().HasMaxLength(50);
            });
            modelBuilder.Entity<Instructor>(builder =>
            {
                builder.ToTable("Instructor").HasKey(x => x.ID);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
                builder.Property(x => x.Adress).IsRequired().HasMaxLength(50);
                builder.Property(x => x.Bouns).IsRequired();
                builder.Property(x => x.Salary).IsRequired();

            });
            modelBuilder.Entity<Topic>(builder =>
            {
                builder.ToTable("Topic").HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            

            });

            modelBuilder.Entity<Stud_Course>(builder =>
            {
                //builder.ToTable("Instructor").HasKey(x => x.stud_ID);
                //builder.Property(x => x.Course_ID).IsRequired();
                builder.Property(x => x.Grade).IsRequired().HasMaxLength(50);
               
            });
            modelBuilder.Entity<Department>(builder =>
            {
                builder.ToTable("Department").HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
              //  builder.Property(x => x.Ins_ID).IsRequired();
             
              
            });



            modelBuilder.Entity<Course_Inst>(builder =>
            {
                //builder.ToTable("Course_Inst").HasKey(x => x.Course_ID);
                //builder.Property(x => x.inst_ID).IsRequired();
              


            });




        }


    }

    
}
