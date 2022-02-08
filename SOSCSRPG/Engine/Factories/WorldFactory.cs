using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
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
                "", 
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(0, 1, "Хижина лекарей", 
                "",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Травяной сад",
                "В этом саду растет много лекарственных трав",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            newWorld.AddLocation(-1, 0, "Торговый магазин", 
                "В этом магазине можно покупать и продавать предметы",
                "/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(1, 0, "Городские ворота",
                "",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Паучий лес",
                "",
                "/Engine;component/Images/Locations/SpiderForest.png");

            return newWorld;
        }
    }
}
