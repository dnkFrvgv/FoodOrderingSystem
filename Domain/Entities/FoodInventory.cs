using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core.Entities
{
    public class FoodInventory
    {
        public int Id { get; set; }
        public Dictionary<Ingredient, int> IngredientQuantity { get; set; }

        public bool EnouthIngredientToMakeFood(FoodProduct product, int productQty)
        {
            var isEnouth = true;
/*
            foreach(Ingredient productIngredient in product.Ingredients) 
            { 
                var inventoryIngredient = IngredientQuantity.FirstOrDefault(x=>x.Key.Id ==  productIngredient.Id);

                if (inventoryIngredient.Value == 0) break;
                
                if (inventoryIngredient.Value - productIngredient.)

            
            }*/

            return isEnouth;
        }
    }
}
