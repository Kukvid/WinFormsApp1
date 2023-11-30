using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace WinFormsLibrary
{
    public class StarSystem: SpaceObject
    {
        public List<Star> ChildrenStars = new List<Star>();

        public string StructureInfo { get
            {
                return getStructureInfo();
            } }

        public string getStructureInfo()
        {
            string info_msg = "";

            foreach (Star star in ChildrenStars)
            {
                if (star.Name == "Не указано")
                {
                    info_msg += "В данной звездной системе нет привязанных звезд\n";
                    return info_msg;
                }

                info_msg += $"Звезда {star.Name}\n";

                foreach (Planet planet in star.ChildrenPlanets)
                {
                    info_msg += $"--Планета {planet.Name}\n";

                    foreach(Moon moon in planet.ChildrenMoons)
                    {
                        info_msg += $"----Луна {moon.Name}\n";
                    }
                }
            }

            return info_msg;
        }
        private string Join(string separator, List<Star> objects)
        {
            string result_string = objects[0].Name;
            for (int i = 1; i < objects.Count; i++)
            {
                result_string += separator + objects[i].Name;
            }
            return result_string;
        }
        private string getStarSystemText()
        {

            string res_string = "Звездная система" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.Join(",", ChildrenStars) + "\n";

            return res_string;
        }
        public string getChildrenInfo()
        {
            string ChildrenAndParentInfo = "";
            ChildrenAndParentInfo += $"Звезды, которой состоят в звездной системе: {this.Join(",", ChildrenStars)}\n";
            return ChildrenAndParentInfo;
        }
        public string getStringWithAdditionalInfo()
        {   
            string message = getChildrenInfo();
            return message;
        }
        public override void writeToFile()
        {

            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getStarSystemText());
            streamWriter.Close();
        }
        public void LinkWithChildren(List<Star> stars)
        {
            foreach (Star star in stars)
            {
                for (int i = 0; i < ChildrenStars.Count; i++)
                {
                    if (star.Name == ChildrenStars[i].Name)
                    {
                        ChildrenStars[i] = star;
                    }
                }
            }
        }
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
                            temp.setAge(long.Parse(system_line[2]));
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[4]);
                            temp.setPhoto(system_line[5], true);
                            if (system_line.Length == 6)
                            {
                                temp.ChildrenStars = new List<Star>() { new Star("Не указано") };
                            }
                            else
                            {
                                foreach (string PlanetName in system_line[6].Split(","))
                                {
                                    temp.ChildrenStars.Add(new Star(PlanetName));
                                }
                            }
                            starSystems.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return starSystems;
        }

        List<SpaceObject> SpaceObjects = new List<SpaceObject>();

        List<List<SpaceObject>> SpaceObjectsNArray = new List<List<SpaceObject>>() { new List<SpaceObject>(), new List<SpaceObject>(), new List<SpaceObject>() };
        public StarSystem(List<Star> stars, List<Planet> planets, List<Moon> moons)
        {
            /*
            Stars = stars;
            Moons = moons;
            Planets = planets;
            */
            //
            //if (stars.Count == 0)
            //{
              //  ChildrenStars.Add(new Star("Не указано"));
            //}
            foreach (Star star in stars)
            {
                SpaceObjects.Add((SpaceObject)star);
                ChildrenStars.Add(star);
                SpaceObjectsNArray[0].Add(star);
            }
            foreach (Planet planet in planets)
            {
                SpaceObjects.Add((SpaceObject)planet);
                SpaceObjectsNArray[1].Add(planet);
            }
            foreach (Moon moon in moons)
            {
                SpaceObjects.Add((SpaceObject)moon);
                SpaceObjectsNArray[2].Add(moon);
            }
        }
        public override string ToString()
        {
            return "Звездная система";
        }
        public StarSystem()
        {

        }
        public StarSystem(string name): base(name)
        {
        }
        public StarSystem(string name, long age, DateTime DateOfDiscovery, Color color, string photoPath): base(name, age, color, DateOfDiscovery, photoPath)
        {
            ChildrenStars.Add(new Star("Не указано"));
        }

        
        public SpaceObject this[int index]
        {
            get => SpaceObjects[index];
            set => SpaceObjects[index] = value;

        }
        /*
        public SpaceObject this[int objectTypeIndex, int objectIndex]
        {
            get => SpaceObjectsNArray[objectTypeIndex][objectIndex];
            set => SpaceObjectsNArray[objectTypeIndex][objectIndex] = value;
        }
        public List<SpaceObject> this[int objectTypeIndex]
        {
            get => SpaceObjectsNArray[objectTypeIndex];
            set => SpaceObjectsNArray[objectTypeIndex] = value;
        }*/
        
    }
}