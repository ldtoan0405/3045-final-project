using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Hobby> Hobbies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seeding TeamMembers
        modelBuilder.Entity<TeamMember>().HasData(
            new TeamMember { Id = 1, FullName = "Duc Toan Le", Birthdate = new DateTime(2004, 5, 4), CollegeProgram = "Mathematics", YearInProgram = "Junior" },
            new TeamMember { Id = 2, FullName = "Jane Doe", Birthdate = new DateTime(1999, 5, 15), CollegeProgram = "Engineering", YearInProgram = "Senior" },
            new TeamMember { Id = 3, FullName = "Bob Smith", Birthdate = new DateTime(2001, 3, 22), CollegeProgram = "Math", YearInProgram = "Sophomore" },
            new TeamMember { Id = 4, FullName = "Alice Wong", Birthdate = new DateTime(2002, 11, 30), CollegeProgram = "Physics", YearInProgram = "Freshman" },
            new TeamMember { Id = 5, FullName = "Charlie Brown", Birthdate = new DateTime(2000, 7, 4), CollegeProgram = "Statistics", YearInProgram = "Junior" }
        );

        modelBuilder.Entity<Hobby>().HasData(
            new Hobby { Id = 1, Name = "Photography", Category = "Arts", SkillLevel = 7, IsIndoor = false },
            new Hobby { Id = 2, Name = "Coding", Category = "Technology", SkillLevel = 9, IsIndoor = true },
            new Hobby { Id = 3, Name = "Chess", Category = "Games", SkillLevel = 5, IsIndoor = true },
            new Hobby { Id = 4, Name = "Hiking", Category = "Outdoors", SkillLevel = 8, IsIndoor = false },
            new Hobby { Id = 5, Name = "Cooking", Category = "Culinary", SkillLevel = 6, IsIndoor = true }
        );
    }
}