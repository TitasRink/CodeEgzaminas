using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;

namespace FrameworkData.DataContext
{
    public class DataConection : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=NoteEXAM;Trusted_Connection=True;");
        }
    }
}
