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

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {
        BindingList<StarSystem> systems = new BindingList<StarSystem>();
        public FormRegistration()
        {
            InitializeComponent();
            //this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            //this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            listBox1.DataSource = systems;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";

            this.dateTimePicker1.Text = DateTime.Now.ToString();
            this.textBox2.DataBindings.Add(new Binding("Text", systems, "Name"));
            this.numericUpDown3.DataBindings.Add(new Binding("Value", systems, "Age"));
            this.numericUpDown4.DataBindings.Add(new Binding("Text", systems, "CountStars"));
            this.dateTimePicker2.DataBindings.Add(new Binding("Value", systems, "DateOfDiscovery"));
            this.button1.DataBindings.Add(new Binding("BackColor", systems, "starColor"));


            pictureBox2.Image = Properties.Resources.default_star_system;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            StarSystem starSystem = new StarSystem();
            string message_if_empty = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                message_if_empty += "Обязательно заполните название звездной системы";
            }
            else
            {
                starSystem.Name = textBox1.Text;
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите возраст звездной системы";
            }
            else
            {
                starSystem.setAge((long)numericUpDown1.Value);
            }

            starSystem.starColor = ButtonChooseEyeColor.BackColor;
            starSystem.CountStars = (int)numericUpDown2.Value;
            starSystem.DateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());
            if (starSystem.getCountStars() == 0)
            {
                message_if_empty += "\nОбязательно введите количество звезд (больше 0)";
            }

            foreach (StarSystem system in systems)
            {
                if (system.Name.ToLower() == textBox1.Text.ToLower())
                {
                    message_if_empty += "\nДанное имя уже находится в списке";
                }
            }

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {
               

                string starSystem_str = "Звездная система: {0},\n" +
                    "Возраст главной звезды: {1} лет,\n" +
                    "Количество звезд в звездной системе: {2}\n" +
                    "Дата открытия системы: {3}\n" +
                    "Цвет звезды: {4}.\n=============================\n";

                if (pictureBox2.Tag != null)
                {
                    starSystem.Photo = (string)pictureBox2.Tag;
                }

                StarSystem starSystem_2 = new StarSystem();
                StarSystem starSystem_3 = new StarSystem(starSystem.Name, starSystem.getCountStars(), starSystem.Age, starSystem.DateOfDiscovery, starSystem.starColor, (string)pictureBox2.Tag);
                StarSystem starSystem_4 = new StarSystem(starSystem.Name);

                richTextBox1.AppendText(String.Format(starSystem_str, starSystem.Name, starSystem.Age, starSystem.getCountStars(), starSystem.DateOfDiscovery, starSystem.starColor));

                systems.Add(starSystem);

                listBox1.DataSource = null;
                listBox1.DataSource = systems;
                listBox1.DisplayMember = "Name";

                //textBox2.DataBindings.Add(new Binding("Text", systems, "Name"));

                //richTextBox1.ForeColor = StarSystem.AdditionalColor;
                //this.BackColor = StarSystem.additionalColor;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void ButtonMakePlanet_Click(object sender, EventArgs e)
        {
            Planet empty = new Planet();


            Planet Earth = new Planet("Солнце", 5.9736, 108.321, 9.78);

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


            richTextBox1.AppendText(String.Format(msg_default, empty.Name, empty.mass, empty.volume, empty.accelerationOfFreeFall));


            richTextBox1.AppendText(String.Format(msg_Earth, Earth.Name, Earth.mass, Earth.volume, Earth.accelerationOfFreeFall));

        }

        /*
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = systems;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StarSystem starSystemPhoto = new StarSystem("", openFileDialog1.FileName);
                pictureBox2.Image = null;
                pictureBox2.Update();
                starSystemPhoto.showPhoto(pictureBox2);
                
                pictureBox2.Tag = starSystemPhoto.Photo;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                StarSystem curSystem = (StarSystem)listBox1.SelectedItem;
                foreach (var item in systems)
                {

                    if (item.Name == curSystem.Name)
                    {
                        pictureBox3.Image = null;
                        pictureBox3.Update();
                        item.showPhoto(pictureBox3);
                        return;
                    }
                }
            }



        }

    }
}