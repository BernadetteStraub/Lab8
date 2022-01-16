using Microsoft.EntityFrameworkCore;
using Straub_Bernadette_Lab8.Models;

namespace Straub_Bernadette_Lab8.Data
{
    public class Straub_Bernadette_Lab8Context : DbContext
    {
        public Straub_Bernadette_Lab8Context (DbContextOptions<Straub_Bernadette_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Straub_Bernadette_Lab8.Models.Category> Category { get; set; }
    }
}
