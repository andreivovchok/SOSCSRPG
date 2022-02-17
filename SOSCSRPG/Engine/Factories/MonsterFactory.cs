using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake = 
                    new Monster("Змея", "Snake.png",
                        4,4, 1,
                        2, 5,1);

                    AddLootItem(snake, 9001,25);
                    AddLootItem(snake, 9001,75);

                    return snake;

                case 2:
                    Monster rat =
                    new Monster("Крыса", "Rat.png",
                        5,5,1,
                        2, 5,1);

                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9003, 75);

                    return rat;

                case 3:
                    Monster giantSpider = 
                    new Monster("Гигинсткий паук", "GiantSpider.png",
                        10,10,1,
                        4, 10,3);

                    AddLootItem(giantSpider,9005,25);
                    AddLootItem(giantSpider,9005,75);

                    return giantSpider;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int persentage)
        {
            if (RandomNumberGenerator.SimpleNumberBetween(1,100) <= persentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
