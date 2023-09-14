using Microsoft.EntityFrameworkCore;
using ModuleFeedback.Models.Domain;

namespace ModuleFeedback.Data
{
    public class MVCDemoDbContext : DbContext
    {

        public MVCDemoDbContext(DbContextOptions options) : base(options)
            { }

        // employees will be the name of the table that will be created
        public DbSet<Employee> Employees { get; set; }
    }
}
