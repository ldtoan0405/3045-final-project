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
            new TeamMember { Id = 3, FullName = "Jimmy Buffett", Birthdate = new DateTime(1946, 12, 25), CollegeProgram = "Business Administration", YearInProgram = "Senior" },
            new TeamMember { Id = 4, FullName = "Carl Weathers", Birthdate = new DateTime(1948, 1, 14), CollegeProgram = "Kinesiology", YearInProgram = "Junior" },
            new TeamMember { Id = 5, FullName = "George Washington", Birthdate = new DateTime(1732, 2, 22), CollegeProgram = "Political Science", YearInProgram = "Senior" }
        );

        modelBuilder.Entity<Hobby>().HasData(
            new Hobby { Id = 1, Name = "Videography", Category = "Arts", SkillLevel = 7, IsIndoor = false },
            new Hobby { Id = 2, Name = "Coding", Category = "Technology", SkillLevel = 9, IsIndoor = true },
            new Hobby { Id = 3, Name = "rock Climbing", Category = "Outdoors", SkillLevel = 8, IsIndoor = false },
            new Hobby { Id = 4, Name = "Basketball", Category = "Sports", SkillLevel = 8, IsIndoor = true },
            new Hobby { Id = 5, Name = "Running", Category = "Fitness", SkillLevel = 6, IsIndoor = true }
        );

        modelBuilder.Entity<FavoriteCity>().HasData(
            new FavoriteCity { Id = 1, Name = "Cincinnati", State = "Ohio", Population = 309000, HasMajorAirport = true },
            new FavoriteCity { Id = 2, Name = "Atlanta", State = "Georgia", Population = 498000, HasMajorAirport = true },
            new FavoriteCity { Id = 3, Name = "Columbus", State = "Ohio", Population = 921000, HasMajorAirport = true },
            new FavoriteCity { Id = 4, Name = "Dayton", State = "Ohio", Population = 137000, HasMajorAirport = false },
            new FavoriteCity { Id = 5, Name = "Charlotte", State = "North Carolina", Population = 897000, HasMajorAirport = true }

        );

        modelBuilder.Entity<BreakfastFood>().HasData(
            new BreakfastFood { Id = 1, Name = "Sausage", MainIngredient = "Pork", Calories = 350, IsVegetarian = false },
            new BreakfastFood { Id = 2, Name = "Waffle", MainIngredient = "Flour", Calories = 250, IsVegetarian = true },
            new BreakfastFood { Id = 3, Name = "Bacon", MainIngredient = "Pork", Calories = 450, IsVegetarian = false },
            new BreakfastFood { Id = 4, Name = "Cereal", MainIngredient = "Oats", Calories = 150, IsVegetarian = true },
            new BreakfastFood { Id = 5, Name = "Omelette", MainIngredient = "Eggs", Calories = 300, IsVegetarian = true }

        );
    }
}