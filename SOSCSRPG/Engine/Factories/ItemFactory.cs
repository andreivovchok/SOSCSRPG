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
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            _standardGameItems.Add(new Weapon(1001, "Заостренная палка", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Ржавый меч", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Клык змеи", 1));
            _standardGameItems.Add(new GameItem(9002, "Змеиная кожа", 2));
            _standardGameItems.Add(new GameItem(9003, "Крысиный хвост", 1));
            _standardGameItems.Add(new GameItem(9004, "Крысиный мех", 2));
            _standardGameItems.Add(new GameItem(9005, "Клык паука", 1));
            _standardGameItems.Add(new GameItem(9006, "Шелк паука", 2));
        }

        public static GameItem GreateGameItem(int itemTypeID)
        {
            GameItem standartItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standartItem != null)
            {
                if (standartItem is Weapon)
                {
                    return (standartItem as Weapon).Clone();
                }

                return standartItem.Clone();
            }

            return null;
        }
    }
}
