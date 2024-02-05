using FoodOrderingSystem.Core.Entities;
using FoodOrderingSystem.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core.Entities
{
    public abstract class Cake : FoodProduct
    {
        public FoodCategoryEnum FoodType { get; set; } = FoodCategoryEnum.DESSERT;
    }
}
