using System.Collections.Generic;
using Assignment_2.Model;
using Assignment_2.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
        {
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            }

            public DbSet<Student> Students { get; set; }
   public DbSet<Class> Classs { get; set; }
    public DbSet<Faculty> Facultys { get; set; }
    public DbSet<Enrolled> Enrolleds { get; set; }
}
    


