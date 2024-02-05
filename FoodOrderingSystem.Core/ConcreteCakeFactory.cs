using FoodOrderingSystem.Core.Entities;
using FoodOrderingSystem.Core.Enum;
using FoodOrderingSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core
{
    public class ConcreteCakeFactory : ICakeFactory
    {
        private readonly ICakeToppingFactory _toppingFactory;

        public ConcreteCakeFactory(ICakeToppingFactory toppingFactory) 
        { 
            _toppingFactory = toppingFactory;
        }

        public Cake CreateCake(FoodProduct cake, FoodTopping topping)
        {
            Cake newCake;

            switch (cake.Name.ToLower())
            {
                case "lemon cake":
                    newCake = new LemonCake() { Ingredients = cake.Ingredients};
                    break;
                case "carrot cake":
                    newCake = new CarrotCake() { Ingredients = cake.Ingredients };
                    break;
                default:
                    throw new Exception();
            }


            Ingredient toppingIngretient = _toppingFactory.CreateTopping(topping);

            newCake.AddIngredient(toppingIngretient);


            return newCake;
        }
    }
}
