using System.Text;

namespace WinFormsLibrary
{
    public sealed class Planet : SpaceObject, ISpaceObject, IPlanet, IReadWriteObjectsFromToFiles
    {
        // Поля класса
        // Поле, хранящее ссылку на звездную систему
        public StarSystem ParentStarSystem;


        // Конструкторы класса
        public Planet() : base(){}
        public Planet(string name) : base(name){}
        public Planet(string name, long age, double weight, double accelerationOfFreeFall, DateTime DateOfDiscovery,
            Color planetColor, string photo) : base(name, age, DateOfDiscovery, planetColor, photo)
        {
            this.Weight = weight;
            this.AccelerationOfFreeFall = accelerationOfFreeFall;
            this.ParentStarSystem = new StarSystem("Не указано");
            LoggingInFileEventPlanet?.Invoke($"{DateTime.Now}. Создан объект типа {ToString()} и именем {this.Name} со следующими данными:\n" +
                $"Имя планеты: {name},\n" +
                $"Возраст планеты: {age} лет,\n" +
                $"Дата открытия планеты: {DateOfDiscovery}\n" +
                $"Цвет планеты: {planetColor}.\n" +
                $"Масса планеты: {weight} 10^24 кг.\n" +
                $"Ускорение свободного падения: {accelerationOfFreeFall} м/с^2.\n" +
                $"Путь до изображения: {photo}");
        }


        // Свойства класса
        // Свойство, хранящее массу объекта
        public double Weight { get; set; } = 1;
        // Свойство, хранящее ускорение свободного падения
        public double AccelerationOfFreeFall { get; set; } = 9.8;


        // Методы класса
        // Приватный метод для формирования строки с данными о Планете
        private string getPlanetText()
        {
            string res_string = "Планета" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.AccelerationOfFreeFall.ToString()
                 + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo + "!!!" +
                 this.ParentStarSystem.Name;

            return res_string;
        }
        // Метод, который находит среди списка звездных систем ту, у которой имя как в свойстве ParentStarSystem
        // и затем сохраняет ссылку на ту звездную систему в свойстве ParentStarSystem
        public void LinkWithParent(List<StarSystem> starSystems)
        {
            foreach (StarSystem starSystem in starSystems)
            {
                if (starSystem.Name == ParentStarSystem.Name)
                {
                    ParentStarSystem = starSystem;
                    LoggingInFileEventPlanet?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена родительская звездная система с названием {starSystem.Name}");

                }

            }
        }
        // Метод для записи данных в файл.
        public void writeToFile()
        {
            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getPlanetText());
            streamWriter.Close();
        }
        // Метод для чтения данных из файла.
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
                            temp.Age = long.Parse(system_line[2]);
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.Weight = double.Parse(system_line[4]);
                            temp.AccelerationOfFreeFall = double.Parse(system_line[5]);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[6]);
                            temp.setPhoto(system_line[7], true);
                            temp.ParentStarSystem = new StarSystem(system_line[8]);
                            planets.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return planets;
        }
        // Получить название родительской звездной системы
        public string getParentInfo()
        {
            string ChildrenInfo = "";
            ChildrenInfo += $"Состоит в звездной системе: {ParentStarSystem.Name}\n";
            return ChildrenInfo;
        }
        // Переопределенный метод для получения строки с дополнительной информацией
        // об объекте класса Планета
        public override string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nМасса планеты: " + this.Weight.ToString() + " *10^24 кг\n";
            message += "Ускорение свободного падения: " + this.AccelerationOfFreeFall.ToString() + "м/c^2\n";
            message += getParentInfo();
            return message;
        }
        // Переопределенный метод для получения типа объекта
        public override string ToString()
        {
            return "Планета";
        }
        // Событие логирования
        public event LogHandler LoggingInFileEventPlanet = SpaceObject.writeLog;

    }
}