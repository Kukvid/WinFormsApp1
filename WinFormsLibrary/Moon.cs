using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLibrary
{

    public class Moon : SpaceObject, ISpaceObject, IMoon, IReadWriteObjectsFromToFiles
    {
        // Поля класса
        // Поле, хранящее ссылку на звездную систему
        public StarSystem ParentStarSystem;


        // Конструкторы класса
        public Moon() : base(){ }
        public Moon(string name) : base(name)
        {

        }
        public Moon(string name, long age, double weight, DateTime DateOfDiscovery, Color moonColor, string photo) :
            base(name, age, DateOfDiscovery, moonColor, photo)
        {
            this.Weight = weight;
            this.ParentStarSystem = new StarSystem("Не указано");
            LoggingInFileEventMoon?.Invoke($"{DateTime.Now}. Создан объект типа {ToString()} и именем {this.Name} со следующими данными:\n" +
                $"Возраст луны: {age} лет,\n" +
                $"Дата открытия луны: {DateOfDiscovery}\n" +
                $"Цвет луны: {moonColor}.\n" +
                $"Масса луны: {weight} кг." +
                $"Путь до изображения: {photo}");
        }


        // Свойства класс
        // Масса луны
        public double Weight { get; set; } = 1;
        // Переопределенное свойство для обработки переданного возраста объекта
        public override long Age
        {
            get { return base.Age; }
            set
            {
                if (value < (long)Math.Pow(10, 6))
                {
                    base.Age = (long)Math.Pow(10, 6) + value;
                }
                LoggingInFileEventMoon?.Invoke($"У объекта типа {ToString()} установлен возраст {value}");
            }
        }
        // Переопределенное свойство для обработки даты открытия объекта
        public override DateTime DateOfDiscovery
        {
            get { return base.DateOfDiscovery; }
            set
            {
                if (value > DateTime.Now)
                {
                    base.DateOfDiscovery = DateTime.Parse(DateTime.MinValue.ToString("dd.MM.yyyy HH:mm"));
                    LoggingInFileEventMoon?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена дата открытия: {base.DateOfDiscovery} - текущее время, так как была попытка поставить дату открытия в будущем");

                }
                else
                {
                    base.DateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                    LoggingInFileEventMoon?.Invoke($"{DateTime.Now}. У объекта типа {ToString()} и именем {this.Name} установлена дата открытия: {base.DateOfDiscovery}");

                }
            }
        }

        // Методы класса
        
        // Приватный метод для формирования строки с данными о луне
        private string getMoonText()
        {
            
            string res_string = "Луна" + "!!!" + this.Name + "!!!" + this.Age.ToString() +
                 "!!!" + this.DateOfDiscovery.ToString("dd.MM.yyyy hh:mm") + "!!!" +
                 this.Weight.ToString() + "!!!" + this.SpaceObjectColor + "!!!" + this.Photo + "!!!" 
                 + this.ParentStarSystem.Name;

            return res_string;
        }
        // Метод, который находит среди списка звездных систем ту, у которой имя как в свойстве ParentStarSystem
        // и затем сохраняет ссылку на ту звездную систему в свойстве ParentStarSystem
        public void linkWithParent(List<StarSystem> starSystems)
        {
            foreach (StarSystem starSystem in starSystems)
            {
                if (starSystem.Name == ParentStarSystem.Name)
                {
                    ParentStarSystem = starSystem;
                    LoggingInFileEventMoon?.Invoke($"{DateTime.Now} . У объекта типа {ToString()} и именем {this.Name} установлена родительская звездная система с названием {starSystem.Name}");
                }
            }
        }
        // Метод для записи данных в файл.
        public void writeToFile()
        {

            StreamWriter streamWriter = new StreamWriter(SpaceObject.spaceObjectsPath, true);
            streamWriter.WriteLine(getMoonText());
            streamWriter.Close();
        }
        // Метод для чтения данных из файла.
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
                            temp.Age = long.Parse(system_line[2]);
                            temp.DateOfDiscovery = DateTime.ParseExact(system_line[3], "dd.MM.yyyy HH:mm", null);
                            temp.Weight = double.Parse(system_line[4]);
                            temp.SpaceObjectColor = temp.ParseColor(system_line[5]);
                            temp.setPhoto(system_line[6], true);
                            temp.ParentStarSystem = new StarSystem(system_line[7]);
                            moons.Add(temp);
                        }
                    }
                }
                sr.Close();
            }
            return moons;
        }
        // Метод для получения названия родительской Звездной системы по ссылке на объект
        public string getParentInfo()
        {
            string ChildrenInfo = "";
            ChildrenInfo += $"Состоит в звездной системе: {ParentStarSystem.Name}\n";
            return ChildrenInfo;
        }
        // Переопределенный метод для получения строки с дополнительной информацией
        // об объекте класса Луна
        public override string getStringWithAdditionalInfo()
        {
            string message = this.Name + "\nМасса луны: " +this.Weight.ToString() + " *10^24 кг\n";
            message += getParentInfo();
            return message;
        }
        // Переопределенный метод для получения типа объекта
        public override string ToString()
        {
            return "Луна";
        }
        // Событие для логирования
        public event LogHandler LoggingInFileEventMoon = writeLog;
    }
}