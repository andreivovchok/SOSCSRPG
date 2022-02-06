using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }


        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 10000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Дом";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "Это твой дом";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";
        }
    }
}
