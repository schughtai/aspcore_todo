using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using aspcore.Models;

namespace aspcore.Presistence
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options):base(options)
        {
            
        }
        public DbSet<TaskDetails> TaskDetails { get; set; }
    }
}