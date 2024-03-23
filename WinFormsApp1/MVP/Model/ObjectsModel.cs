using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsLibrary.classes;
using WinFormsLibrary;
using WinFormsApp1.FormListOfObjects_MVP.Presenter;
using System.Reflection;

namespace WinFormsApp1.FormListOfObjects.Model
{
    public class ObjectsModel
    {
        // Списки для хранения лун, планет, звезд и звездных систем
        public List<Moon> moons = new List<Moon>(MoonDB.readFromFile()) { };
        public List<Planet> planets = new List<Planet>(PlanetDB.readFromFile()) { };
        public List<Star> stars = new List<Star>(StarDB.readFromFile()) { };
        public List<StarSystem> starSystems = new List<StarSystem>(StarSystemDB.readFromFile()) { };

        // Список связанных объектов для отображения в списке формы
        public List<SpaceObject> objects = new List<SpaceObject>(); // UpCasting

        // Словарь с числовыми значениями типов объектов для сортировки по типу
        Dictionary<string, int> costOfObjectsTypes = new Dictionary<string, int>
            {
                {"Звездная система", 4},
                {"Звезда" , 3},
                {"Планета" , 2},
                {"Луна" , 1},
            };

        public ObjectsModel() {
            // Обновление списков объектов
            updateObjectsList(moons, planets, stars, starSystems, objects);
            updateObjectsRelationships(moons, planets, stars, starSystems);
        }

        // Метод обновления списков объектов
        private void updateObjectsList(List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems, List<SpaceObject> objects)
        {
            // Добавление звездных систем в список объектов
            foreach (StarSystem starSystem in starSystems)
            {
                objects.Add((SpaceObject)starSystem);
            }
            // Добавление звезд в список объектов
            foreach (Star star in stars)
            {
                objects.Add((SpaceObject)star);
            }
            // Добавление планет в список объектов
            foreach (Planet planet in planets)
            {
                objects.Add((SpaceObject)planet);
            }
            // Добавление лун в список объектов
            foreach (Moon moon in moons)
            {
                objects.Add((SpaceObject)moon);
            }

        }

        private void updateObjectsRelationships(List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems)
        {
            // Связывание лун с их родительскими звездными системами
            foreach (Moon moon in moons)
            {
                moon.linkWithParent(starSystems);
            }
            // Связывание планет с их родительскими звездными системами
            foreach (Planet planet in planets)
            {
                planet.LinkWithParent(starSystems);
            }
            // Связывание звезд с их родительскими звездными системами

            foreach (Star star in stars)
            {
                star.LinkWithParent(starSystems);
            }
            // Связывание звездных систем с их дочерними объектами (лунами, планетами, звездами)
            foreach (StarSystem starSystem in starSystems)
            {
                starSystem.linkWithChildren(moons, planets, stars);
            }
        }

        public void ReadFromFile()
        {
            moons = new List<Moon>(MoonDB.readFromFile()) { };
            planets = new List<Planet>(PlanetDB.readFromFile()) { };
            stars = new List<Star>(StarDB.readFromFile()) { };
            starSystems = new List<StarSystem>(StarSystemDB.readFromFile()) { };
        }

        public void WriteToFile() {
            // Очистка файлов с данными перед сохранением
            File.WriteAllText(SpaceObject.spaceObjectsPath, string.Empty);

            //Записываем все объекты в файл
            MoonDB.writeToFile(moons);
            PlanetDB.writeToFile(planets);
            StarDB.writeToFile(stars);
            StarSystemDB.writeToFile(starSystems);
        }
        // Метод удаления объекта из списков
        public void deleteSpaceObjectFromLists(string objectName, int objectIndex)
        {
            // Поиск и удаление луны из списка лун
            for (int i = 0; i < moons.Count; i++)
            {
                if (moons[i].NameWithType == objectName)
                {
                    // Если луна привязана к звездной системе, обновление списка дочерних лун в родительской звездной системе
                    if (moons[i].ParentStarSystem.Name != "Не указано")
                    {
                        Moon moonNow = moons[i];
                        StarSystem parentStarSystem = moonNow.ParentStarSystem;
                        parentStarSystem.ChildrenMoons.Remove(moonNow);
                        if (parentStarSystem.ChildrenMoons.Count == 0)
                        {
                            parentStarSystem.ChildrenMoons.Add(new Moon("Не указано"));
                        }
                    }
                    // Удаление луны из списка лун
                    moons.RemoveAt(i);

                }
            }
            // Аналогичные операции для планет, звезд и звездных систем
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].NameWithType == objectName)
                {
                    if (planets[i].ParentStarSystem.Name != "Не указано")
                    {
                        Planet planetNow = planets[i];
                        StarSystem parentStarSystem = planetNow.ParentStarSystem;
                        parentStarSystem.ChildrenPlanets.Remove(planetNow);
                        if (parentStarSystem.ChildrenPlanets.Count == 0)
                        {
                            parentStarSystem.ChildrenPlanets.Add(new Planet("Не указано"));
                        }
                    }
                    planets.RemoveAt(i);
                }
            }
            for (int i = 0; i < stars.Count; i++)
            {

                if (stars[i].NameWithType == objectName)
                {
                    if (stars[i].ParentStarSystem.Name != "Не указано")
                    {
                        Star starNow = stars[i];
                        StarSystem parentStarSystem = starNow.ParentStarSystem;
                        parentStarSystem.ChildrenStars.Remove(starNow);
                        if (parentStarSystem.ChildrenStars.Count == 0)
                        {
                            parentStarSystem.ChildrenStars.Add(new Star("Не указано"));
                        }
                    }
                    stars.RemoveAt(i);
                }
            }
            for (int i = 0; i < starSystems.Count; i++)
            {

                if (starSystems[i].NameWithType == objectName)
                {
                    foreach (Moon moon in moons)
                    {
                        moon.ParentStarSystem = new StarSystem("Не указано");
                    }
                    foreach (Planet planet in planets)
                    {
                        planet.ParentStarSystem = new StarSystem("Не указано");
                    }
                    foreach (Star star in stars)
                    {
                        star.ParentStarSystem = new StarSystem("Не указано");
                    }
                    starSystems.RemoveAt(i);
                }
            }
            // Обновление отображаемого списка объектов
            objects.RemoveAt(objectIndex);
        }

        public void sortObjectsList(string mode)
        {
            switch (mode)
            {
                case "Звездная система -> Луна":
                    objects = objects.OrderByDescending(x => costOfObjectsTypes[x.ToString()])
                        .ThenBy(x=> x.Name).ToList();
                    break;
                case "Луна -> Звездная система":
                    objects = objects.OrderBy(x => costOfObjectsTypes[x.ToString()])
                        .ThenBy(x => x.Name).ToList().ToList();
                    break;
                case "А -> Я":
                    objects.Sort((x, y) => string.Compare(x.Name, y.Name));
                    break;
                case "Я -> А":
                    objects.Sort((x, y) => string.Compare(x.Name, y.Name));
                    objects.Reverse();
                    break;
            }
        }
    }

} 

