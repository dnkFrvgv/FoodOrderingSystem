using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }

        public Menu(IEnumerable<MenuItem> menuItems)
        {
            MenuItems = menuItems;
        }

        public IEnumerable<MenuItem> GetAvailableItems(IEnumerable<MenuItem> menuItems)
        {
            var AvailableItems = menuItems.Where(x => x.Product.IsIngredientsListAvailable).ToList();

            return AvailableItems;
        }

        public IEnumerable<MenuItem> FilderMenu(Func<MenuItem, bool> expression)
        {
            return MenuItems.Where(expression).ToList();
        }
    }
}
