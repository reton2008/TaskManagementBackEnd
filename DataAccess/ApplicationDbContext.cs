
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{

    public class ApplicationDbContext : IdentityDbContext //DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMPLOYEE> EMPLOYEE { get; set; }

        public DbSet<TEAMS> TEAMS { get; set; }

        public DbSet<TEAMS_DETAILS> TEAMS_DETAILS { get; set; }

        public DbSet<PROJECTS> PROJECTS { get; set; }

        public DbSet<PROJECT_DETAILS> PROJECT_DETAILS { get; set; }

        public DbSet<PROJECT_LOG> PROJECT_LOG { get; set; }

        public DbSet<TASKS> TASKS { get; set; }

        public DbSet<TASKS_LOG> TASKS_LOG { get; set; }

        public DbSet<TASK_EVALUATION> TASK_EVALUATION { get; set; }

    }
}
