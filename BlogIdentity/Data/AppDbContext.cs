using BlogIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BlogIdentity
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
