using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.Presenter;
using WinFormsApp1.FormListOfObjects_MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class CreateSpaceObjectView : Form, ICreateSpaceObjectView
    {
        CreateSpaceObjectPresenter presenter;

        public CreateSpaceObjectView(ObjectsModel model)
        {
            InitializeComponent();
            // Настройка отображения изображений в PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.default_star_system;


            presenter = new CreateSpaceObjectPresenter(this, model);
        }

        // Обработчик события нажатия кнопки "Создать космический объект"
        private void buttonCreateSpaceObject_Click(object sender, EventArgs e)
        {
            presenter.CreateSpaceObject();
        }

        // Обработчик события нажатия кнопки "добавить фото"
        private void addPhoto_Click(object sender, EventArgs e)
        {
            presenter.addPhoto();
        }

        public string getComboBoxTypeText()
        {
            return comboBox1.Text;
        }

        public string getSpaceObjectName()
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

        public double getNumericUpDownWeight()
        {
            return (double)numericUpDownWeight.Value;
        }

        public double getNumericUpDownAccelerationOfFreeFall()
        {
            return (double)numericUpDownAccelerationOfFreeFall.Value;
        }

        //Метод, который выводит MessagBox с переданными в него значениями
        public void showMessageBox(string message, string theme = "")
        {
            MessageBox.Show(message, theme);
        }

        public Color getObjectColor()
        {
            return ButtonChooseObjectColor.BackColor;
        }

        public string getImageTag()
        {
            return (string)pictureBox1.Tag;
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

        public void setImageInPictureBox(string imagePath)
        {
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.Tag = imagePath;
        }

        // Обработчик события нажатия кнопки выбора цвета
        private void ButtonChooseObjectColor_Click(object sender, System.EventArgs e)
        {
            presenter.setButtonColor();
        }

        public ColorDialog getButtonColorFromDialog()
        {
            // Открытие диалогового окна выбора цвета
            ColorDialog MyDialog = new ColorDialog();

            // Разрешение выбора произвольного цвета
            MyDialog.AllowFullOpen = true;

            // Отображение кнопки справки
            MyDialog.ShowHelp = true;

            // Установка начального цвета
            MyDialog.Color = ButtonChooseObjectColor.ForeColor;

            return MyDialog;
        }
        public void setButtonColor(Color color)
        {
            ButtonChooseObjectColor.BackColor = color;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Обработчик события изменения выбранного типа объекта в ComboBox
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Получение выбранного типа объекта
            string selected = this.comboBox1.Text;

            presenter.changeElementsVisibility(selected);
        }
        public void changeAvailableElements(string selected)
        {
            // Отображение или скрытие дополнительных полей в зависимости от выбранного типа объекта
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
