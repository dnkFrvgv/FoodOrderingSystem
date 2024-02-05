using FoodOrderingSystem.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core.Entities
{
    public abstract class FoodProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public FoodCategoryEnum FoodCategory {  get; set; }
        public bool IsIngredientsListAvailable { get; set; }


        public bool AreAllIngredientsAvailable(FoodInventory inventory)
        {
            if (inventory.EnouthIngredientToMakeFood(this, 1))
            {
                IsIngredientsListAvailable = true;
            }
            else
            {
                IsIngredientsListAvailable = false;
            }

            return IsIngredientsListAvailable;
        }


        public bool AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            return true;
        }


        public bool RemoveIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
