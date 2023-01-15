using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class CategoryDBContext : DbContext
    {
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dell\\OneDrive\\Documents\\expense_track.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
