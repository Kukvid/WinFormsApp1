using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using WinFormsLibrary.classes;
using WinFormsLibrary.utils;

namespace WinFormsLibrary
{
    public class StarSystem: SpaceObject, IStarSystem
    {
        // Поля класса
        // Конструкторы класса
        public StarSystem() : base(){}
        public StarSystem(string name) : base(name) { }

        public StarSystem(string name, long age, DateTime DateOfDiscovery, string photoPath, List<Moon> moons, List<Planet> planets,
            List<Star> stars) : base(name, age, DateOfDiscovery, photoPath)
        {
            SpaceObjectColor = Color.White;
            updateChildrenLists(moons, planets, stars);
            LoggingInFileEventStarSystem?.Invoke($"{DateTime.Now} . Создан объект типа {ToString()} и именем {this.Name} со следующими данными:\n" +
                $"Имя звездной системы: {name},\n" +
                $"Возраст системы: {age} лет,\n" +
                $"Дата открытия системы: {DateOfDiscovery}\n" +
                $"Звезды в составе системы: {Utils.Join(",", ChildrenStars)};\n" +
                $"Планеты в составе системы: {Utils.Join(",", ChildrenPlanets)};\n" +
                $"Луны в составе системы: {Utils.Join(",", ChildrenMoons)}");
        }


        // Свойства класса
        // Списки для хранения звезд, планет и лун
        public List<Star> ChildrenStars { get; set; } = new List<Star>();
        public List<Planet> ChildrenPlanets { get; set; } = new List<Planet>();
        public List<Moon> ChildrenMoons { get; set; } = new List<Moon>();


        // Методы класса

        // Переопределенный метод для дополнительной информации об объекте класса Звездная система
        public override string getStringWithAdditionalInfo()
        {
            string ChildrenInfo = this.Name + "\n";
            ChildrenInfo += $"Звезды, которые состоят в звездной системе: {Utils.Join(",", ChildrenStars)}\n";
            ChildrenInfo += $"Планеты, которые состоят в звездной системе: {Utils.Join(",", ChildrenPlanets)}\n";
            ChildrenInfo += $"Луны, которые состоят в звездной системе: {Utils.Join(",", ChildrenMoons)}\n";
            return ChildrenInfo;
        }
        
        // Метод для обновления списков дочерних объектов при создании объекта или при изменении
        public void updateChildrenLists(List<Moon> moons, List<Planet> planets, List<Star> stars)
        {
            ChildrenMoons = new List<Moon>();
            ChildrenPlanets = new List<Planet>();
            ChildrenStars = new List<Star>();
            if (moons.Count == 0)
            {
                ChildrenMoons.Add(new Moon("Не указано"));
            }
            if (planets.Count == 0)
            {
                ChildrenPlanets.Add(new Planet("Не указано"));
            }
            if (stars.Count == 0)
            {
                ChildrenStars.Add(new Star("Не указано"));
            }

            foreach (Star star in stars)
            {
                ChildrenStars.Add(star);
                star.ParentStarSystem = this;
            }
            foreach (Planet planet in planets)
            {
                ChildrenPlanets.Add(planet);
                planet.ParentStarSystem = this;
            }
            foreach (Moon moon in moons)
            {
                ChildrenMoons.Add(moon);
                moon.ParentStarSystem = this;
            }
            LoggingInFileEventStarSystem?.Invoke($"{DateTime.Now}. К объекту типа {ToString()} и именем {this.Name} привязаны следующие космические объекты:\n" +
               $"Звезды в составе системы: {Utils.Join(",", ChildrenStars)};\n" +
               $"Планеты в составе системы: {Utils.Join(",", ChildrenPlanets)};\n" +
               $"Луны в составе системы: {Utils.Join(",", ChildrenMoons)}");
        }

        // Переопределенный метод для получения типа объекта
        public override string ToString()
        {
            return "Звездная система";
        }

        // Метод для связывания объекта с его дочерними объектами при первом запуске программы
        public void linkWithChildren(List<Moon> moons, List<Planet> planets, List<Star> stars)
        {
            for (int i = 0; i < ChildrenStars.Count; i++)
            {
                foreach (Star star in stars)
                {
                    if (star.Name == ChildrenStars[i].Name)
                    {
                        ChildrenStars[i] = star;
                        break;
                    }
                }
            }
            for (int i = 0; i < ChildrenPlanets.Count; i++)
            {
                foreach (Planet planet in planets)
                {
                    if (planet.Name == ChildrenPlanets[i].Name)
                    {
                        ChildrenPlanets[i] = planet;
                        break;
                    }
                }
            }
            for (int i = 0; i < ChildrenMoons.Count; i++)
            {
                foreach (Moon moon in moons)
                {
                    if (moon.Name == ChildrenMoons[i].Name)
                    {
                        ChildrenMoons[i] = moon;
                        break;
                    }
                }
            }
        }

        // Событие для логирования
        public event LogHandler LoggingInFileEventStarSystem = Utils.writeLog;
    }

    public class StarSystemDB: IReadWriteObjectsFromToFiles
    {

        // Приватный метод для формирования строки с данными о звездной системы
        private static string getStarSystemText(StarSystem starSystem)
        {
            string res_string = starSystem.ToString() + "!!!" +
                starSystem.Name + "!!!" +
                starSystem.Age.ToString() + "!!!" +
                starSystem.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                starSystem.SpaceObjectColor.ToString() + "!!!" +
                starSystem.Photo + "!!!" +
                Utils.Join(",", starSystem.ChildrenMoons) + "!!!" +
                Utils.Join(",", starSystem.ChildrenPlanets) + "!!!" +
                Utils.Join(",", starSystem.ChildrenStars);

            return res_string;
        }

        // Метод для записи данных в файл.
        public static void writeToFile(List<StarSystem> starSystems)
        {
            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            foreach (StarSystem starSystem in starSystems)
            {
                streamWriter.WriteLine(getStarSystemText(starSystem));
            }
            streamWriter.Close();
        }

        // Метод для чтения данных из файла.
        static public List<StarSystem> readFromFile()
        {
            List<StarSystem> starSystems = new List<StarSystem>();
            FileInfo fileInfo = new FileInfo(SpaceObject.spaceObjectsPath);
            if (fileInfo.Length != 0)
            {

                StreamReader sr = new StreamReader(SpaceObject.spaceObjectsPath, Encoding.UTF8, true);
                string s = sr.ReadToEnd();
                string[] lines = s.Split(Environment.NewLine);

                foreach (string line in lines)
                {
                    if (line != string.Empty)
                    {
                        string[] system_line = line.Split("!!!");
                        if (system_line[0] == "Звездная система")
                        {
                            StarSystem temp = new StarSystem();
                            temp.Name = system_line[1];
                            temp.Age = long.Parse(system_line[2]);
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.SpaceObjectColor = Utils.ParseColor(system_line[4], temp.Name);
                            temp.setPhoto(system_line[5], true);
                            foreach (string moonName in system_line[6].Split(","))
                            {
                                temp.ChildrenMoons.Add(new Moon(moonName));
                            }
                            foreach (string planetName in system_line[7].Split(","))
                            {
                                temp.ChildrenPlanets.Add(new Planet(planetName));
                            }
                            foreach (string starName in system_line[8].Split(","))
                            {
                                temp.ChildrenStars.Add(new Star(starName));
                            }

                            starSystems.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return starSystems;
        }
    }

}