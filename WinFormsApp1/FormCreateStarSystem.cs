using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormCreateStarSystem : Form
    {
        // Получение доступа к спискам объектов из главной формы
        List<Moon> moons = FormListOfObjects.instance.moons;
        List<Planet> planets = FormListOfObjects.instance.planets;
        List<Star> stars = FormListOfObjects.instance.stars;

        // Списки свободных (непривязанных к звездной системе) лун, планет и звезд
        public List<Moon> freeMoons = new List<Moon>() { };
        public List<Planet> freePlanets = new List<Planet>() { };
        public List<Star> freeStars = new List<Star>() { };
        // Список звездных систем
        List<StarSystem> starSystems = FormListOfObjects.instance.starSystems;
        // Список всех космических объектов
        BindingList<SpaceObject> objects = FormListOfObjects.instance.objects;
        // Конструктор формы
        public FormCreateStarSystem()
        {
            InitializeComponent();
            // Настройка отображения изображений в PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.default_star_system;
            // Обновление списков свободных объектов
            updateFreeObjectsLists(moons, planets, stars, freeMoons, freePlanets, freeStars);
            // Заполнение списков свободных звезд, планет и лун в ListBox'ах
            foreach (Star star in freeStars)
            {
                listBoxStars1.Items.Add(star.Name);
            }
            foreach (Planet planet in freePlanets)
            {
                listBoxPlanets1.Items.Add(planet.Name);
            }
            foreach (Moon moon in freeMoons)
            {
                listBoxMoons1.Items.Add(moon.Name);
            }
        }
        // Метод для обновления списков свободных объектов
        private void updateFreeObjectsLists(List<Moon> moons, List<Planet> planets, List<Star> stars, List<Moon> freeMoons, List<Planet> freePlanets, List<Star> freeStars)
        {
            foreach (Moon moon in moons)
            {
                if (moon.ParentStarSystem.Name == "Не указано")
                {
                    freeMoons.Add(moon);
                }
            }
            foreach (Planet planet in planets)
            {
                if (planet.ParentStarSystem.Name == "Не указано")
                {
                    freePlanets.Add(planet);
                }
            }
            foreach (Star star in stars)
            {
                if (star.ParentStarSystem.Name == "Не указано")
                {
                    freeStars.Add(star);
                }
            }
        }
        // Обработчик события нажатия кнопки "Добавить фото"
        private void addPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Refresh();

                Moon tempObject = new Moon();
                tempObject.setPhoto(openFileDialog1.FileName);
                tempObject.showPhoto(pictureBox1);

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
        // Обработчик события нажатия кнопки "Создать звездную систему"
        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            // Переменная для хранения сообщения об ошибках
            string message_if_wrong = "";
            // Проверка введенных данных для создания звездной системы
            if (string.IsNullOrEmpty(textBox1.Text) | textBox1.Text == "Не указано")
            {
                message_if_wrong += "\nИзмените название звездной системы;";
            }
            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObject.Name.ToLower() == textBox1.Text.ToLower())
                {
                    message_if_wrong += "\nДанное имя уже находится в списке;";
                }
            }
            if ((long)numericUpDown1.Value == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст звездной системы;";
            }

            DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());

            // Вывод сообщения об ошибках, если они есть
            if (message_if_wrong != "")
            {
                MessageBox.Show(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Строка для сообщения об успешном создании звездной системы
                string star_system_str =
                "Звездная система успешно создана: {0},\n" +
                "Имя звездной системы: {0},\n" +
                "Возраст системы: {1} лет,\n" +
                "Дата открытия системы: {2}\n" +
                "Звезды в составе системы: {3};\n" +
                "Планеты в составе системы: {4};\n" +
                "Луны в составе системы: {5};\n";
                // Списки звезд, планет и лун для новой звездной системы
                List<Star> tempStars = new List<Star>();
                List<Planet> tempPlanets = new List<Planet>();
                List<Moon> tempMoons = new List<Moon>();
                // Проверка и добавление выбранных звезд в состав системы
                foreach (Star star in stars)
                {
                    foreach (string item in listBoxStars2.Items)
                    {
                        if (star.Name == item)
                        {
                            tempStars.Add(star);
                        }
                    }
                }
                // Проверка и добавление выбранных планет в состав системы
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
                // Проверка и добавление выбранных лун в состав системы
                foreach (Moon moon in moons)
                {
                    foreach (string item in listBoxMoons2.Items)
                    {
                        if (moon.Name == item)
                        {
                            tempMoons.Add(moon);
                        }
                    }
                }
                // Создание новой звездной системы
                StarSystem newObject = new StarSystem(textBox1.Text, (long)numericUpDown1.Value, dateOfDiscovery, (string)pictureBox1.Tag, tempMoons, tempPlanets, tempStars);
                
                // Вывод сообщения об успешном создании звездной системы
                MessageBox.Show(String.Format(star_system_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.Join(",", newObject.ChildrenStars), newObject.Join(",", newObject.ChildrenPlanets), newObject.Join(",", newObject.ChildrenMoons)), "Звездная система успешно создана");
                
                // Добавление новой звездной системы в списки и обновление отображаемого списка объектов
                objects.Add(newObject);
                starSystems.Add(newObject);
                objects.ResetBindings();
            }
        }
    }
}

