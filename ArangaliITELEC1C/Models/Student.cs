namespace ArangaliITELEC1C.Models;

public enum Course
{
    BSIT, BSCS, BSIS, OTHER
}

public class Student
{
    public int StudentId { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public DateTime AdmissionDate { get; set; }
    public Course Course { get; set; }
    public string Email { get; set; }
    public double GPA { get; set; }
}