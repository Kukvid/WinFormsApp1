using System.Text;

namespace WinFormsLibrary
{
    // Не может наследоваться от запечатанного класса
    /*
    public class SmallPlanet: Planet
    {
        
        public override void showPhoto(PictureBox box)
        {
            base.showPhoto(box);
            MessageBox.Show("Я из переопределнного метода showPhoto");
        }
        public SmallPlanet(): base() {}
    }*/

    public class Moon : SpaceObject
    {
        public double Weight { get; set; } = 1;

        public Planet ParentPlanet = new Planet("Не указано");

        private string getMoonText()
        {
            
            string res_string = "Луна" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo + "!!!" 
                 + this.ParentPlanet.Name;

            return res_string;
        }
        public override void writeToFile()
        {

            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getMoonText());
            streamWriter.Close();
        }
        public void LinkWithParent(List<Planet> planets)
        {
            foreach (Planet planet in planets)
            {
                if (planet.Name == ParentPlanet.Name)
                {
                    ParentPlanet = planet;
                }
            }
        }
        /*
        public void LinkWithAnotherSpaceObject(Planet planet, Moon moon) {
            if (ParentPlanet == planet)
            {
                ParentPlanet = new Planet("Не указано");
            }
            else
            {
                this.ParentPlanet = planet;
            }  
        }
        public void LinkWithAnotherSpaceObject(Planet planet, Moon moon)
        {
            if (ParentPlanet == planet)
            {
                ParentPlanet = new Planet("Не указано");
                planet.ChildrenMoons.Remove(moon);
                if (planet.ChildrenMoons.Count == 0)
                {

                }
            }
            else
            {
                this.ParentPlanet = planet;
            }
        }
        public void LinkWithAnotherSpaceObject(Moon moon, Moon moon2)
        {
            MessageBox.Show("Нельзя привять луну с луной");
        }
        public void LinkWithAnotherSpaceObject(Moon moon, Moon moon2)
        {
            MessageBox.Show("Нельзя привять луну с луной");
        }
        public void LinkWithAnotherSpaceObject(Moon moon, Moon moon2)
        {
            MessageBox.Show("Нельзя привять луну с луной");
        }
        */
        static public List<Moon> readFromFile()
        {
            List<Moon> moons = new List<Moon>();
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
                        if (system_line[0] == "Луна")
                        {
                            Moon temp = new Moon();
                            temp.Name = system_line[1];
                            temp.setAge(long.Parse(system_line[2]));
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.Weight = double.Parse(system_line[4]);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[5]);
                            temp.setPhoto(system_line[6], true);
                            if (system_line.Count() ==7)
                            {
                                temp.ParentPlanet = new Planet("Не указано");
                            }
                            else
                            {
                                temp.ParentPlanet = new Planet(system_line[7]);
                            }
                            moons.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return moons;
        }
        
        public string getParentInfo()
        {
            string ChildrenInfo = "";
            ChildrenInfo += $"Планета, вокруг которой вращается - {ParentPlanet.Name}\n";
            return ChildrenInfo;
        }
        public string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nВес луны: " +this.Weight.ToString() + " *10^24 кг\n";
            message += getParentInfo();
            return message;
        }
        public override string ToString()
        {
            return "Луна";
        }
        public Moon() : base() {
            //this.ParentPlanet = new Planet();
        }
        public Moon(string name) : base(name)
        {
        }
        public Moon(string name, long Age, double weight, DateTime DateOfDiscovery, Color moonColor, string photo) : base(name, Age,DateOfDiscovery, moonColor, photo)
        {
            this.Weight = weight;
            this.ParentPlanet = new Planet("Не указано");
        }
    }
}