using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.Presenter;
using WinFormsApp1.MVP.Presenter;
using WinFormsApp1.MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using WinFormsLibrary.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class CreateStarSystemView : Form, ICreateStarSystemView 
    {
        CreateStarSystemPresenter presenter;

        // Конструктор формы
        public CreateStarSystemView(ObjectsModel model)
        {
            InitializeComponent();

            // Настройка отображения изображений в PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.default_star_system;
            presenter = new CreateStarSystemPresenter(this, model);
            presenter.updateFreeListBoxes();
        }
        public void addFreeMoonToListBox(string objectName)
        {
            listBoxMoons1.Items.Add(objectName);
        }
        public void addFreePlanetToListBox(string objectName)
        {
            listBoxPlanets1.Items.Add(objectName);
        }
        public void addFreeStarToListBox(string objectName)
        {
            listBoxStars1.Items.Add(objectName);
        }
        // Обработчик события нажатия кнопки "добавить фото"
        private void addPhoto_Click(object sender, EventArgs e)
        {
            presenter.addPhoto();
        }

        public void setImageInPictureBox(string imagePath)
        {
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.Tag = imagePath;
        }
        // Обработчик события нажатия кнопки для добавления звезды в звездную систему
        private void buttonAddStar_Click(object sender, EventArgs e)
        {
            presenter.addStar(listBoxStars1.SelectedIndex);
        }

        // Обработчик события нажатия кнопки для удаления звезды из звездной системы
        private void buttonRemoveStar_Click(object sender, EventArgs e)
        {
            presenter.removeStar(listBoxStars2.SelectedIndex);
        }
        
        // Обработчик события нажатия кнопки для добавления планеты в звездную систему
        private void buttonAddPlanet_Click(object sender, EventArgs e)
        {
            presenter.addPlanet(listBoxPlanets1.SelectedIndex);
        }
        // Обработчик события нажатия кнопки для удаления планеты из звездной системы
        private void buttonRemovePlanet_Click(object sender, EventArgs e)
        {
            presenter.removePlanet(listBoxPlanets2.SelectedIndex);
        }
        // Обработчик события нажатия кнопки для добавления луны в звездную систему
        private void buttonAddMoon_Click(object sender, EventArgs e)
        {
            presenter.addMoon(listBoxMoons1.SelectedIndex);
        }
        // Обработчик события нажатия кнопки для удаления луны из звездной системы
        private void buttonRemoveMoon_Click(object sender, EventArgs e)
        {
            presenter.removeMoon(listBoxMoons2.SelectedIndex);
        }
        // Обработчик события нажатия кнопки "Создать звездную систему"
        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            presenter.createStarSystem();
        }
        public void moveStarToStarSystem()
        {
            // Добавление выбранной звезды в список занятых звезд
            listBoxStars2.Items.Add(listBoxStars1.SelectedItem);

            // Удаление выбранной звезды из списка звезд текущей звездной системы
            listBoxStars1.Items.Remove(listBoxStars1.SelectedItem);
        }
        public void removeStarFromStarSystem()
        {
            // Добавление выбранной звезды в список свободных звезд
            listBoxStars1.Items.Add(listBoxStars2.SelectedItem);
            // Удаление выбранной звезды из списка звезд текущей звездной системы
            listBoxStars2.Items.Remove(listBoxStars2.SelectedItem);
        }
        public void movePlanetToStarSystem()
        {
            listBoxPlanets2.Items.Add(listBoxPlanets1.SelectedItem);
            listBoxPlanets1.Items.Remove(listBoxPlanets1.SelectedItem);
        }
        public void removePlanetFromStarSystem()
        {
            listBoxPlanets1.Items.Add(listBoxPlanets2.SelectedItem);
            listBoxPlanets2.Items.Remove(listBoxPlanets2.SelectedItem);
        }
        public void moveMoonToStarSystem()
        {
            listBoxMoons2.Items.Add(listBoxMoons1.SelectedItem);
            listBoxMoons1.Items.Remove(listBoxMoons1.SelectedItem);
        }
        public void removeMoonFromStarSystem()
        {
            listBoxMoons1.Items.Add(listBoxMoons2.SelectedItem);
            listBoxMoons2.Items.Remove(listBoxMoons2.SelectedItem);
        }
        public DialogResult showImageDialog()
        {
            return openFileDialog1.ShowDialog();
        }

        public void updatePictureBox()
        {
            pictureBox1.Refresh();
        }

        public string getImagePath()
        {
            return openFileDialog1.FileName;
        }
        public string getStarSystemName()
        {
            return textBox1.Text;
        }
        
        public long getNumericUpDownAge()
        {
            return (long)numericUpDown1.Value;
        }
        public DateTime getDateOfDiscovery()
        {
            return DateTime.Parse(dateTimePicker1.Value.ToString());
        }
        //Метод, который выводит MessagBox с переданными в него значениями
        public void showMessageBox(string message, string theme = "")
        {
            MessageBox.Show(message, theme);
        }
        
        public ListBox.ObjectCollection getStarsFromListBoxStars2()
        {
            return listBoxStars2.Items;
        }
        public ListBox.ObjectCollection getPlanetsFromListBoxPlanets2()
        {
            return listBoxPlanets2.Items;
        }
        public ListBox.ObjectCollection getMoonsFromListBoxMoons2()
        {
            return listBoxMoons2.Items;
        }
        public string getImageTag()
        {
            return (string)pictureBox1.Tag;
        }
    }
}

