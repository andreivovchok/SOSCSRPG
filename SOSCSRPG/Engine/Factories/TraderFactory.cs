using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader susan = new Trader("Сьюзен");
            susan.AddItemToInventory(ItemFactory.GreateGameItem(1001));

            Trader farmerTed = new Trader("Фермер Тед");
            farmerTed.AddItemToInventory(ItemFactory.GreateGameItem(1001));

            Trader peteTheHerbalist = new Trader("Травник Пит");
            peteTheHerbalist.AddItemToInventory(ItemFactory.GreateGameItem(1001));

            AddTraderToList(susan);
            AddTraderToList(farmerTed);
            AddTraderToList(peteTheHerbalist);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        public static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"Уже есть трейдер по имени {trader.Name}");
            }

            _traders.Add(trader);
        }
    }
}
