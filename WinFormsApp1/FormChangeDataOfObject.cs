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
        // Получение доступа к спискам объектов из главной формы
        List<Moon> moons = FormListOfObjects.instance.moons;
        List<Planet> planets = FormListOfObjects.instance.planets;
        List<Star> stars = FormListOfObjects.instance.stars;
        BindingList<SpaceObject> objects = FormListOfObjects.instance.objects;
        // Переменная для хранения текущего имени объекта
        string nowObjectName = string.Empty;
        // Конструктор формы
        public FormChangeDataOfObject()
        {
            InitializeComponent();
            // Настройка отображения изображений в PictureBox

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Получение информации о выбранном объекте для изменения
            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];
            nowObjectName = spaceObjectToChange.Name;
            pictureBox1.Image = spaceObjectToChange.Img;
            pictureBox1.Tag = spaceObjectToChange.Photo;

            // Заполнение полей формы данными из выбранного объекта
            textBox1.Text = spaceObjectToChange.Name;
            numericUpDown1.Value = spaceObjectToChange.Age;
            textBox2.Text = spaceObjectToChange.ToString();
            dateTimePicker1.Value = spaceObjectToChange.DateOfDiscovery;
            ButtonChooseObjectColor.BackColor = spaceObjectToChange.SpaceObjectColor;

            // Визуализация дополнительных полей в зависимости от типа объекта
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
        // Обработчик события нажатия кнопки "Сохранить изменения"
        private void buttonChangeDataOfSpaceObject_Click(object sender, EventArgs e)
        {
            // Получение информации о выбранном объекте для изменения
            SpaceObject spaceObjectToChange = objects[FormListOfObjects.instance.listBox1.SelectedIndex];
            string message_if_wrong = "";

            // Проверка уникальности нового имени объекта
            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObjectToChange.Name.ToLower() == spaceObject.Name & spaceObjectToChange.Name != nowObjectName)
                {
                    message_if_wrong += "Объект с таким именем уже сущестувет, измените имя объекта;";
                }
            }
            // Проверка корректности введенных данных
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
            // Вывод сообщения об ошибках, если они есть
            if (message_if_wrong != "")
            {
                MessageBox.Show(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Обновление информации об объекте с учетом внесенных изменений
                DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());
                spaceObjectToChange.Name = textBox1.Text;
                spaceObjectToChange.Age = (long)numericUpDown1.Value;
                spaceObjectToChange.DateOfDiscovery = dateOfDiscovery;
                spaceObjectToChange.SpaceObjectColor = ButtonChooseObjectColor.BackColor;
                spaceObjectToChange.setPhoto((string)pictureBox1.Tag);
                // Обновление информации для объектов конкретных типов (звезда, планета, луна)
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
                // Обновление отображения списка объектов и закрытие формы
                objects.ResetBindings();
                this.Close();
            }
        }

        private void labelObjectType_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Обработчик события нажатия кнопки выбора цвета
        private void ButtonChooseObjectColor_Click(object sender, System.EventArgs e)
        {
            // Открытие диалогового окна выбора цвета
            ColorDialog MyDialog = new ColorDialog();
            // Разрешение выбора произвольного цвета
            MyDialog.AllowFullOpen = true;
            // Отображение кнопки справки
            MyDialog.ShowHelp = true;
            // Установка начального цвета
            MyDialog.Color = ButtonChooseObjectColor.ForeColor;

            // Обновление цвета кнопки при выборе цвета в диалоговом окне
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ButtonChooseObjectColor.BackColor = MyDialog.Color;

        }

        // Обработчик события нажатия кнопки "добавить фото"
        private void addPhoto_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора фотографии
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Refresh();

                // Создание временного объекта для отображения фото в PictureBox
                Moon tempObject = new Moon();
                tempObject.setPhoto(openFileDialog1.FileName);
                tempObject.showPhoto(pictureBox1);

                // Установка пути к выбранному изображению в Tag PictureBox
                pictureBox1.Tag = openFileDialog1.FileName;
            }
        }
    }
}
