using Microsoft.EntityFrameworkCore;
using Tweet10.Models;

namespace Tweet10.Data
{
    public class Tweet10DbContext : DbContext
    {
        public Tweet10DbContext(DbContextOptions<Tweet10DbContext> options) : base(options)
        {

        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}
