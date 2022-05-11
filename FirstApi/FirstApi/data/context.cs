using FirstApi.model;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.data
{
    public class context:DbContext
    {
        public context(DbContextOptions<context> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
