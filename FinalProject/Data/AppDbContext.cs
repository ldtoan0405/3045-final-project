using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Hobby> Hobbies { get; set; }
    public DbSet<FavoriteCity> FavoriteCities { get; set; }
    public DbSet<BreakfastFood> BreakfastFoods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seeding TeamMembers
        modelBuilder.Entity<TeamMember>().HasData(
            new TeamMember { Id = 1, FullName = "Duc Toan Le", Birthdate = new DateTime(2004, 5, 4), CollegeProgram = "Mathematics", YearInProgram = "Junior" },
            new TeamMember { Id = 2, FullName = "Nate Otten", Birthdate = new DateTime(2007, 1, 5), CollegeProgram = "Information Technology", YearInProgram = "Freshman" },
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

        modelBuilder.Entity<FavoriteCity>().HasData(
            new FavoriteCity { Id = 1, Name = "Cincinnati", State = "Ohio", Population = 309000, HasMajorAirport = true },
            new FavoriteCity { Id = 2, Name = "Nashville", State = "Tennessee", Population = 689000, HasMajorAirport = true },
            new FavoriteCity { Id = 3, Name = "Boulder", State = "Colorado", Population = 108000, HasMajorAirport = false },
            new FavoriteCity { Id = 4, Name = "Savannah", State = "Georgia", Population = 147000, HasMajorAirport = true },
            new FavoriteCity { Id = 5, Name = "Asheville", State = "North Carolina", Population = 94000, HasMajorAirport = false }
        );

        modelBuilder.Entity<BreakfastFood>().HasData(
            new BreakfastFood { Id = 1, Name = "Pancakes", MainIngredient = "Flour", Calories = 350, IsVegetarian = true },
            new BreakfastFood { Id = 2, Name = "Omelet", MainIngredient = "Eggs", Calories = 250, IsVegetarian = true },
            new BreakfastFood { Id = 3, Name = "Bacon & Eggs", MainIngredient = "Bacon", Calories = 450, IsVegetarian = false },
            new BreakfastFood { Id = 4, Name = "Greek Yogurt", MainIngredient = "Milk", Calories = 150, IsVegetarian = true },
            new BreakfastFood { Id = 5, Name = "Breakfast Burrito", MainIngredient = "Tortilla", Calories = 600, IsVegetarian = false }
        );
    }
}