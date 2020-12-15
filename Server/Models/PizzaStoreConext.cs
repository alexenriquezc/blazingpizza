using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Models
{
    public class PizzaStoreConext: DbContext
    {
        public PizzaStoreConext(DbContextOptions<PizzaStoreConext> options): base(options)
        {
        }

        public DbSet<PizzaSpecial> Specials { get; set; }
    }
}
