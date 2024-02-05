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
        private readonly ICakeTopingFactory _toppingFactory;

        public ConcreteCakeFactory(ICakeTopingFactory toppingFactory) 
        { 
            _toppingFactory = toppingFactory;
        }

        public Cake CreateCake(FoodProduct cake, FoodTopping topping)
        {
            Cake newCake;

            switch (cake.Name.ToLower())
            {
                case "lemon cake":
                    newCake = new LemonCake();
                    break;
                default:
                    throw new Exception();
            }


            Ingredient toppingIngretient = _toppingFactory.AddCakeToping(topping);

            newCake.AddIngredient(toppingIngretient);


            return newCake;
        }
    }
}
