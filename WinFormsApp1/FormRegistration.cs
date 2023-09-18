using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
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
                starSystem.name = textBox1.Text;
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите возраст звездной системы";
            }
            else
            {
                starSystem.age = (long)numericUpDown1.Value;
            }

            starSystem.starColor = ButtonChooseEyeColor.BackColor;

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {
                string starSystem_str = "Звездная система: {0},\n" +
                    "Возраст главной звезды: {1},\n" +
                    "Цвет звезды: {2}.\n=============================\n";

                StarSystem starSystem_2 = new StarSystem();
                StarSystem starSystem_3 = new StarSystem(starSystem.name, starSystem.age, starSystem.starColor);
                StarSystem starSystem_4 = new StarSystem(starSystem.name);

                richTextBox1.AppendText(String.Format(starSystem_str, starSystem.name, starSystem.age, starSystem.starColor));
                richTextBox1.ForeColor = StarSystem.additionalColor;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void ButtonMakePlanet_Click(object sender, EventArgs e)
        {
            Planet empty = new Planet();


            Planet Earth = new Planet("Земля", 6, 3, 9.78);

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

            richTextBox1.AppendText(String.Format(msg_default, empty.name, empty.mass, empty.volume, empty.accelerationOfFreeFall));


            richTextBox1.AppendText(String.Format(msg_Earth, Earth.name, Earth.mass, Earth.volume, Earth.accelerationOfFreeFall));

        }



    }
}
