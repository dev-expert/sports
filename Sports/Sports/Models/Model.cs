using Microsoft.EntityFrameworkCore;

namespace Sports.Models
{
    public class Model
    {
        public class SportsContext : DbContext
        {
            public SportsContext(DbContextOptions<SportsContext> options)
            : base(options)
            { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<TestTypes>().HasData(
                       new TestTypes() { TestTypeId = 1, TestName = "Cooper test" },
                       new TestTypes() { TestTypeId = 2, TestName = "sprint test" });
                modelBuilder.Entity<Roles>().HasData(
                       new Roles() { RoleId = 1, Role = "Athlete" },
                       new Roles() { RoleId = 2, Role = "Coach" });
                modelBuilder.Entity<Athletes>().HasData(
                    new Athletes() { AthleteId = 1, AthleteName = "Mitchel Fausto", RoleId = 2 , Password= "Admin123#"},
                    new Athletes() { AthleteId = 2, AthleteName = "Queen Jacobi", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 3, AthleteName = "Magen Faye", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 4, AthleteName = "Delicia Ledonne", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 5, AthleteName = "Camille Grantham", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 6, AthleteName = "Marc Voth", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 7, AthleteName = "Randy Rondon", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 8, AthleteName = "Delora Saville ", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 9, AthleteName = "Rosario Reuben", RoleId = 1, Password = "Admin123#" },
                    new Athletes() { AthleteId = 10, AthleteName = "Lula Uhlman ", RoleId = 1, Password = "Admin123#" });
            }
            public DbSet<Roles> Roles { get; set; }
            public DbSet<Athletes> Athletes { get; set; }
            public DbSet<Tests> Tests { get; set; }
            public DbSet<TestTypes> TestTypes { get; set; }
            public DbSet<TestSubscription> TestSubscriptions { get; set; }
        }
    }
}
