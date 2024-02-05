using FoodOrderingSystem.Core.Entities;
using FoodOrderingSystem.Core.Enum;

namespace FoodOrderingSystem.Core.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ingredient> ingredients { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int NumberOfPurchaces { get; set; }

        public bool IsItemAvailableForPurchase()
        {
            return IsAvailable && Price > 0m;
        }
    }
}