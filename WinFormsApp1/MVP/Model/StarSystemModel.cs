using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsLibrary;

namespace WinFormsApp1.MVP.Model
{
    public class StarSystemModel
    {
        // Списки свободных (непривязанных к звездной системе) лун, планет и звезд
        public List<Moon> freeMoons = new List<Moon>() { };
        public List<Planet> freePlanets = new List<Planet>() { };
        public List<Star> freeStars = new List<Star>() { };

        // Метод для обновления списков свободных объектов
        public void updateFreeObjectsLists(List<Moon> moons, List<Planet> planets, List<Star> stars)
        {
            foreach (Moon moon in moons)
            {
                if (moon.ParentStarSystem.Name == "Не указано")
                {
                    freeMoons.Add(moon);
                }
            }
            foreach (Planet planet in planets)
            {
                if (planet.ParentStarSystem.Name == "Не указано")
                {
                    freePlanets.Add(planet);
                }
            }
            foreach (Star star in stars)
            {
                if (star.ParentStarSystem.Name == "Не указано")
                {
                    freeStars.Add(star);
                }
            }
        }
    }
}
