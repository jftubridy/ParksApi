using Microsoft.EntityFrameworkCore;

namespace USPark.Models
{
    public class USParkContext : DbContext
    {

        public DbSet<Park> Parks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=us_parks;");

        public USParkContext(DbContextOptions options) : base(options)
        {

        }
        public USParkContext()
        {

        }

    }
}