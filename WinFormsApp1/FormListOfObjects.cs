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

namespace WinFormsApp1
{
    public partial class FormListOfObjects : Form
    {
        myStruct structura = new myStruct();
        // Списки для хранения лун, планет, звезд и звездных систем
        public List<Moon> moons = new List<Moon>(Moon.readFromFile()) { };
        public List<Planet> planets = new List<Planet>(Planet.readFromFile()) { };
        public List<Star> stars = new List<Star>(Star.readFromFile()) { };
        public List<StarSystem> starSystems = new List<StarSystem>(StarSystem.readFromFile()) { };

        // Список связанных объектов для отображения в списке формы
        public BindingList<SpaceObject> objects = new BindingList<SpaceObject>(); // UpCasting

        // Статическая переменная для доступа к форме из других частей приложения
        public static FormListOfObjects instance;
        // Конструктор формы
        public FormListOfObjects()
        {
            // Инициализация формы
            instance = this;
            InitializeComponent();
            // Настройка отображения изображений в PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Обновление списков объектов
            updateObjectsLists(moons, planets, stars, starSystems, objects);
            myStruct mst = new myStruct();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // При нажатии на кнопку открывается форма создания луны, планеты или звезды
        private void buttonCreateSpaceObject_Click(object sender, EventArgs e)
        {
            FormCreateSpaceObject formCreateSpacObject = new FormCreateSpaceObject();
            formCreateSpacObject.ShowDialog();
        }
        // Метод обновления списков объектов
        private void updateObjectsLists(List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems, BindingList<SpaceObject> objects)
        {
            // Добавление звездных систем в список объектов
            foreach (StarSystem starSystem in starSystems)
            {
                objects.Add((SpaceObject)starSystem);
            }
            // Добавление звезд в список объектов
            foreach (Star star in stars)
            {
                objects.Add((SpaceObject)star);
            }
            // Добавление планет в список объектов
            foreach (Planet planet in planets)
            {
                objects.Add((SpaceObject)planet);
            }
            // Добавление лун в список объектов
            foreach (Moon moon in moons)
            {
                objects.Add((SpaceObject)moon);
            }
            // Связывание лун с их родительскими звездными системами
            foreach (Moon moon in moons)
            {
                moon.linkWithParent(starSystems);
            }
            // Связывание планет с их родительскими звездными системами
            foreach (Planet planet in planets)
            {
                planet.LinkWithParent(starSystems);
            }
            // Связывание звезд с их родительскими звездными системами

            foreach (Star star in stars)
            {
                star.LinkWithParent(starSystems);
            }
            // Связывание звездных систем с их дочерними объектами (лунами, планетами, звездами)
            foreach (StarSystem starSystem in starSystems)
            {
                starSystem.linkWithChildren(moons, planets, stars);
            }
        }
        // Обработчик события загрузки формы
        private void FormListOfObjects_Load(object sender, EventArgs e)
        {
            // Привязка списка объектов к элементам управления формы
            listBox1.DataSource = objects;
            listBox1.DisplayMember = "NameWithType";
            listBox1.ValueMember = "Name";

            this.textBox2.DataBindings.Add(new Binding("Text", objects, "Name"));
            this.numericUpDownAge.DataBindings.Add(new Binding("Value", objects, "Age"));

            this.dateTimePicker2.DataBindings.Add(new Binding("Value", objects, "DateOfDiscovery"));
            this.button1.DataBindings.Add(new Binding("BackColor", objects, "SpaceObjectColor"));
            this.pictureBox1.DataBindings.Add(new Binding("Image", objects, "Img"));

            this.textBox3.DataBindings.Add(new Binding("Text", objects, "Type"));
        }
        // Обработчик события закрытия формы
        private void FormListOfObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Очистка файлов с данными перед сохранением
            File.WriteAllText(SpaceObject.spaceObjectsPath, string.Empty);
            foreach (Moon moon in moons) { moon.writeToFile(); }
            foreach (Planet planet in planets) { planet.writeToFile(); }
            foreach (Star star in stars) { star.writeToFile(); }
            foreach (StarSystem starSystem in starSystems) { starSystem.writeToFile(); }
        }
        // Метод удаления объекта из списков
        private void deleteSpaceObjectFromLists(string objectName, List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems, BindingList<SpaceObject> objects)
        {
            // Поиск и удаление луны из списка лун
            for (int i = 0; i < moons.Count; i++)
            {
                if (moons[i].Name == objectName)
                {
                    // Если луна привязана к звездной системе, обновление списка дочерних лун в родительской звездной системе
                    if (moons[i].ParentStarSystem.Name != "Не указано")
                    {
                        Moon moonNow = moons[i];
                        StarSystem parentStarSystem = moonNow.ParentStarSystem;
                        parentStarSystem.ChildrenMoons.Remove(moonNow);
                        if (parentStarSystem.ChildrenMoons.Count == 0)
                        {
                            parentStarSystem.ChildrenMoons.Add(new Moon("Не указано"));
                        }
                    }
                    // Удаление луны из списка лун
                    moons.RemoveAt(i);

                }
            }
            // Аналогичные операции для планет, звезд и звездных систем
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == objectName)
                {
                    if (planets[i].ParentStarSystem.Name != "Не указано")
                    {
                        Planet planetNow = planets[i];
                        StarSystem parentStarSystem = planetNow.ParentStarSystem;
                        parentStarSystem.ChildrenPlanets.Remove(planetNow);
                        if (parentStarSystem.ChildrenPlanets.Count == 0)
                        {
                            parentStarSystem.ChildrenPlanets.Add(new Planet("Не указано"));
                        }
                    }
                    planets.RemoveAt(i);
                }
            }
            for (int i = 0; i < stars.Count; i++)
            {

                if (stars[i].Name == objectName)
                {
                    if (stars[i].ParentStarSystem.Name != "Не указано")
                    {
                        Star starNow = stars[i];
                        StarSystem parentStarSystem = starNow.ParentStarSystem;
                        parentStarSystem.ChildrenStars.Remove(starNow);
                        if (parentStarSystem.ChildrenStars.Count == 0)
                        {
                            parentStarSystem.ChildrenStars.Add(new Star("Не указано"));
                        }
                    }
                    stars.RemoveAt(i);
                }
            }
            for (int i = 0; i < starSystems.Count; i++)
            {

                if (starSystems[i].Name == objectName)
                {
                    foreach (Moon moon in moons)
                    {
                        moon.ParentStarSystem = new StarSystem("Не указано");
                    }
                    foreach (Planet planet in planets)
                    {
                        planet.ParentStarSystem = new StarSystem("Не указано");
                    }
                    foreach (Star star in stars)
                    {
                        star.ParentStarSystem = new StarSystem("Не указано");
                    }
                    starSystems.RemoveAt(i);
                }
            }
            // Обновление отображаемого списка объектов
            objects.RemoveAt(listBox1.SelectedIndex);
        }
        // Обработчик события нажатия кнопки удаления объекта
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверка выбранного объекта в списке
            if (listBox1.SelectedIndex != -1)
            {
                string objectName = listBox1.SelectedValue.ToString();
                // Запрос подтверждения удаления
                DialogResult AnswerResult = MessageBox.Show($"Вы действительно хотите удалить {objects[listBox1.SelectedIndex].Name} из списка объектов?", "Удаление объекта", MessageBoxButtons.YesNo);
                // Удаление объекта при положительном ответе пользователя
                if (AnswerResult == DialogResult.Yes)
                {
                    deleteSpaceObjectFromLists(objectName, moons, planets, stars, starSystems, objects);
                    // Обновление отображаемого списка объектов
                    objects.ResetBindings();
                    MessageBox.Show("Объект успешно удалён!", "Удаление объекта");
                }
            }
            else
            {
                MessageBox.Show("Для удаления объекта вы должны выбрать его в списке!", "Удаление объекта");
            }
        }
        // Обработчик события нажатия кнопки "Дополнительная информация"
        private void button4_Click(object sender, EventArgs e)
        {
            // Проверка выбранного объекта в списке
            if (listBox1.SelectedIndex != -1)
            {
                int objectIndex = listBox1.SelectedIndex;
                // Отображение дополнительной информации о выбранном объекте
                MessageBox.Show(objects[objectIndex].AdditionalInfo, "Дополнительная информация");
            }
            else
            {
                MessageBox.Show("Для получения дополнительной информации об объекте вы должны выбрать его в списке!", "Дополнительная информация");
            }
        }
        // Обработчик события двойного клика по объекту в списке
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Проверка выбранного объекта в списке
            if (listBox1.SelectedIndex != -1)
            {
                // Открытие формы изменения данных объекта или звездной системы в зависимости от типа объекта
                if (objects[listBox1.SelectedIndex].ToString() == "Звездная система")
                {
                    FormChangeDataStarSystem formChangeDataStarSystem = new FormChangeDataStarSystem();
                    formChangeDataStarSystem.ShowDialog();
                }
                else
                {
                    FormChangeDataOfObject formChangeDataOfObject = new FormChangeDataOfObject();
                    formChangeDataOfObject.ShowDialog();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Обработчик события нажатия кнопки "Создать звездную систему"
        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            // Открытие формы создания новой звездной системы
            FormCreateStarSystem formCreateStarSystem = new FormCreateStarSystem();
            formCreateStarSystem.ShowDialog();
        }
    }
}
