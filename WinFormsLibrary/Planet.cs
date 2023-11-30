using System.Text;

namespace WinFormsLibrary
{
    public sealed class Planet : SpaceObject {
        public double Weight { get; set; } = 1;
        public double AccelerationOfFreeFall { get; set; } = 9.8;

        //Ассоциация
        public Star ParentStar;
        public List<Moon> ChildrenMoons = new List<Moon> ();
        
        private string Join(string separator, List<Moon> objects)
        {
            string result_string = objects[0].Name;
            for (int i = 1; i < objects.Count; i++ ) { 
                result_string += separator + objects[i].Name;
            }
            return result_string;
        }
        private string getPlanetText()
        {
            string res_string = "Планета" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.AccelerationOfFreeFall.ToString()
                 + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo + "!!!" +
                 this.ParentStar.Name + "!!!" + this.Join(",", ChildrenMoons);

            return res_string;
        }
        public void LinkWithParentAndChildren(List<Star> stars, List<Moon> moons)
        {
            foreach (Star star in stars)
            {
                if (star.Name == ParentStar.Name)
                {
                    ParentStar = star;
                }
            }
            foreach(Moon moon in moons)
            {
                for(int i = 0; i < ChildrenMoons.Count; i++)
                {
                    if (moon.Name == ChildrenMoons[i].Name)
                    {
                        ChildrenMoons[i] = moon;
                    }
                }
            }
        }
        public override void writeToFile()
        {
            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getPlanetText());
            streamWriter.Close();
        }
        

        static public List<Planet> readFromFile()
        {
            List<Planet> planets = new List<Planet>();
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
                        if (system_line[0] == "Планета")
                        {
                            Planet temp = new Planet();
                            temp.Name = system_line[1];
                            temp.setAge(long.Parse(system_line[2]));
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.Weight = double.Parse(system_line[4]);
                            temp.AccelerationOfFreeFall = double.Parse(system_line[5]);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[6]);
                            temp.setPhoto(system_line[7], true);
                            if(system_line.Length == 8)
                            {
                                temp.ParentStar = new Star("Не указано");
                                temp.ChildrenMoons = new List<Moon>() {new Moon("Не указано")};
                            }
                            else
                            {
                                temp.ParentStar = new Star(system_line[8]);
                                foreach (string MoonName in system_line[9].Split(","))
                                {
                                    temp.ChildrenMoons.Add(new Moon(MoonName));
                                }
                            }
                            planets.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return planets;
        }
        public string getChildrenAndParentInfo()
        {
            string ChildrenAndParentInfo = "";
            ChildrenAndParentInfo += $"Звезда, вокруг которой вращается - {ParentStar.Name}\n";
            ChildrenAndParentInfo += $"Луны, которые вращаются вокруг: {this.Join(",", ChildrenMoons)}\n";
            return ChildrenAndParentInfo;
        }
        public string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nВес планеты: " + this.Weight.ToString() + " *10^24 кг\n";
            message += "Ускорение свободного падения: " + this.AccelerationOfFreeFall.ToString() + "м/c^2\n";
            message += getChildrenAndParentInfo();
            return message;
        }
        public override string ToString()
        {
            return "Планета";
        }
        public Planet(): base() {
        }
        public Planet(string name): base(name) {
        }

        public Planet(string name, long Age): base(name, Age) {
        }

        public Planet(string name, long Age, double weight, double accelerationOfFreeFall, DateTime DateOfDiscovery, Color starColor, string photo) : base(name, Age, DateOfDiscovery, starColor, photo) {
            this.Weight = weight;
            this.AccelerationOfFreeFall = accelerationOfFreeFall;
            this.ParentStar = new Star("Не указано");
            this.ChildrenMoons.Add(new Moon("Не указано"));
        }
    }
}