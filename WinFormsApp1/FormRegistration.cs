using WinFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{

    public partial class FormRegistration : Form
    {
        List<Star> stars = new List<Star>(Star.readFromFile()) { };
        List<Planet> planets = new List<Planet>(Planet.readFromFile()) { };
        List<Moon> moons = new List<Moon>(Moon.readFromFile()) { };

        List<Star> new_stars = new List<Star>() { };
        List<Planet> new_planets = new List<Planet>() { };
        List<Moon> new_moons = new List<Moon>() { };

        BindingList<SpaceObject> objects = new BindingList<SpaceObject>();
        Star star_for_methods = new Star();

        SpaceObject check_parent = new SpaceObject();
        Star check_star = new Star();
        Moon check_moon = new Moon();
        Planet check_planet = new Planet();
        //BindingList<StarSystem> temp_systems = new BindingList<StarSystem>(StarSystem.readFromFile()) { };
        public FormRegistration()
        {
            InitializeComponent();

            pictureBox2.Image = Properties.Resources.default_star_system;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //pictureBox3.Image = Properties.Resources.default_star_system;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            // У родителя нет доступа к методу потомков
            //check_parent.writeToFile(); 

            MessageBox.Show(check_parent.ToString() + "\n"
                + check_planet.ToString() + "\n" + check_moon.ToString() + "\n" + check_star.ToString());

            SpaceObject check_star_UpCasting = (SpaceObject)check_star;
            //check_star_UpCasting.writeToFile();

            SpaceObject spaceObjectFromStar = new Star();
            Star check_star_DownCasting = (Star)spaceObjectFromStar;
            //check_star_DownCasting.writeToFile();

            MessageBox.Show(check_star_UpCasting.ToString() + "\n" + check_star_DownCasting.ToString());

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


        }


        private void ButtonChooseEyeColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = ButtonChooseEyeColor.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ButtonChooseEyeColor.BackColor = MyDialog.Color;

        }

        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            string message_if_empty = "";
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Выберите тип объекта");
                return;
            }

            SpaceObject temp = new SpaceObject();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                message_if_empty += "\nОбязательно заполните название космического объекта";
            }
            else
            {
                temp.Name = textBox1.Text;
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите возраст космического объекта";
            }
            else
            {
                temp.setAge((long)numericUpDown1.Value);
            }

            temp.SpaceObjectColor = ButtonChooseEyeColor.BackColor;
            //starSystem.CountStars = (int)numericUpDown2.Value;
            temp.DateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());
            /*if (starSystem.getCountStars() == 0)
            {
                message_if_empty += "\nОбязательно введите количество звезд (больше 0)";
            }*/

            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObject.Name.ToLower() == textBox1.Text.ToLower())
                {
                    message_if_empty += "\nДанное имя уже находится в списке";
                }
            }

            if (comboBox1.Text == "Планета")
            {
                if ((double)numericUpDownWeight.Value < 1)
                {
                    message_if_empty += "\nДобавьте массу для планеты";
                }
                if ((double)numericUpDownAccelerationOfFreeFall.Value <= 0)
                {
                    message_if_empty += "\nДобавьте ускорение свободного падения для планеты";
                }
            }
            else if (comboBox1.Text == "Луна")
            {
                if ((double)numericUpDownWeight.Value < 1)
                {
                    message_if_empty += "\nДобавьте массу для луны";
                }
            }

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {

                string star_str = "Имя звезды: {0},\n" +
                    "Возраст звезды: {1} лет,\n" +
                    "Дата открытия звезды: {2}\n" +
                    "Цвет звезды: {3}." +
                    "\n=============================\n";
                string planet_str = "Имя планеты: {0},\n" +
                    "Возраст планеты: {1} лет,\n" +
                    "Дата открытия планеты: {2}\n" +
                    "Цвет планеты: {3}.\n" +
                    "Вес планеты: {4} 10^24 кг." +
                    "Ускорение свободного падения: {5} м/с^2.\n" +
                    "\n=============================\n";
                string moon_str = "Имя планеты: {0},\n" +
                    "Возраст планеты: {1} лет,\n" +
                    "Дата открытия планеты: {2}\n" +
                    "Цвет планеты: {3}.\n" +
                    "Вес планеты: {4} кг." +
                    "\n=============================\n";
                if (pictureBox2.Tag != null)
                {
                    temp.Photo = (string)pictureBox2.Tag;
                }
                if (comboBox1.Text == "Звезда")
                {

                    Star newObject = new Star(temp.Name, temp.Age, temp.DateOfDiscovery, temp.SpaceObjectColor, temp.Photo);
                    richTextBox1.AppendText(String.Format(star_str, newObject.Name, newObject.Age, newObject.DateOfDiscovery, newObject.SpaceObjectColor));
                    objects.Add(newObject);
                    new_stars.Add(newObject);
                }
                else if (comboBox1.Text == "Планета")
                {
                    Planet newObject = new Planet(temp.Name, temp.Age, (double)numericUpDownWeight.Value, (double)numericUpDownAccelerationOfFreeFall.Value, temp.DateOfDiscovery, temp.SpaceObjectColor, temp.Photo);
                    richTextBox1.AppendText(String.Format(planet_str, newObject.Name, newObject.Age, newObject.DateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight, newObject.AccelerationOfFreeFall));

                    objects.Add(newObject);
                    new_planets.Add(newObject);
                }
                else if (comboBox1.Text == "Луна")
                {

                    Moon newObject = new Moon(temp.Name, temp.Age, (double)numericUpDownWeight.Value, temp.DateOfDiscovery, temp.SpaceObjectColor, temp.Photo);
                    richTextBox1.AppendText(String.Format(moon_str, newObject.Name, newObject.Age, newObject.DateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight));

                    objects.Add(newObject);
                    new_moons.Add(newObject);
                }


                //richTextBox1.AppendText(String.Format(starSystem_str, temp.Name, temp.Age, temp.DateOfDiscovery, temp.SpaceObjectColor));

                //objects.Add(new_object);
                //new_systems.Add(starSystem);

            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        /*
        private void ButtonMakePlanet_Click(object sender, EventArgs e)
        {
            //Planet empty = new Planet();


            //Planet Earth = new Planet("Солнце", 5.9736, 108.321, 9.78);

            //Planet Earth;
            //Earth.name = "Основы программирования";
            //Earth.mass = 85;
            //Earth.volume = 3;
            //Earth.accelerationOfFreeFall = 9.78;

            string msg_default = "Конструктор по умолчанию:\n" +
                "Название планеты: {0}\n" +
                "Масса планеты: {1} (10^24 кг)\n" +
                "Объем планеты: {2} (10^10 км^3)\n" +
                "Ускорение свободного падения: {3} (м/с^2)\n************************\n";

            string msg_Earth = "Перегруженный конструктор:\n" +
                "Название планеты: {0}\n" +
                "Масса планеты: {1} (10^24 кг)\n" +
                "Объем планеты: {2} (10^10 км^3)\n" +
                "Ускорение свободного падения: {3} (м/с^2)\n************************\n";


            //richTextBox1.AppendText(String.Format(msg_default, empty.Name, empty.mass, empty.volume, empty.accelerationOfFreeFall));


            //richTextBox1.AppendText(String.Format(msg_Earth, Earth.Name, Earth.mass, Earth.volume, Earth.accelerationOfFreeFall));

        }*/


        private void addPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox2.Refresh();
                //starSystemPhoto.writeToFile(openFileDialog1);
                star_for_methods.Photo = openFileDialog1.FileName;
                star_for_methods.showPhoto(pictureBox2);
                pictureBox2.Tag = openFileDialog1.FileName;
            }
        }

        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string themePhoto = saveFileDialog1.FileName;
                Star temp = new Star();
                //pictureBox2.Image = null;
                //pictureBox2.Update();
                pictureBox2.Refresh();
                temp.showPhoto(Form.ActiveForm, themePhoto);
                temp.writeToFile(saveFileDialog1);

                //groupBox1.BackColor = Color.White;

            }
        }


        private void FormRegistration_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = objects;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";

            /*
            pictureBox2.Image = Properties.Resources.default_star_system;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //pictureBox3.Image = Properties.Resources.default_star_system;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            */
            this.dateTimePicker1.Text = DateTime.Now.ToString();
            this.textBox2.DataBindings.Add(new Binding("Text", objects, "Name"));
            this.numericUpDownAge.DataBindings.Add(new Binding("Value", objects, "Age"));
            //this.numericUpDown4.DataBindings.Add(new Binding("Text", systems, "CountStars"));
            this.dateTimePicker2.DataBindings.Add(new Binding("Value", objects, "DateOfDiscovery"));
            this.button1.DataBindings.Add(new Binding("BackColor", objects, "SpaceObjectColor"));
            this.pictureBox3.DataBindings.Add(new Binding("Image", objects, "Img"));
            this.textBox3.DataBindings.Add(new Binding("Text", objects, "Type"));


        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {

            //MessageBox.Show(starSystem.Name);
            foreach (Star star in new_stars)
            {
                star.writeToFile();
            }
            foreach (Moon moon in new_moons)
            {
                moon.writeToFile();
            }
            foreach (Planet planet in new_planets)
            {
                planet.writeToFile();

            }
            //MessageBox.Show("За всё время было добавлено: " + StarSystem.readFromFile(saveFileDialog1).ToString() + " фонов." + "\n" +
            //    "За всё время было добавлено: " + StarSystem.readFromFile(openFileDialog1).ToString() + " фотографий космических объектов.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedValue.ToString();
            string msg_add_info = "Дополнительная информация по объекту: ";
            foreach (Planet planet in planets)
            {
                if (planet.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + planet.getStringWithAdditionalInfo());
                }
            }
            foreach (Planet planet in new_planets)
            {
                if (planet.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + planet.getStringWithAdditionalInfo());
                }
            }
            foreach (Moon moon in moons)
            {
                if (moon.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + moon.getStringWithAdditionalInfo());
                }
            }
            foreach (Moon moon in new_moons)
            {
                if (moon.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + moon.getStringWithAdditionalInfo());
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selected = this.comboBox1.Text;

            if (selected == "Планета")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.labelAccelerationOfFreeFall.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = true;
            }
            else if (selected == "Звезда")
            {
                this.labelWeight.Visible = false;
                this.numericUpDownWeight.Visible = false;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
            else if (selected == "Луна")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
        }
    }
}