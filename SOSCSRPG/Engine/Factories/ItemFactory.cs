using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardItems;

        static ItemFactory()
        {
            _standardItems = new List<GameItem>();

            _standardItems.Add(new Weapon(1001, "Заостренная палка", 1, 1, 2));
            _standardItems.Add(new Weapon(1002, "Ржавый меч", 5, 1, 3));
        }

        public static GameItem GreategameItem(int itemTypeID)
        {
            GameItem standartItem = _standardItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standartItem != null)
            {
                return standartItem.Clone();
            }

            return null;
        }
    }
}
