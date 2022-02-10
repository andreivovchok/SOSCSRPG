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
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Дом Фермера",
                "Это дом твоего соседа, фермера Теда",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Дом",
                "Это твой дом",
                "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, 0, "Городская площадь",
                "Вы видите здесь фонтан.", 
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(0, 1, "Хижина лекарей",
                "Вы видите маленькую хижину с сохнущими на крыше растениями.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Травяной сад",
                "В этом саду растет много лекарственных трав",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            newWorld.AddLocation(-1, 0, "Торговый магазин",
                "Лавка торговки Сьюзен.",
                "/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(1, 0, "Городские ворота",
                "Здесь есть ворота, защищающие город от гигантских пауков.",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Паучий лес",
                "Деревья в этом лесу покрыты паутиной",
                "/Engine;component/Images/Locations/SpiderForest.png");

            return newWorld;
        }
    }
}
