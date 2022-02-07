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

            newWorld.AddLocation(-1, 1, "Дом Фермера",
                "Это дом твоего соседа, фермера Теда",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Дом",
                "Это твой дом",
                "/Engine;component/Images/Locations/Home.png");

            return newWorld;
        }
    }
}
