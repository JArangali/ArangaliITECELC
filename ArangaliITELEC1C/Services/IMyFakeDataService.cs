using System;
using ArangaliITELEC1C.Models;
namespace ArangaliITELEC1C.Services
{
	public interface IMyFakeDataService
	{
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}

