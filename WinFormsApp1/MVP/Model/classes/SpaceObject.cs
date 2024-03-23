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
using WinFormsLibrary.utils;

namespace WinFormsLibrary.classes
{
    public abstract class SpaceObject : ISpaceObject
    {
        // Поля класса
        // Поле, хранящее путь к файлу, в котором созраняются все космические объекты
        static public string spaceObjectsPath = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\spaceObjects.txt";
        
        // Поле, хранящее название космического объекта
        private string name = "Космобъект";
        
        // Поле, хранящее возраст объекта.
        private long age = (long)Math.Pow(10, 6);
        
        // Поле, хранящее путь к изображению объекта
        private string image = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";
        
        // Поле, хранящее дату открытия космического объекта.
        private DateTime dateOfDiscovery;

        // Поле, хранящее цвет космического объекта.
        private Color spaceObjectColor;


        // Конструкторы класса
        public SpaceObject() { }
        public SpaceObject(string name)
        {
            Name = name;
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, Color ObjectColor, string photoAddr)
        {
            Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            SpaceObjectColor = ObjectColor;
            setPhoto(photoAddr);
        }
        public SpaceObject(string name, long Age, DateTime DateOfDiscovery, string photoAddr)
        {
            Name = name;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            setPhoto(photoAddr);
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
                LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} установлено имя {name}");
            }
        }

        // Свойство для более наглядного отображения созданных объектов в списке объектов( только для чтения)
        public string NameWithType { get { return Name + " [" + ToString() + "]"; } }

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
        public Color SpaceObjectColor {
            get { return spaceObjectColor; }
            set {
                spaceObjectColor = value;

            } }

        // Свойство для получения пути к фотографии космического объекта
        public string Photo
        {
            get { return image; }
            private set
            {
                if (value != "")
                {
                    image = value;
                }
            }
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
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {Name} установлено предустановленное изображение");

                }
                else
                {
                    dateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {Name} установлено изображение, расположенное по адресу {value}");

                }
            }
        }


        // Методы класса
    
        // Метод для установки фотографии космического объекта.
        public void setPhoto(string photo, bool isReadFromFile = false)
        {
            if (isReadFromFile)
            {
                Photo = photo;
                LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {Name} установлена картинка {Photo}");
            }
            else
            {
                Photo = photo;
                if (photo == "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg")
                {
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {Name} установлена дефолтная картинка");
                }
                else
                {
                    LoggingInFileEvent?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {Name} установлена картинка {Photo}");
                }
            }
        }

        // Метод для получения строки с дополнительной информацией.
        public virtual string getStringWithAdditionalInfo()
        {
            return "Нет дополнительной информации";
        }

        
        // Переопределенный метод для представления типа объекта в виде строки.
        public override string ToString()
        {
            return "Космообъект";

        }

        
        // Делегат для обработки события логирования.
        public delegate void LogHandler(string log);

        // Событие логирования, связанное с делегатом LogHandler.
        //При инициализации можно устанавливать только статические методы в качестве обработчиков события
        public event LogHandler LoggingInFileEvent = Utils.writeLog;


    }
}