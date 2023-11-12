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
using System.Drawing.Design;

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

        BindingList<SpaceObject> objects = new BindingList<SpaceObject>(); // UpCasting()
        Star star_for_methods = new Star();

        //SpaceObject check_parent = new SpaceObject();
        Star check_star = new Star();
        Moon check_moon = new Moon();
        Planet check_planet = new Planet();
        //BindingList<StarSystem> temp_systems = new BindingList<StarSystem>(StarSystem.readFromFile()) { };
        public FormRegistration()
        {
            InitializeComponent();

            pictureBox2.Image = Properties.Resources.default_star_system;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


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

            /*
            star_for_methods.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            star_for_methods.SpaceObjectPhotoCheck += (string msg) =>
            {
                richTextBox1.AppendText($"Сработал динамический обработчик событий\n" +
                    $"Сообщение: {msg}\n");
            };

            star_for_methods.ObjectEventCheck += DisplayMessage;

            check_planet.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            */

            //check_planet.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            //star_for_methods
        }

        /*
        private static void DisplayMessage(object obj, AccountEventArgs e)
        {
            MessageBox.Show(String.Format($"Был создан объект со следующим сообщением: \n{e.Message}\n"));
        }*/


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

            //SpaceObject temp = new SpaceObject();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                message_if_empty += "\nОбязательно заполните название космического объекта";
            }
            else
            {
                //temp.Name = textBox1.Text;
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите возраст космического объекта";
            }
            else
            {
                //temp.setAge((long)numericUpDown1.Value);
            }

            //temp.SpaceObjectColor = ButtonChooseEyeColor.BackColor;
            //starSystem.CountStars = (int)numericUpDown2.Value;
            DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());
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
                if ((double)numericUpDownWeight.Value <= 0)
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
                if ((double)numericUpDownWeight.Value <= 0)
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
                //string photo_now = (string)pictureBox2.Tag;
                if (pictureBox2.Tag != null)
                {
                    //temp.Photo = (string)pictureBox2.Tag;

                }
                if (comboBox1.Text == "Звезда")
                {

                    Star newObject = new Star(textBox1.Text, (long)numericUpDown1.Value, dateOfDiscovery, ButtonChooseEyeColor.BackColor, (string)pictureBox2.Tag);

                    richTextBox1.AppendText(String.Format(star_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor));
                    objects.Add(newObject);
                    new_stars.Add(newObject);
                }
                else if (comboBox1.Text == "Планета")
                {
                    Planet newObject = new Planet(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, (double)numericUpDownAccelerationOfFreeFall.Value, dateOfDiscovery, ButtonChooseEyeColor.BackColor, (string)pictureBox2.Tag);
                    newObject.DateOfDiscovery = dateOfDiscovery;
                    richTextBox1.AppendText(String.Format(planet_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight, newObject.AccelerationOfFreeFall));

                    objects.Add(newObject);
                    new_planets.Add(newObject);
                }
                else if (comboBox1.Text == "Луна")
                {

                    Moon newObject = new Moon(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, dateOfDiscovery, ButtonChooseEyeColor.BackColor, (string)pictureBox2.Tag);
                    richTextBox1.AppendText(String.Format(moon_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight));

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



        private void addPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox2.Refresh();

                //star_for_methods.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
                //star_for_methods.setPhoto(openFileDialog1.FileName);
                star_for_methods.Photo = openFileDialog1.FileName;
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    if (comboBox1.Text == "Планета")
                    {
                        check_planet.setPhoto(openFileDialog1.FileName);
                        check_planet.showPhoto(pictureBox2);
                    }
                    else
                    {
                        star_for_methods.setPhoto(openFileDialog1.FileName);
                        star_for_methods.showPhoto(pictureBox2);
                    }
                }
                else { star_for_methods.showPhoto(pictureBox2); }

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

            this.dateTimePicker1.Text = DateTime.Now.ToString();
            this.textBox2.DataBindings.Add(new Binding("Text", objects, "Name"));
            this.numericUpDownAge.DataBindings.Add(new Binding("Value", objects, "Age"));

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

        private void button2_Click(object sender, EventArgs e)
        {
            //check_parent.print(richTextBox1);
            //star_for_methods.checkObjectHandler("Сообщение при нажатии на кнопку проверки Класса данных события");
            //ISpaceObjectsRegistration SpaceObjectName = new Star();
            //SpaceObjectName.Name;
            ISpaceObjectRegistration2 SpaceObjectInterface = new Star();
            SpaceObjectInterface.Photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\interface.jpg";
            SpaceObjectInterface.showPhoto(pictureBox2);
            //SpaceObjectInterface.
            richTextBox1.AppendText(((Star)SpaceObjectInterface).Name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;


            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                check_star.NameText(richTextBox1, fontDialog1.Font);

            }
            //MessageBox.Show(check_star.ToString());
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}