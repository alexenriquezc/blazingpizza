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
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FLUENT API

            modelBuilder.Entity<PizzaTopping>()
                .HasKey(pzt => new { pzt.PizzaId, pzt.ToppingId });

            modelBuilder.Entity<PizzaTopping>()
                .HasOne<Pizza>().WithMany(ps => ps.Toppings);

            modelBuilder.Entity<PizzaTopping>()
                .HasOne(pzt => pzt.Topping).WithMany();
        }
    }
}
