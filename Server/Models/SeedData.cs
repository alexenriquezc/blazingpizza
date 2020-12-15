using BlazingPizza.Shared;

namespace BlazingPizza.Server.Models
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreConext context)
        {
            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial
                {
                    Name= "Pizza clásica de queso",
                    Description = "Es de queso y delicioso. ¿Por qué no querrías una?",
                    BasePrice = 189.9m,
                    ImageUrl="images/pizzas/cheese.jpg"
                },
                new PizzaSpecial
                {
                    Name= "Tocinator",
                    Description = "Tiene todo tipo de tocino",
                    BasePrice = 227.99m,
                    ImageUrl="images/pizzas/bacon.jpg"
                },
                new PizzaSpecial
                {
                    Name= "Clásica de perperoni",
                    Description = "Peperoniana",
                    BasePrice = 189.9m,
                    ImageUrl="images/pizzas/cheese.jpg"
                }
            };

            context.Specials.AddRange(specials);
            context.SaveChanges();
        }
    }
}
