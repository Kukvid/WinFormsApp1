using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary;

namespace WinFormsApp1
{
    public partial class FormChangeDataStarSystem : Form
    {
        // Списки лун, планет и звезд, получаемые из FormListOfObjects
        List<Moon> moons = FormListOfObjects.instance.moons;
        List<Planet> planets = FormListOfObjects.instance.planets;
        List<Star> stars = FormListOfObjects.instance.stars;

        // Списки свободных лун, планет и звезд для добавления к звездной системе
        public List<Moon> freeMoons = new List<Moon>() { };
        public List<Planet> freePlanets = new List<Planet>() { };
        public List<Star> freeStars = new List<Star>() { };

        // Список звездных систем и BindingList объектов
        List<StarSystem> starSystems = FormListOfObjects.instance.starSystems;
        BindingList<SpaceObject> objects = FormListOfObjects.instance.objects;

        // Имя текущей звездной системы
        string systemName;
        public FormChangeDataStarSystem()
        {
            // Инициализация компонентов формы
            InitializeComponent();
            // Настройка изображения для PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.default_star_system;
            // Обновление списков свободных объектов
            updateFreeObjectsLists(moons, planets, stars, freeMoons, freePlanets, freeStars);

            // Получение имени текущей звездной системы из выбранного объекта в ListBox
            systemName = objects[FormListOfObjects.instance.listBox1.SelectedIndex].Name;

            // Получение объекта для изменения данных
            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];
            
            // Обновление списков объектов на форме и заполнение полей данными
            updateListBoxes(moons, planets, stars, freeMoons, freePlanets, freeStars, spaceObjectToChange);

            // Заполнение полей данными из выбранного объекта
            textBox1.Text = spaceObjectToChange.Name;
            numericUpDown1.Value = spaceObjectToChange.Age;
            dateTimePicker1.Value = spaceObjectToChange.DateOfDiscovery;
            pictureBox1.Image = spaceObjectToChange.Img;
            pictureBox1.Tag = spaceObjectToChange.Photo;

        }
        // Метод для обновления списков объектов в ListBox на форме
        private void updateListBoxes(List<Moon> moons, List<Planet> planets, List<Star> stars, List<Moon> freeMoons, 
            List<Planet> freePlanets, List<Star> freeStars, SpaceObject spaceObjectToChange)
        {
            // Добавление свободных звезд в ListBox
            foreach (Star star in freeStars)
            {
                listBoxStars1.Items.Add(star.Name);
            }
            // Добавление свободных планет в ListBox
            foreach (Planet planet in freePlanets)
            {
                listBoxPlanets1.Items.Add(planet.Name);
            }
            // Добавление свободных лун в ListBox
            foreach (Moon moon in freeMoons)
            {
                listBoxMoons1.Items.Add(moon.Name);
            }
            // Добавление звезд в составе текущей звездной системы в ListBox
            foreach (Star star in stars)
            {
                if (star.ParentStarSystem.Name == spaceObjectToChange.Name)
                {
                    listBoxStars2.Items.Add(star.Name);
                }
            }
            // Добавление планет в составе текущей звездной системы в ListBox
            foreach (Planet planet in planets)
            {
                if (planet.ParentStarSystem.Name == spaceObjectToChange.Name)
                {
                    listBoxPlanets2.Items.Add(planet.Name);
                }
            }
            // Добавление лун в составе текущей звездной системы в ListBox

            foreach (Moon moon in moons)
            {
                if (moon.ParentStarSystem.Name == spaceObjectToChange.Name)
                {
                    listBoxMoons2.Items.Add(moon.Name);
                }
            }
        }
        // Метод для обновления списков свободных лун, планет и звезд
        private void updateFreeObjectsLists(List<Moon> moons, List<Planet> planets, List<Star> stars, List<Moon> freeMoons, List<Planet> freePlanets, List<Star> freeStars)
        {
            // Перебор каждой луны в списке лун
            foreach (Moon moon in moons)
            {
                // Проверка, принадлежит ли луна к какой-либо звездной системе
                if (moon.ParentStarSystem.Name == "Не указано")
                {
                    // Если луна не привязана к звездной системе, добавляем её в список свободных лун
                    freeMoons.Add(moon);
                }
            }

            // Перебор каждой планеты в списке планет
            foreach (Planet planet in planets)
            {
                // Проверка, принадлежит ли планета к какой-либо звездной системе
                if (planet.ParentStarSystem.Name == "Не указано")
                {
                    // Если планета не привязана к звездной системе, добавляем её в список свободных планет
                    freePlanets.Add(planet);
                }
            }

            // Перебор каждой звезды в списке звезд
            foreach (Star star in stars)
            {
                // Проверка, принадлежит ли звезда к какой-либо звездной системе
                if (star.ParentStarSystem.Name == "Не указано")
                {
                    // Если звезда не привязана к звездной системе, добавляем её в список свободных звезд
                    freeStars.Add(star);
                }
            }
        }
        // Обработчик события нажатия кнопки для добавления фотографии
        private void addPhoto_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора файла
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // Обновление изображения в PictureBox
                pictureBox1.Refresh();

