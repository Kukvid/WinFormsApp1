using WinFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
namespace WinFormsLibrary
{
    public abstract class SpaceObject
    {
        private string name = "Космобъект";
        public string Name
        {
            get { return name; }
            set
            {
                if (value[0].ToString().ToUpper() == value[0].ToString())
                {
                    name = value;
                }
                else
                {
                    string temp = "";
                    temp += value[0].ToString().ToUpper();
                    for (int i = 1; i < value.Length; i++)
                    {
                        temp += value[i];
                    }
                    name = temp;
                }
            }
        }

        public abstract string Check_abstract { get; set; }

        public long Age { get; private set; } = 400000000;

        private string photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";
        
        public Color SpaceObjectColor { get; set; }
        public string Photo
        {
            get { return photo; }
            set
            {
                if (value != "")
                {
                    photo = value;
                }
            }
        }
        static public string spaceObjectsPath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\spaceObjects.txt";

        public string Type { get; set; } = "SpaceObject";
        public Image Img
        {
            get { return getImageFromPath(this.Photo); }
        }
        public Image getImageFromPath(string path)
        {
            return Image.FromFile(path);
        }
        public abstract void print(RichTextBox box);
        /*{
            box.AppendText(Name + " " + Type);
        }*/

        public virtual void showPhoto(PictureBox box)
        {
            /*
            Graphics g = Graphics.FromHwnd(box.Handle);
            g.DrawImage(Image.FromFile(this.Photo), new Rectangle(0, 0, box.Width, box.Height));*/
            box.Image = Img;
        }
        public void showPhoto(Form box, string themePhoto)
        {
            box.BackgroundImage = Image.FromFile(themePhoto);
        }
        public void setAge(long age)
        {
            this.Age = age;
        }
        private DateTime dateOfDiscovery;
        public virtual DateTime DateOfDiscovery
        {
            get { return dateOfDiscovery; }
            set
            {
                if (value > DateTime.Now)
                {
                    dateOfDiscovery = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));

                }
                else
                {
                    dateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                }
            }
        }

        public string GetParsedColorFromString(string colorString)
        {
            if (colorString.StartsWith("Color [") && colorString.EndsWith("]"))
            {
                string colorName = colorString.Substring(7, colorString.Length - 8); // Extract the color name
                return colorName;
            }
            else
            {
                return ""; // Return Color.Empty for an invalid format
            }
        }

        public Color ParseColor(string input)
        {
            string color = GetParsedColorFromString(input);
            Color parsedColor = Color.FromName(color);
            if (!color.Contains("="))
            {
                return parsedColor;
            }
            else
            {
                try
                {
                    string[] argbValues = color.Split(", ");
                    if (argbValues.Length == 4)
                    {
                        int a = int.Parse(argbValues[0].Substring(2, argbValues[0].Length - 2));
                        int r = int.Parse(argbValues[1].Substring(2, argbValues[1].Length - 2));
                        int g = int.Parse(argbValues[2].Substring(2, argbValues[2].Length - 2));
                        int b = int.Parse(argbValues[3].Substring(2, argbValues[3].Length - 2));
                        return Color.FromArgb(a, r, g, b);
                    }
                    else
                    {
                        throw new ArgumentException("Недопустимый формат цвета");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(input);
                    throw new ArgumentException($"Ошибка при преобразовании в цвет: {ex.Message}");
                }
            }
        }
        //base(name, Age, DateOfDiscovery, starColor photo)
        public SpaceObject() { }

        public SpaceObject(string name)
        {
            this.Name = name;
        }
        public SpaceObject(string name, long age)
        {
            this.Name = name;
            this.Age = age;
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, Color ObjectColor, string photoAddr)
        {
            this.Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.SpaceObjectColor = ObjectColor;
            this.Photo = photoAddr;
        }

    }
    public sealed class Planet : SpaceObject {
        public double Weight { get; set; } = 1;
        //public long Volume { get; set; } = 1000000;
        public override string Check_abstract { get; set; } = "abstract Planet";

        public double AccelerationOfFreeFall { get; set; } = 9.8;

        private DateTime dateOfDiscovery;
        public override DateTime DateOfDiscovery {
            get { return dateOfDiscovery; }
            set {
                if (value > DateTime.Now)
                {
                    dateOfDiscovery = DateTime.Parse("12.04.2004 00:00");

                }
                else
                {
                    dateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                }
            }
        }
        private string getPlanetText()
        {
            string res_string = "Планета" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.AccelerationOfFreeFall.ToString()
                 + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo;

            return res_string;
        }
        public override sealed void showPhoto(PictureBox box)
        {
            base.showPhoto(box);
            MessageBox.Show("Я из переопределнного метода showPhoto");
        }
        public override void print(RichTextBox box){
            box.AppendText(Name + " " + Type);
        }
        public void writeToFile()
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
                            //temp.Volume = long.Parse(system_line[5]);
                            //MessageBox.Show(system_line[5]);
                            temp.AccelerationOfFreeFall = double.Parse(system_line[5]);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[6]);
                            temp.Photo = system_line[7];
                            planets.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return planets;
        }
        public string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nВес планеты: " + this.Weight.ToString() + " *10^24 кг\n";
            message += "Ускорение свободного падения: " + this.AccelerationOfFreeFall.ToString() + "м/c^2\n";
            return message;
        }
        public Planet(): base() {
            this.Type = "Планета";
        }
        public Planet(string name): base(name) {
            this.Type = "Планета";
        }

        public Planet(string name, long Age): base(name) {
            this.Type = "Планета";
        }

        public Planet(string name, long Age, double weight, double accelerationOfFreeFall, DateTime DateOfDiscovery, Color starColor, string photo) : base(name, Age, DateOfDiscovery, starColor, photo) {
            this.Type = "Планета";
            this.Weight = weight;
            this.AccelerationOfFreeFall = accelerationOfFreeFall;
        }
    }
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
        public override string Check_abstract { get; set; } = "abstract Moon";
        public override void print(RichTextBox box)
        {
            box.AppendText(Name + " " + Type);
        }
        private string getMoonText()
        {
            
            string res_string = "Луна" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo;

            return res_string;
        }
        public void writeToFile()
        {

            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getMoonText());
            streamWriter.Close();
        }
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
                            temp.Photo = system_line[6];
                            moons.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return moons;
        }
        public string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nВес луны: " +this.Weight.ToString() + " *10^24 кг\n";
            return message;
        }
        public Moon() : base() {
            this.Type = "Луна";
            
        }

        public Moon(string name, long Age, double weight, DateTime DateOfDiscovery, Color moonColor, string photo) : base(name, Age,DateOfDiscovery, moonColor, photo)
        {
            this.Weight = weight;
            this.Type = "Луна";
        }
    }

        public class Star: SpaceObject
        {   
 

        static public string openFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\openFileDialog.txt"; 
        static public string saveFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\saveFileDialog.txt";
        public override string Check_abstract { get; set; } = "abstract Star";

        public void NameText(RichTextBox rtb, Font newFont)
        {
            rtb.Font = newFont;
        }
        public override void print(RichTextBox box)
        {
            box.AppendText(Name + " " + Type);
        }
        public int calculateDaysFromDateOfDiscovery(DateTime dateOfDiscoveryTemp)
        {
            return (DateTime.Now - this.DateOfDiscovery).Days;
        }

        public override string ToString()
        {
            return "ToString()";
        }
        private string getStarText()
        {
            string res_string = "Звезда" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" + 
                 this.SpaceObjectColor.ToString() + "!!!" + this.Photo;

            return res_string;
        }

        public void writeToFile()
        {
            
            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getStarText());
            streamWriter.Close();
        }

        public void writeToFile(OpenFileDialog openFileDialog)
        {

            StreamWriter streamWriter = new StreamWriter(openFileDialogFilePath, true);
            streamWriter.WriteLine(openFileDialog.FileName);
            streamWriter.Close();
        }

        public void writeToFile(SaveFileDialog saveFileDialog)
        {

            StreamWriter streamWriter = new StreamWriter(saveFileDialogFilePath, true);
            streamWriter.WriteLine(saveFileDialog.FileName);
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
                            temp.Photo = system_line[5];
                            stars.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return stars;
        }
        

        public Star(): base() {
            this.Type = "Звезда";
        }
        public Star(string name, string photo): base(name)
        {
            this.Type = "Звезда";
            this.Photo = photo;
        }
        public Star(string name, long Age, DateTime DateOfDiscovery, Color starColor, string photo) : base(name, Age, DateOfDiscovery, starColor, photo)
        {
            this.Type = "Звезда";
        }
    }
}