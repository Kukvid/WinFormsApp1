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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormChangeDataOfObject : Form
    {
        List<Moon> moons = FormListOfObjects.instance.moons;
        List<Planet> planets = FormListOfObjects.instance.planets;
        List<Star> stars = FormListOfObjects.instance.stars;
        BindingList<SpaceObject> objects = FormListOfObjects.instance.objects;
        string nowObjectName = string.Empty;
        public FormChangeDataOfObject()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];
            nowObjectName = spaceObjectToChange.Name;
            pictureBox1.Image = spaceObjectToChange.Img;
            pictureBox1.Tag = spaceObjectToChange.Photo;

            textBox1.Text = spaceObjectToChange.Name;
            numericUpDown1.Value = spaceObjectToChange.Age;
            textBox2.Text = spaceObjectToChange.ToString();
            dateTimePicker1.Value = spaceObjectToChange.DateOfDiscovery;
            ButtonChooseObjectColor.BackColor = spaceObjectToChange.SpaceObjectColor;

            if (textBox2.Text == "Планета")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.labelAccelerationOfFreeFall.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = true;
                foreach (Planet planet in planets)
                {
                    if (planet.Name == spaceObjectToChange.Name)
                    {
                        numericUpDownWeight.Value = (decimal)planet.Weight;
                        numericUpDownAccelerationOfFreeFall.Value = (decimal)planet.AccelerationOfFreeFall;
                    }
                }
            }
            else if (textBox2.Text == "Звезда")
            {
                this.labelWeight.Visible = false;
                this.numericUpDownWeight.Visible = false;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
            else if (textBox2.Text == "Луна")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
                foreach (Moon moon in moons)
                {
                    if (moon.Name == spaceObjectToChange.Name)
                    {
                        numericUpDownWeight.Value = (decimal)moon.Weight;
                    }
                }
            }


        }

        private void FormChangeDataOfObject_Load(object sender, EventArgs e)
        {


        }

        private void buttonChangeDataOfSpaceObject_Click(object sender, EventArgs e)
        {
            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];
            string message_if_wrong = "";

            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObjectToChange.Name.ToLower() == spaceObject.Name & spaceObjectToChange.Name != nowObjectName)
                {
                    message_if_wrong += "Объект с таким именем уже сущестувет, измените имя объекта;";
                }
            }

            if (string.IsNullOrEmpty(textBox1.Text) | textBox1.Text == "Не указано")
            {
                message_if_wrong += "\nИзмените название космического объекта;";
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст космического объекта;";
            }

            if (textBox2.Text == "Планета")
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
            else if (textBox2.Text == "Луна")
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
                DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());
                spaceObjectToChange.Name = textBox1.Text;
                spaceObjectToChange.Age = (long)numericUpDown1.Value;
                spaceObjectToChange.DateOfDiscovery = dateOfDiscovery;
                spaceObjectToChange.SpaceObjectColor = ButtonChooseObjectColor.BackColor;
                spaceObjectToChange.setPhoto((string)pictureBox1.Tag);
                if (spaceObjectToChange.ToString() == "Звезда")
                {
                    foreach (Star star in stars)
                    {
                        if (star.Name == nowObjectName)
                        {
                            star.Name = textBox1.Text;
                            star.Age = (long)numericUpDown1.Value;
                            star.DateOfDiscovery = dateOfDiscovery;
                            star.SpaceObjectColor = ButtonChooseObjectColor.BackColor;
                            star.setPhoto((string)pictureBox1.Tag);
                        }
                    }
                }
                else if (spaceObjectToChange.ToString() == "Планета")
                {
                    foreach (Planet planet in planets)
                    {
                        if (planet.Name == nowObjectName)
                        {
                            planet.Name = textBox1.Text;
                            planet.Age = (long)numericUpDown1.Value;
                            planet.DateOfDiscovery = dateOfDiscovery;
                            planet.SpaceObjectColor = ButtonChooseObjectColor.BackColor;
                            planet.Weight = (double)numericUpDownWeight.Value;
                            planet.AccelerationOfFreeFall = (double)numericUpDownAccelerationOfFreeFall.Value;
                            planet.setPhoto((string)pictureBox1.Tag);
                        }
                    }
                }
                else if (spaceObjectToChange.ToString() == "Луна")
                {
                    foreach (Moon moon in moons)
                    {
                        if (moon.Name == nowObjectName)
                        {
                            moon.Name = textBox1.Text;
                            moon.Age = (long)numericUpDown1.Value;
                            moon.DateOfDiscovery = dateOfDiscovery;
                            moon.SpaceObjectColor = ButtonChooseObjectColor.BackColor;
                            moon.Weight = (double)numericUpDownWeight.Value;
                            moon.setPhoto((string)pictureBox1.Tag);
                        }
                    }
                }
                FormListOfObjects.instance.objects.ResetBindings();
                this.Close();
            }
        }

        private void labelObjectType_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonChooseObjectColor_Click(object sender, EventArgs e)
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
    }
}