                // Создание временного объекта луны
                Moon tempObject = new Moon();

                // Установка фотографии из выбранного файла
                tempObject.setPhoto(openFileDialog1.FileName);

                // Отображение фотографии в PictureBox
                tempObject.showPhoto(pictureBox1);

                // Запись пути к фотографии в свойство Tag PictureBox
                pictureBox1.Tag = openFileDialog1.FileName;
            }
        }

        // Обработчик события нажатия кнопки для добавления звезды в звездную систему
        private void buttonAddStar_Click(object sender, EventArgs e)
        {
            // Проверка выбранного элемента в списке свободных звезд
            if (listBoxStars1.SelectedIndex != -1)
            {
                // Добавление выбранной звезды в список звезд текущей звездной системы
                listBoxStars2.Items.Add(listBoxStars1.SelectedItem);
                // Удаление выбранной звезды из списка свободных звезд
                listBoxStars1.Items.Remove(listBoxStars1.SelectedItem);
            }
        }

        // Обработчик события нажатия кнопки для удаления звезды из звездной системы
        private void buttonRemoveStar_Click(object sender, EventArgs e)
        {
            // Проверка выбранного элемента в списке звезд текущей звездной системы
            if (listBoxStars2.SelectedIndex != -1)
            {
                // Добавление выбранной звезды в список свободных звезд
                listBoxStars1.Items.Add(listBoxStars2.SelectedItem);
                // Удаление выбранной звезды из списка звезд текущей звездной системы
                listBoxStars2.Items.Remove(listBoxStars2.SelectedItem);
            }
        }
        // Обработчик события нажатия кнопки для добавления планеты в звездную систему
        private void buttonAddPlanet_Click(object sender, EventArgs e)
        {
            if (listBoxPlanets1.SelectedIndex != -1)
            {
                listBoxPlanets2.Items.Add(listBoxPlanets1.SelectedItem);
                listBoxPlanets1.Items.Remove(listBoxPlanets1.SelectedItem);
            }
        }
        // Обработчик события нажатия кнопки для удаления планеты из звездной системы
        private void buttonRemovePlanet_Click(object sender, EventArgs e)
        {
            if (listBoxPlanets2.SelectedIndex != -1)
            {
                listBoxPlanets1.Items.Add(listBoxPlanets2.SelectedItem);
                listBoxPlanets2.Items.Remove(listBoxPlanets2.SelectedItem);
            }
        }
        // Обработчик события нажатия кнопки для добавления луны в звездную систему
        private void buttonAddMoon_Click(object sender, EventArgs e)
        {
            if (listBoxMoons1.SelectedIndex != -1)
            {
                listBoxMoons2.Items.Add(listBoxMoons1.SelectedItem);
                listBoxMoons1.Items.Remove(listBoxMoons1.SelectedItem);
            }

        }
        // Обработчик события нажатия кнопки для удаления луны из звездной системы
        private void buttonRemoveMoon_Click(object sender, EventArgs e)
        {
            if (listBoxMoons2.SelectedIndex != -1)
            {
                listBoxMoons1.Items.Add(listBoxMoons2.SelectedItem);
                listBoxMoons2.Items.Remove(listBoxMoons2.SelectedItem);
            }
        }

        // Обработчик события нажатия кнопки для сохранения данных о звездной системе
        private void buttonSaveStarSystem_Click(object sender, EventArgs e)
        {
            // Получение объекта звездной системы для изменения данных
            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];

            // Переменная для хранения сообщения об ошибке
            string message_if_wrong = "";

            // Проверка на уникальность имени объекта
            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObjectToChange.Name.ToLower() == spaceObject.Name & spaceObjectToChange.Name != systemName)
                {
                    message_if_wrong += "Объект с таким именем уже существует, измените имя объекта;";
                }
            }

            // Проверка наличия названия звездной системы
            if (string.IsNullOrEmpty(textBox1.Text) | textBox1.Text == "Не указано")
            {
                message_if_wrong += "\nИзмените название звездной системы;";
            }

            // Проверка выбора возраста звездной системы
            if ((long)numericUpDown1.Value == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст звездной системы;";
            }

            // Получение даты открытия звездной системы
            DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());

            // Если есть ошибки, вывод сообщения об ошибке
            if (message_if_wrong != "")
            {
                MessageBox.Show(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Формирование строки с информацией о звездной системе
                string star_system_str =
                    "Звездная система успешно создана: {0},\n" +
                    "Имя звездной системы: {0},\n" +
                    "Возраст системы: {1} лет,\n" +
                    "Дата открытия системы: {2}\n" +
                    "Звезды в составе системы: {3};\n" +
                    "Планеты в составе системы: {4};\n" +
                    "Луны в составе системы: {5};\n";

                // Списки для хранения выбранных звезд, планет и лун
                List<Star> tempStars = new List<Star>();
                List<Planet> tempPlanets = new List<Planet>();
                List<Moon> tempMoons = new List<Moon>();

                // Перебор элементов в списке выбранных звезд и добавление их в соответствующий список
                foreach (string item in listBoxStars2.Items)
                {
                    foreach (Star star in stars)
                    {
                        if (star.Name == item)
                        {
                            tempStars.Add(star);
                        }
                    }
                }

                // Перебор элементов в списке свободных звезд и удаление привязки к текущей звездной системе
                foreach (string item in listBoxStars1.Items)
                {
                    foreach (Star star in stars)
                    {
                        if (star.Name == item)
                        {
                            if (star.ParentStarSystem.Name == systemName)
                            {
                                star.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                    }
                }
                // Перебор элементов в списке выбранных планет и добавление их в соответствующий список

                foreach (Planet planet in planets)
                {
                    foreach (string item in listBoxPlanets2.Items)
                    {
                        if (planet.Name == item)
                        {
                            tempPlanets.Add(planet);
                        }
                    }
                }
                // Перебор элементов в списке свободных планет и удаление привязки к текущей звездной системе
                foreach (Planet planet in planets)
                {
                    foreach (string item in listBoxPlanets1.Items)
                    {

                        if (planet.Name == item)
                        {
                            if (planet.ParentStarSystem.Name == systemName)
                            {
                                planet.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                    }
                }
                // Перебор элементов в списке выбранных лун и добавление их в соответствующий список

                foreach (Moon moon in moons)
                {
                    foreach (string item in listBoxMoons2.Items)
                    {
                        if (moon.Name == item)
                        {
                            tempMoons.Add(moon);
                        }
                        else
                        {
                            if (moon.ParentStarSystem.Name == systemName)
                            {
                               moon.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                    }
                }
                // Перебор элементов в списке свободных лун и удаление привязки к текущей звездной системе
                foreach (Moon moon in moons)
                {
                    foreach (string item in listBoxMoons1.Items)
                    {
                        if (moon.Name == item)
                        {
                            if (moon.ParentStarSystem.Name == systemName)
                            {
                                moon.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                        
                    }
                }
                // Обновление данных о звездной системе
                foreach (StarSystem starSystem in starSystems)
                {
                    if (starSystem.Name == systemName)
                    {
                        starSystem.Name = textBox1.Text;
                        starSystem.Age = (long)numericUpDown1.Value;
                        starSystem.DateOfDiscovery = dateOfDiscovery;
                        starSystem.setPhoto((string)pictureBox1.Tag);
                        starSystem.updateChildrenLists(tempMoons, tempPlanets, tempStars);

                    }
                }
                // Обновление привязок и закрытие формы
                objects.ResetBindings();
                this.Close();
            }
            }
    }
}
