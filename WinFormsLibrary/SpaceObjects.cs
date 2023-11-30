using WinFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.DirectoryServices;
using System.Xml.Linq;

namespace WinFormsLibrary
{
    public abstract class SpaceObject: ISpaceObject
    {
        private string name = "Космобъект";

        public string Name
        {
            get { return name; }
            set
            {
                //MessageBox.Show(value);
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

        public string Type
        {
            get
            {
                return ToString();
            }
        }

        public string NameWithType
        {
            get
            {
                return GetNameWithType();
            }
        }

        public long Age { get; private set; } = 400000000;


        private string photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";
        

        public Color SpaceObjectColor { get; set; }
        public string Photo
        {
            get { return photo; }
            private set
            {
                if (value != "")
                {
                    photo = value;
                }
            }
        }
        //
        public delegate void SpaceObjectPhotoHandler(string path);

        public event SpaceObjectPhotoHandler SpaceObjectPhotoCheck;

        public delegate void ObjectHandler(object sender, AccountEventArgs e);
        public event ObjectHandler ObjectEventCheck;
        // Добавить в интерфейс
        public void setPhoto(string photo, bool isRead)
        {
            if (isRead)
            {
                this.Photo = photo;
            }
            else
            {
                this.Photo = photo;
                if (photo == "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg")
                {
                    SpaceObjectPhotoCheck?.Invoke("Установлена дефолтная картинка");
                }
                else
                {
                    string[] splitted_photo = photo.Split('\\');
                    SpaceObjectPhotoCheck?.Invoke($"Установлена картинка {splitted_photo[splitted_photo.Length - 1]}");
                }
            }
        }
        public void setPhoto(string photo)
        {
            this.Photo = photo;
            if (photo == "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg")
            {
                SpaceObjectPhotoCheck?.Invoke("Установлена дефолтная картинка");
            }
            else
            {
                string[] splitted_photo = photo.Split('\\');
                SpaceObjectPhotoCheck?.Invoke($"Установлена картинка {splitted_photo[splitted_photo.Length - 1]}");
            }
        }
        /*
        public void checkObjectHandler(string msg)
        {
            ObjectEventCheck?.Invoke(this, new AccountEventArgs($"{msg}\n" +
                $"Возраст текущего объекта:{this.Age}\n",
                this.Age));
        }
        
        public static void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }*/

        static public string spaceObjectsPath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\spaceObjects.txt";

        public Image Img
        {
            get { return getImageFromPath(this.Photo); }
        }

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
        public Image getImageFromPath(string path)
        {
            return Image.FromFile(path);
        }
        //public abstract void print(RichTextBox box);

        public void showPhoto(PictureBox box)
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

        public string Join(string separator, List<SpaceObject> objects)
        {
            string result_string = objects[0].Name;
            for (int i = 1; i < objects.Count; i++)
            {
                result_string += separator + objects[i].Name;
            }
            return result_string;
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
        
        public override string ToString()
        {
            return "Космообъект";
        }
        public string GetNameWithType()
        {
            return Name + " ["+ this.ToString()+"]";
        }
        public virtual void writeToFile() { }
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
        public SpaceObject(string name, long age, Color ObjectColor,DateTime DateOfDiscovery, string photoPath)
        {
            this.Name = name;
            this.Age = age;
            this.SpaceObjectColor = ObjectColor;
            this.DateOfDiscovery = DateOfDiscovery;
            this.photo = photoPath;
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, Color ObjectColor, string photoAddr)
        {
            this.Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.SpaceObjectColor = ObjectColor;
            this.setPhoto(photoAddr);
        }

    }
}