using FoodOrderingSystem.Core.Entities;

namespace FoodOrderingSystem.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CakeAddTopping()
        {
            var chocolateTopping = new Ingredient() { Id = 1 , Name = "Chocolate Topping"};
            Cake cake = new CarrotCake(){};

            cake.AddTopping(chocolateTopping);

            Assert.Equal("Carrot Cake with Chocolate Topping", cake.ToString());
        }
    }
}