using Microsoft.EntityFrameworkCore;

namespace EmployeeRegistration
{
    public class EmployeeRegistrationDbContext : DbContext
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=EmployeeDb";

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Employee mappings
            modelBuilder.Entity<Employee>().ToTable("Victory's Employees");
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            modelBuilder.Entity<Employee>().Property(e => e.FirstName).HasColumnName("The " +
                "first name");

            modelBuilder.Entity<Employee>().HasMany<Child>();
            modelBuilder.Entity<Employee>().Property(e => e.Gender).HasConversion(v => v.ToString(),v=> (Gender)Enum.Parse(typeof(Gender),v.ToString()));
            // Child mappings
            modelBuilder.Entity<Child>().HasOne(e => e.Parent);

            //Seeding
            modelBuilder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee { Id=Guid.NewGuid(), Age = 30, FirstName = "Bart", Gender = Gender.Male, LastName = "Allen"}
            });

            base.OnModelCreating(modelBuilder);
           
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
