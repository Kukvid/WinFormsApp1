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
    public abstract class SpaceObject : ISpaceObject, IReadWriteObjectsFromToFiles
    {
        // Поля класса
        // Поле, хранящее путь к файлу, в котором созраняются все космические объекты
        static public string spaceObjectsPath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\spaceObjects.txt";
        // Поле, хранящее название космического объекта
        private string name = "Космобъект";
        // Поле, хранящее возраст объекта.
        private long age = (long)Math.Pow(10,6);
        // Поле, хранящее путь к изображению объекта
        private string photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";
        // Поле, хранящее дату открытия космического объекта.
        private DateTime dateOfDiscovery;


        // Конструкторы класса
        public SpaceObject() { }
        public SpaceObject(string name)
        {
            this.Name = name;
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, Color ObjectColor, string photoAddr)
        {
            this.Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.SpaceObjectColor = ObjectColor;
            this.setPhoto(photoAddr);
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, string photoAddr)
        {
            this.Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.setPhoto(photoAddr);
        }
        
        
        // Свойства класса
        // Свойство для получения дополнительной информации о космическом объекте (только для чтения).
        public virtual string AdditionalInfo { get { return getStringWithAdditionalInfo(); } }
        // Свойство для получения и установки имени космического объекта.
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
                LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} установлено имя {this.name}");
            }
        }
        // Свойство для более наглядного отображения созданных объектов в списке объектов( только для чтения)
        public string NameWithType { get { return Name + " [" + ToString() + "]"; } }
        // Свойство для получения информации об объекте (только для чтения)
        public string Type
        {
            get
            {
                return ToString();
            }
        }
        // Свойство  для получения и изменения возраста космического объекта.
        public virtual long Age
        {
            get { return age; }
            set
            {
                age = value;
                LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} установлен возраст {value}");
            }
        }
        // Свойство для получения и установки цвета космического объекта.
        public Color SpaceObjectColor { get; set; }
        // Свойство для получения пути к фотографии космического объекта
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
        // Свойство для получения изображения космического объекта (только для чтения).
        public Image Img
        {
            get { return getImageFromPath(this.Photo); }
        }
        // Свойство для получения и установки даты открытия космического объекта.
        public virtual DateTime DateOfDiscovery
        {
            get { return dateOfDiscovery; }
            set
            {
                if (value > DateTime.Now)
                {
                    dateOfDiscovery = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлено предустановленное изображение");

                }
                else
                {
                    dateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлено изображение, расположенное по адресу {value}");

                }
            }
        }


        // Методы класса
        // Метод для записи лога в файл.
        public static void writeLog(string log)
        {
            string logging_path = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\logs.txt";
            StreamWriter streamWriter = new StreamWriter(logging_path, true);
            streamWriter.WriteLine(log);
            streamWriter.Close();
        }
        // Метод для установки фотографии космического объекта.
        public void setPhoto(string photo, bool isReadFromFile = false)
        {
            if (isReadFromFile)
            {
                this.Photo = photo;
                LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена картинка {Photo}");
            }
            else
            {
                this.Photo = photo;
                if (photo == "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg")
                {
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена дефолтная картинка");
                }
                else
                {
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена картинка {Photo}");
                }
            }
        }
        // Метод для отображения фотографии объекта в PictureBox.
        public void showPhoto(PictureBox box)
        {
            box.Image = Img;
        }
        // Метод для получения строки с дополнительной информацией.
        public virtual string getStringWithAdditionalInfo()
        {
            return "Нет дополнительной информации";
        }
        // Метод для получения изображения из указанного пути.
        public Image getImageFromPath(string path)
        {
            return Image.FromFile(path);
        }

        // Метод для объединения строк с разделителем и списком космических объектов.
        public virtual string Join(string separator, List<SpaceObject> objects)
        {
            string result_string = objects[0].Name;
            for (int i = 1; i < objects.Count; i++)
            {
                result_string += separator + objects[i].Name;
            }
            return result_string;
        }

        //Метод для получения нужной подстроки из строки с цветом объекта
        private protected string getParsedColorFromString(string colorString)
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

        //Метод для получения цвет из строки
        private protected Color ParseColor(string input)
        {
            string color = getParsedColorFromString(input);
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
                        LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} произошла ошибка(недопустимый формат цвета) чтения цвета из файла с данными");
                        return Color.White;
                    }
                }

                catch (Exception ex)
                {
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} произошла ошибка({ex.Message}) чтения цвета из файла с данными");
                    return Color.White;
                }
            }
        }
        // Переопределенный метод для представления типа объекта в виде строки.
        public override string ToString()
        {
            return "Космообъект";
            
        }
        // Метод для записи данных в файл.
        static public void writeToFile() { }

        // Метод для чтения данных из файла.
        static public void readFromFile() { }

        // Делегат для обработки события логирования.
        public delegate void LogHandler(string log);
        // Событие логирования, связанное с делегатом LogHandler.
        //При инициализации можно устанавливать только статические методы в качестве обработчиков события
        public virtual event LogHandler LoggingInFileEvent=writeLog;
        
    }
}