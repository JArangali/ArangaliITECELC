using System;
using ArangaliITELEC1C.Models;
using Microsoft.EntityFrameworkCore;

namespace ArangaliITELEC1C.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    StudentFirstName = "Jasper Lindell",
                    StudentLastName = "Arangali",
                    AdmissionDate = DateTime.Parse("8/30/2023"),
                    Course = Course.BSIT,
                    Email = "jasperlindell.arangali.cics@ust.edu.ph",
                    GPA = 1
                },

            new Student()
            {
                StudentId = 2,
                StudentFirstName = "Luis Enrico",
                StudentLastName = "Granada",
                AdmissionDate = DateTime.Parse("8/30/2023"),
                Course = Course.BSIT,
                Email = "luisenrico.granada.cics@ust.edu.ph",
                GPA = 2
            },

            new Student()
            {
                StudentId = 3,
                StudentFirstName = "Lourdes Ashley",
                StudentLastName = "Santos",
                AdmissionDate = DateTime.Parse("8/30/2023"),
                Course = Course.BSIT,
                Email = "lourdesashley.santos.cics@ust.edu.ph",
                GPA = 1
            }
            );

        }
	}
}

