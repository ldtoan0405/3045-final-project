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

public class FavoriteCity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public int Population { get; set; }
    public bool HasMajorAirport { get; set; }
}

public class BreakfastFood
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MainIngredient { get; set; }
    public int Calories { get; set; }
    public bool IsVegetarian { get; set; }
}