using FoodOrderingSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core.Interfaces
{
    public interface ICakeFactory
    {
        public Cake CreateCake(FoodProduct cake, Enum.FoodTopping topping);
    }
}
