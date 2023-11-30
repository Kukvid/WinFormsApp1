using System.Text;
using System.ComponentModel;

namespace WinFormsLibrary
{
    public class Star: SpaceObject
    {

    //public Star ParentStarField { get; set; } = new Star("Не указано");

    public StarSystem ParentStarSystem;
    public List<Planet> ChildrenPlanets = new List<Planet>();

    //static public string openFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\openFileDialog.txt"; 
    //static public string saveFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\saveFileDialog.txt";



    public int calculateDaysFromDateOfDiscovery(DateTime dateOfDiscoveryTemp)
    {
        return (DateTime.Now - this.DateOfDiscovery).Days;
    }
    public void LinkWithParentAndChildren(List<Planet> planets, BindingList<StarSystem> starSystems)
    {
        foreach (StarSystem starSystem in starSystems)
        {
            if (starSystem.Name == ParentStarSystem.Name)
            {
                ParentStarSystem = starSystem;
            }
        }
        foreach (Planet planet in planets)
        {
            for (int i = 0; i < ChildrenPlanets.Count; i++)
            {
                if (planet.Name == ChildrenPlanets[i].Name)
                {
                    ChildrenPlanets[i] = planet;
                }
            }
        }
    }
     
    private string Join(string separator, List<Planet> objects)
    {
        string result_string = objects[0].Name;
        for (int i = 1; i < objects.Count; i++)
        {
            result_string += separator + objects[i].Name;
        }
        return result_string;
    }
    private string getStarText()
    {
    string res_string = "Звезда" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
            "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" + 
            this.SpaceObjectColor.ToString() + "!!!" + this.Photo + "!!!" + 
            this.ParentStarSystem.Name + "!!!" + this.Join(",", ChildrenPlanets);


    return res_string;
    }
    public string getChildrenAndParentInfo()
    {
        string ChildrenAndParentInfo = "";
        ChildrenAndParentInfo += $"Звездная система, в которой состоит - {ParentStarSystem.Name}\n";
        ChildrenAndParentInfo += $"Планеты, которые вращаются вокруг: {this.Join(",", ChildrenPlanets)}\n";
        return ChildrenAndParentInfo;
    }
    public string getStringWithAdditionalInfo()
    {
        string message = getChildrenAndParentInfo();
        return message;
    }
    public override void writeToFile()
    {
            
        StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
        streamWriter.WriteLine(getStarText());
        streamWriter.Close();
    }

    static public List<Star> readFromFile()
    {
        List<Star> stars = new List<Star>();
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
                    if (system_line[0] == "Звезда")
                    {
                        Star temp = new Star();
                        temp.Name = system_line[1];
                        temp.setAge(long.Parse(system_line[2]));

                        temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);

                        temp.SpaceObjectColor = temp.ParseColor(system_line[4]);
                        temp.setPhoto(system_line[5],true);

                        if (system_line.Length == 6)
                        {
                            temp.ParentStarSystem = new StarSystem("Не указано");
                            temp.ChildrenPlanets = new List<Planet>() { new Planet("Не указано") };
                        }
                        else
                        {
                            temp.ParentStarSystem = new StarSystem(system_line[6]);
                            foreach (string PlanetName in system_line[7].Split(","))
                            {
                                temp.ChildrenPlanets.Add(new Planet(PlanetName));
                            }
                        }
                        stars.Add(temp);
                    }
                }
            }
            sr.Close();
        }
        return stars;
    }
    public override string ToString()
    {
        return "Звезда";
    }
        //Агрегация бывает только бинарная

    public Star(): base() {
    //this.ParentStarSystem = new StarSystem("Не указано");
    //this.ChildrenPlanets.Add(new Planet("Не указано"));
    }
    public Star(string name) : base(name)
    {
        //this.ParentStarSystem = new StarSystem("Не указано");
        //this.ChildrenPlanets.Add(new Planet("Не указано"));
    }
    public Star(string name, long Age, DateTime DateOfDiscovery, Color starColor, string photo) : base(name, Age, DateOfDiscovery, starColor, photo)
    {
        this.ParentStarSystem = new StarSystem("Не указано");
        this.ChildrenPlanets.Add(new Planet("Не указано"));
    }
    }
}