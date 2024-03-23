using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.Presenter;
using WinFormsApp1.MVP.Presenter;
using WinFormsApp1.MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ChangeDataOfObjectView : Form, IChangeDataOfObjects
    {
        ChangeDataOfObjectPresenter presenter;
        // Конструктор формы
        public ChangeDataOfObjectView(ObjectsModel model, string spaceObjectToChangeName)
        {
            InitializeComponent();

            this.presenter = new ChangeDataOfObjectPresenter(this, model, spaceObjectToChangeName);

            // Настройка отображения изображений в PictureBox
            pictureBoxObjectImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Установка значений изменяемого оъекта
            presenter.setInfoAboutSelectedItem();
        }

        public void setTextInTextBoxName(string text)
        {
            textBoxName.Text = text;
        }

        public void setNumericUpDownAge(long value)
        {
            numericUpDownAge.Value = value;
        }

        public void setDateTimePickerDateOfDiscovery(DateTime date)
        {
            dateTimePickerDateOfDiscovery.Value = date;
        }

        public void setButtonColor(Color color)
        {
            buttonColor.BackColor = color;
        }

        public void setPictureBoxObjectImage(Image image)
        {
            pictureBoxObjectImage.Image = image;
        }

        public void setImageInPictureBox(string imagePath)
        {
            pictureBoxObjectImage.Image = Image.FromFile(imagePath);
            pictureBoxObjectImage.Tag = imagePath;
        }

        public void setTextBoxType(string text)
        {
            textBoxType.Text = text;
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
        public void setNumericUpDownWeight(double objectWeight)
        {
            numericUpDownWeight.Value = (decimal)objectWeight;
        }

        public void setNumericUpDownAccelerationOfFreeFall(double objectAccelerationOfFreeFall)
        {
            numericUpDownAccelerationOfFreeFall.Value = (decimal)objectAccelerationOfFreeFall;
        }
        public string getImagePath()
        {
            return openFileDialog1.FileName;
        }
        public Color getObjectColor()
        {
            return buttonColor.BackColor;
        }
        public string getSpaceObjectName()
        {
            return textBoxName.Text;
        }
        public long getNumericUpDownAge()
        {
            return (long)numericUpDownAge.Value;
        }
        public DateTime getDateOfDiscovery()
        {
            return DateTime.Parse(dateTimePickerDateOfDiscovery.Value.ToString());
        }
        public string getImageTag()
        {
            return (string)pictureBoxObjectImage.Tag;
        }
        public string getObjectTypeFromTextBox()
        {
            return textBoxType.Text;
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
        private void FormChangeDataOfObject_Load(object sender, EventArgs e) { }
        // Обработчик события нажатия кнопки "Сохранить изменения"
        private void buttonChangeDataOfSpaceObject_Click(object sender, EventArgs e)
        {
            presenter.changeSpaceObjectData();
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
            presenter.setButtonColor();
        }
        public DialogResult showImageDialog()
        {
            return openFileDialog1.ShowDialog();
        }
        public void updatePictureBox()
        {
            pictureBoxObjectImage.Refresh();
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
            MyDialog.Color = buttonColor.ForeColor;

            return MyDialog;
        }
        // Обработчик события нажатия кнопки "добавить фото"
        private void addPhoto_Click(object sender, EventArgs e)
        {
            presenter.addPhoto();

        }
    }
}
