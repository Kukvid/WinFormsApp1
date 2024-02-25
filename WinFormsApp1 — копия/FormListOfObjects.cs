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
        public List<Moon> moons = new List<Moon>(Moon.readFromFile()) { };
        public List<Planet> planets = new List<Planet>(Planet.readFromFile()) { };
        public List<Star> stars = new List<Star>(Star.readFromFile()) { };


        public List<StarSystem> starSystems = new List<StarSystem>(StarSystem.readFromFile()) { };


        public BindingList<SpaceObject> objects = new BindingList<SpaceObject>(); // UpCasting


        public static FormListOfObjects instance;
        public FormListOfObjects()
        {
            instance = this;
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            updateObjectsLists(moons, planets, stars, starSystems, objects);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCreateSpaceObject formCreateSpacObject = new FormCreateSpaceObject();
            formCreateSpacObject.ShowDialog();
        }
        private void updateObjectsLists(List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems, BindingList<SpaceObject> objects)
        {

            foreach (StarSystem starSystem in starSystems)
            {
                objects.Add((SpaceObject)starSystem);
            }
            foreach (Star star in stars)
            {
                objects.Add((SpaceObject)star);
            }
            foreach (Planet planet in planets)
            {
                objects.Add((SpaceObject)planet);
            }
            foreach (Moon moon in moons)
            {
                objects.Add((SpaceObject)moon);
            }

            foreach (Moon moon in moons)
            {
                moon.LinkWithParent(starSystems);
            }
            foreach (Planet planet in planets)
            {
                planet.LinkWithParent(starSystems);
            }
            foreach (Star star in stars)
            {
                star.LinkWithParent(starSystems);
            }
            foreach (StarSystem starSystem in starSystems)
            {
                starSystem.LinkWithChildren(moons, planets, stars);
            }
        }
        private void FormListOfObjects_Load(object sender, EventArgs e)
        {

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

        private void FormListOfObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(SpaceObject.spaceObjectsPath, string.Empty);
            foreach (Moon moon in moons) { moon.writeToFile(); }
            foreach (Planet planet in planets) { planet.writeToFile(); }
            foreach (Star star in stars) { star.writeToFile(); }
            foreach (StarSystem starSystem in starSystems) { starSystem.writeToFile(); }
        }
        private void deleteSpaceObjectFromLists(string objectName, List<Moon> moons, List<Planet> planets, List<Star> stars, List<StarSystem> starSystems, BindingList<SpaceObject> objects)
        {
            for (int i = 0; i < moons.Count; i++)
            {
                if (moons[i].Name == objectName)
                {
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
                    moons.RemoveAt(i);

                }
            }
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
            objects.RemoveAt(listBox1.SelectedIndex);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string objectName = listBox1.SelectedValue.ToString();
                DialogResult AnswerResult = MessageBox.Show($"Вы действительно хотите удалить {objects[listBox1.SelectedIndex].Name} из списка объектов?", "Удаление объекта", MessageBoxButtons.YesNo);
                if (AnswerResult == DialogResult.Yes)
                {
                    deleteSpaceObjectFromLists(objectName, moons, planets, stars, starSystems, objects);
                    MessageBox.Show("Объект успешно удалён!", "Удаление объекта");
                }
            }
            else
            {
                MessageBox.Show("Для удаления объекта вы должны выбрать его в списке!", "Удаление объекта");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int objectIndex = listBox1.SelectedIndex;
                MessageBox.Show(objects[objectIndex].AdditionalInfo, "Дополнительная информация");
            }
            else
            {
                MessageBox.Show("Для получения дополнительной информации об объекте вы должны выбрать его в списке!", "Дополнительная информация");
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
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

        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            FormCreateStarSystem formCreateStarSystem = new FormCreateStarSystem();
            formCreateStarSystem.ShowDialog();
        }
        private int checkType(string type)
        {
            Dictionary<string, int> Types = new Dictionary<string, int>() {
                {"Луна", 0},
                {"Планета", 1},
                {"Звезда", 2},
                {"Звездная система", 3},
            };
            return Types[type];
        }
    }
}
