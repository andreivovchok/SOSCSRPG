using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Поле Фермера",
                "Здесь растут ряды кукурузы, между которыми прячутся гигантские крысы",
                "FarmFields.png");

            newWorld.LocationAt(-2,-1).AddMonster(2,100);

            newWorld.AddLocation(-1, -1, "Дом Фермера",
                "Это дом твоего соседа, фермера Теда",
                "Farmhouse.png");

            newWorld.AddLocation(0, -1, "Дом",
                "Это твой дом",
                "Home.png");

            newWorld.AddLocation(0, 0, "Городская площадь",
                "Вы видите здесь фонтан.", 
                "TownSquare.png");

            newWorld.AddLocation(0, 1, "Хижина лекарей",
                "Вы видите маленькую хижину с сохнущими на крыше растениями.",
                "HerbalistsHut.png");

            newWorld.LocationAt(0,1).QuestAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Травяной сад",
                "В этом саду растет много лекарственных трав",
                "HerbalistsGarden.png");

            newWorld.LocationAt(0,2).AddMonster(1,100);

            newWorld.AddLocation(-1, 0, "Торговый магазин",
                "Лавка торговки Сьюзен.",
                "Trader.png");

            newWorld.AddLocation(1, 0, "Городские ворота",
                "Здесь есть ворота, защищающие город от гигантских пауков.",
                "TownGate.png");

            newWorld.AddLocation(2, 0, "Паучий лес",
                "Деревья в этом лесу покрыты паутиной",
                "SpiderForest.png");

            newWorld.LocationAt(2,0).AddMonster(3,100);

            return newWorld;
        }
    }
}
