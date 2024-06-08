using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DataContext : DbContext
    {
        public string DataBasePath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DataBasePath = Path.Combine(path, "assignment_1.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DataBasePath}");

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
    }
}