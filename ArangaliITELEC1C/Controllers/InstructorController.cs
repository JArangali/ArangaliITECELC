using Microsoft.AspNetCore.Mvc;
using ArangaliITELEC1C.Models;
using ArangaliITELEC1C.Services;

namespace ArangaliITELEC1C.Controllers;

    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

       public InstructorController(IMyFakeDataService dummyData)
    {
        _dummyData = dummyData;
    }

    public IActionResult Index()
        {
        return View(_dummyData.InstructorList);
    }

    public IActionResult ShowDetail(int id)
    {
        //Search for the Instructor whose id matches the given id
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }

    [HttpGet]
    public IActionResult AddInstructor()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddInstructor(Instructor newInstructor)
    {
        _dummyData.InstructorList.Add(newInstructor);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateInstructor(int id)
    {
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }

    [HttpPost]
    public IActionResult UpdateStudent(Instructor instructorChanges)
    {
        Instructor? instructor= _dummyData.InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);

        if (instructor != null)
        {
            instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
            instructor.InstructorLastName = instructorChanges.InstructorLastName;
            instructor.InstructorIsTenured = instructorChanges.InstructorIsTenured;
            instructor.Rank = instructorChanges.Rank;
            instructor.DateHired = instructorChanges.DateHired;
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {

        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }

    [HttpPost]
    public IActionResult Delete(Instructor newInstructor)
    {
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

        if (instructor != null)
            _dummyData.InstructorList.Remove(instructor);
        return RedirectToAction("Index");
    }
}
