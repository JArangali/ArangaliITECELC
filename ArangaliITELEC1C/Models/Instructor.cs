namespace ArangaliITELEC1C.Models;

public enum Rank
{ 
    Instructor, AsstistantProfessor, Professor, AssociateProfessor,
}

public class Instructor
{
    public int Id { get; set; }
    public string InstructorFirstName { get; set; }
    public string InstructorLastName { get; set; }
    public bool InstructorIsTenured { get; set; }
    public DateTime DateHired { get; set; }
    public Rank Rank { get; set; }
}

