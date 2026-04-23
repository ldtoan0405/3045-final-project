using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class TeamMember
{
    [Key]
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }
    public string CollegeProgram { get; set; } = string.Empty;
    public string YearInProgram { get; set; } = string.Empty;
}
public class Hobby
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int SkillLevel { get; set; } // 1-10
    public bool IsIndoor { get; set; }
}