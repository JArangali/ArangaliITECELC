using System;
using ArangaliITELEC1C.Models;
namespace ArangaliITELEC1C.Services;

public class MyFakeDataService : IMyFakeDataService
{
   public List<Student> StudentList { get; }
   public List<Instructor> InstructorList { get; }

    public MyFakeDataService()
	{
        StudentList = new List<Student>
        {
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
                GPA = 1.25
            }

        };

        InstructorList = new List<Instructor>
        {
            new Instructor()

            {   Id = 1,
                InstructorFirstName = "Jasper Lindell",
                InstructorLastName = "Arangali",
                DateHired = DateTime.Now,
                InstructorIsTenured = true,
                Rank = Rank.Instructor
            },
            new Instructor()
            {
                Id = 2,
                InstructorFirstName = "Gabriel",
                InstructorLastName = "Montano",
                DateHired = DateTime.Parse("02/09/2019"),
                InstructorIsTenured = true,
                Rank = Rank.AssociateProfessor
            },
            new Instructor()
            {
                Id = 3,
                InstructorFirstName = "Marcus Andre",
                InstructorLastName = "Caronongan",
                DateHired = DateTime.Parse("09/20/2003"),
                InstructorIsTenured = false,
                Rank = Rank.Professor
            }
        };
    }
}

