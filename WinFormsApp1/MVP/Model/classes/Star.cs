using System.Text;
using System.ComponentModel;
using WinFormsLibrary.classes;
using WinFormsLibrary.utils;

namespace WinFormsLibrary
{
    public class Star : SpaceObject, IStar
    {
        // Поля класса
        // Поле, хранящее ссылку на звездную систему
        public StarSystem ParentStarSystem;
        // Конструкторы класса
        public Star() : base() { }
        public Star(string name) : base(name)
        {

        }
        public Star(string name, long age, DateTime DateOfDiscovery, Color starColor, string photo) :
                base(name, age, DateOfDiscovery, starColor, photo)
        {
            this.ParentStarSystem = new StarSystem("Не указано");
            LoggingInFileEventStar?.Invoke($"{DateTime.Now}. Создан объект типа {ToString()} и именем {this.Name} со следующими данными:\n" +
                    $"Возраст звезды: {age} лет,\n" +
                    $"Дата открытия звезды: {DateOfDiscovery}\n" +
                    $"Цвет звезды: {starColor}.\n" +
                    $"Путь до изображения: {photo}");
        }
        // Свойства класса

        // Методы класса

        // Метод, который находит среди списка звездных систем ту, у которой имя как в свойстве ParentStarSystem
        // и затем сохраняет ссылку на ту звездную систему в свойстве ParentStarSystem
        public void LinkWithParent(List<StarSystem> starSystems)
        {
            foreach (StarSystem starSystem in starSystems)
            {
                if (starSystem.Name == ParentStarSystem.Name)
                {
                    ParentStarSystem = starSystem;
                    LoggingInFileEventStar?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена родительская звездная система с названием {starSystem.Name}");
                }
            }
        }
        
        // Переопределенный метод для получения строки с дополнительной информацией
        // об объекте класса Звездная система
        public override string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\n" + $"Состоит в звездной системе: {ParentStarSystem.Name}";
            return message;
        }
        // Переопределенный метод для получения типа объекта
        public override string ToString()
        {
            return "Звезда";

        }
        // Событие для логирования
        public event LogHandler LoggingInFileEventStar = Utils.writeLog;
    }

    public class StarDB: IReadWriteObjectsFromToFiles
    {// Приватный метод для формирования строки с данными о звезде
        static private string getStarText(Star star)
        {
            string res_string = star.ToString() + "!!!" +
                    star.Name + "!!!" +
                    star.Age.ToString() + "!!!" +
                    star.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                    star.SpaceObjectColor.ToString() + "!!!" +
                    star.Photo + "!!!" +
                    star.ParentStarSystem.Name;

            return res_string;
        }

        // Метод для записи данных в файл.
        public static void writeToFile(List<Star> stars)
        {

            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            foreach (Star star in stars)
            {
                streamWriter.WriteLine(getStarText(star));
            }
            streamWriter.Close();
        }

        // Метод для чтения данных из файла.
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
                            temp.Age = long.Parse(system_line[2]);

                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);

                            temp.SpaceObjectColor = Utils.ParseColor(system_line[4], temp.Name);
                            temp.setPhoto(system_line[5], true);
                            temp.ParentStarSystem = new StarSystem(system_line[6]);
                            stars.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return stars;
        }
    }
}
   