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
//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
namespace WinFormsLibrary
{

    public class StarSystem
    {

        /// <remarks>Имя системы</remarks>
        private string name;
        public string Name {
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
        public long Age { get; private set; } = 400000000;

        private int countStars = 0;

        public int CountStars
        {
            //убрать private
            get { return countStars; }
            set
            {
                if (value > 0)
                {
                    countStars = value;
                }
                else
                {
                    countStars = 1;
                }
            }
        }

        private decimal countUniverses = (decimal)4e12;
        public decimal CountUniverses => countUniverses;

        /// <remarks>Возраст системы</remarks>

        /// <remarks>Цвет звезды</remarks>
        public Color starColor { get; set; }

        //public Color StarColor => starColor;

        //public static Color AdditionalColor { get; }

        public static Color AdditionalColor { get; } = Color.Black;

        private DateTime dateOfDiscovery;

        public DateTime DateOfDiscovery
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

        private string photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";

        public string Photo{
            get { return photo; }
            set { 
                if (value != "") {
                    photo = value;
                }
            }
        }

        public Image Img {
            get { return getImageFromPath(this.Photo); } }

        static public string starSystemsFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\StarSystems.txt";
        static public string openFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\openFileDialog.txt"; 
        static public string saveFileDialogFilePath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\saveFileDialog.txt";

        public int getCountStars()
        {
            return countStars;
        }

        public void setAge(long age)
        {
            this.Age = age;
        }

        public int calculateDaysFromDateOfDiscovery(DateTime dateOfDiscoveryTemp)
        {
            return (DateTime.Now - this.DateOfDiscovery).Days;
        }
        
        public Image getImageFromPath(string path)
        {
            return Image.FromFile(path);
        }
        public void showPhoto(PictureBox box)
        {
            Graphics g = Graphics.FromHwnd(box.Handle);
            g.DrawImage(Image.FromFile(this.photo), new Rectangle(0,0,box.Width,box.Height));
        }
        public void showPhoto(Form box, string themePhoto)
        {
            /*
            Graphics g = Graphics.FromHwnd(box.Handle);
            g.DrawImage(Image.FromFile(themePhoto), new Rectangle(0, 0, box.Width, box.Height));
            */
            box.BackgroundImage = Image.FromFile(themePhoto);
        }

        private string getStarSystemText()
        {
            string res_string = this.Name + "!!!" + this.CountStars.ToString() + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" + 
                 this.starColor.ToString() + "!!!" + this.Photo;

            return res_string;
        }

        /*
        static public void clearEmptyStringInStarSystemFile()
        {
            StreamReader sw = new StreamReader(starSystemsFilePath);

            StringBuilder stringBuilder = new StringBuilder(); 
            

            streamWriter.Close();
        }*/

        public void writeToFile()
        {
            
            StreamWriter streamWriter = new StreamWriter(starSystemsFilePath, true);
            streamWriter.WriteLine(getStarSystemText());
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

        static public BindingList<StarSystem> readFromFile()
        {
            BindingList<StarSystem> systems = new BindingList<StarSystem>();
            FileInfo fileInfo = new FileInfo(starSystemsFilePath);
            if (fileInfo.Length != 0)
            {

                StreamReader sr = new StreamReader(starSystemsFilePath, Encoding.UTF8, true);
                string s = sr.ReadToEnd();
                string[] lines = s.Split(Environment.NewLine);

                foreach (string line in lines)
                {
                    if (line != string.Empty)
                    {
                        string[] system_line = line.Split("!!!");
                        StarSystem temp = new StarSystem();
                        temp.name = system_line[0];
                        temp.CountStars = int.Parse(system_line[1]);
                        temp.Age = long.Parse(system_line[2]);
                        temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);

                        temp.starColor = ParseColor(system_line[4]);
                        temp.Photo = system_line[5];
                        systems.Add(temp);
                    }
                }
                sr.Close();
            }
            return systems;
        }
        static public int readFromFile(OpenFileDialog openFileDialog)
        {
            StreamReader sr = new StreamReader(starSystemsFilePath, Encoding.UTF8, true);
            string s = sr.ReadToEnd();
            string[] lines = s.Split(Environment.NewLine);

            return lines.Count() - 1 ;
        }
        static public int readFromFile(SaveFileDialog saveFileDialog)
        {
            StreamReader sr = new StreamReader(saveFileDialogFilePath, Encoding.UTF8, true);
            string s = sr.ReadToEnd();
            string[] lines = s.Split(Environment.NewLine);

            return lines.Count() - 1;
        }
        static string GetParsedColorFromString(string colorString)
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

        static Color ParseColor(string input)
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

        public StarSystem() { }

        public StarSystem(string name)
        {
            this.name = name;
        }
        public StarSystem(string name, string photo)
        {
            this.name = name;
            this.Photo = photo;
        }
        public StarSystem(string name, int CountStars, long Age, DateTime DateOfDiscovery, Color starColor, string photo)
        {
            this.name = name;
            this.CountStars = CountStars;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.starColor = starColor;
            this.Photo = photo;
        }
        /*
        static StarSystem()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfYear % 2 == 0)
            {
                StarSystem.AdditionalColor = Color.Red;
            }
            else
            {
                StarSystem.AdditionalColor = Color.LimeGreen;
            }
        }
        */

    }
}