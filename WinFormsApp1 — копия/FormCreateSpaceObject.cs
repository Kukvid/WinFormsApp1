using System;
using System.CodeDom.Compiler;
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
    public partial class FormCreateSpaceObject : Form
    {
        List<Moon> moons = FormListOfObjects.instance.moons;
        List<Planet> planets = FormListOfObjects.instance.planets;
        List<Star> stars = FormListOfObjects.instance.stars;

        BindingList<SpaceObject> objects = FormListOfObjects.instance.objects;
        public FormCreateSpaceObject()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.default_star_system;
        }

        private void buttonCreateSpaceObject_Click(object sender, EventArgs e)
        {
            string message_if_wrong = "";
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                message_if_wrong += "\nВыберите тип объекта;";
            }

            if (string.IsNullOrEmpty(textBox1.Text) | textBox1.Text == "Не указано")
            {
                message_if_wrong += "\nИзмените название космического объекта;";
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
                message_if_wrong += "\nОбязательно выберите возраст космического объекта;";
            }

            DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());


            if (comboBox1.Text == "Планета")
            {
                if ((double)numericUpDownWeight.Value <= 0)
                {
                    message_if_wrong += "\nДобавьте массу для планеты;";
                }
                if ((double)numericUpDownAccelerationOfFreeFall.Value <= 0)
                {
                    message_if_wrong += "\nДобавьте ускорение свободного падения для планеты;";
                }
            }
            else if (comboBox1.Text == "Луна")
            {
                if ((double)numericUpDownWeight.Value <= 0)
                {
                    message_if_wrong += "\nДобавьте массу для луны;";
                }
            }

            if (message_if_wrong != "")
            {
                MessageBox.Show(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {

                string star_str =
                    "Успешно создана звезда\n" +
                    "Имя звезды: {0},\n" +
                    "Возраст звезды: {1} лет,\n" +
                    "Дата открытия звезды: {2}\n" +
                    "Цвет звезды: {3}.";
                string planet_str = "Успешно создана планета\n" +
                    "Имя планеты: {0},\n" +
                    "Возраст планеты: {1} лет,\n" +
                    "Дата открытия планеты: {2}\n" +
                    "Цвет планеты: {3}.\n" +
                    "Масса планеты: {4} 10^24 кг.\n" +
                    "Ускорение свободного падения: {5} м/с^2.\n";
                string moon_str = "Успешно создана луна\n" +
                    "Имя луны: {0},\n" +
                    "Возраст луны: {1} лет,\n" +
                    "Дата открытия луны: {2}\n" +
                    "Цвет луны: {3}.\n" +
                    "Масса луны: {4} кг.";
                if (comboBox1.Text == "Звезда")
                {

                    Star newObject = new Star(textBox1.Text, (long)numericUpDown1.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox1.Tag);

                    MessageBox.Show(String.Format(star_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor), "Космический объект успешно создан");

                    objects.Add(newObject);
                    stars.Add(newObject);
                }
                else if (comboBox1.Text == "Планета")
                {
                    Planet newObject = new Planet(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, (double)numericUpDownAccelerationOfFreeFall.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox1.Tag);
                    newObject.DateOfDiscovery = dateOfDiscovery;

                    MessageBox.Show(String.Format(planet_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight, newObject.AccelerationOfFreeFall), "Космический объект успешно создан");

                    objects.Add(newObject);
                    planets.Add(newObject);

                }
                else if (comboBox1.Text == "Луна")
                {

                    Moon newObject = new Moon(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox1.Tag);
                    MessageBox.Show(String.Format(moon_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight), "Космический объект успешно создан");

                    objects.Add(newObject);
                    moons.Add(newObject);
                }
                FormListOfObjects.instance.objects.ResetBindings();
            }
        }

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
        private void ButtonChooseObjectColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = ButtonChooseObjectColor.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ButtonChooseObjectColor.BackColor = MyDialog.Color;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
