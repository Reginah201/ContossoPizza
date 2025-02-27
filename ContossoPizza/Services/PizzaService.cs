using ContossoPizza.Models;

namespace ContossoPizza.Services
{
    public class PizzaService
    {
        private static List<Pizza> pizzas = new()
        {
            new Pizza { Id = 1, Name = "Classic Margherita", IsVegetarian = true, Price = 44.99 },
            new Pizza { Id = 2, Name = "Original Veggie", IsVegetarian = true, Price = 61.99 },
             new Pizza { Id = 3, Name = "3 Cheese", IsVegetarian = true , Price = 86.99 },
              new Pizza { Id = 4, Name = "Creamy Chicken", IsVegetarian = false, Price = 40.99 },
               new Pizza { Id = 5, Name = "Tikka chicken", IsVegetarian = false, Price = 49.99 },
            new Pizza { Id = 6, Name = "Chicken and mushroom", IsVegetarian = false, Price = 111.99 },
             new Pizza { Id = 7, Name = "BBQ Chicken", IsVegetarian = false , Price = 89.99 },
              new Pizza { Id = 8, Name = "Beef steak and mushroom", IsVegetarian = false, Price = 31.99 }

        };

        public List<Pizza> GetAll() => pizzas;
        public Pizza? Get(int id) => pizzas.FirstOrDefault(p => p.Id == id);
        public void Add(Pizza pizza) => pizzas.Add(pizza);
        public void Delete(int id) => pizzas.RemoveAll(p => p.Id == id);
    }
}
