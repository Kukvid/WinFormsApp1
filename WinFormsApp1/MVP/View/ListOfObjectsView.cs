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
using WinFormsApp1.FormListOfObjects_MVP.Presenter;
using WinFormsApp1.FormListOfObjects_MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ListOfObjectsView : Form, IListOfObjectsView
    {

        ListOfObjectsPresenter presenter;

        // Конструктор формы
        public ListOfObjectsView()
        {
            InitializeComponent();
            // Настройка отображения изображений в PictureBox
            pictureBoxObjectImage.SizeMode = PictureBoxSizeMode.StretchImage;

            presenter = new ListOfObjectsPresenter(this);
            presenter.updateListBox(textBoxSearch.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // При нажатии на кнопку открывается форма создания луны, планеты или звезды
        private void buttonCreateSpaceObject_Click(object sender, EventArgs e)
        {
            presenter.createSpaceObject(textBoxSearch.Text);
        }

        // Обработчик события загрузки формы
        private void FormListOfObjects_Load(object sender, EventArgs e)
        {
            presenter.updateListBox(textBoxSearch.Text);
        }
        // Обработчик события закрытия формы
        private void FormListOfObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.saveSpaceObjects();
        }

        // Обработчик события нажатия кнопки удаления объекта
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.deleteObject(listBoxObjects.SelectedIndex, textBoxSearch.Text);

        }
        // Обработчик события нажатия кнопки "Дополнительная информация"
        private void buttonAdditionalInfo_Click(object sender, EventArgs e)
        {
            presenter.getAdditionalInfo(listBoxObjects.SelectedIndex);
        }
        public string getSelectedItemFromListBoxObjects()
        {
            return listBoxObjects.SelectedItem.ToString();
        }

        //Метод, который выводит MessagBox с переданными в него значениями
        public void showMessageBox(string message, string theme = "")
        {
            MessageBox.Show(message, theme);
        }

        public DialogResult showDialogResult(string message, string theme)
        {
            return MessageBox.Show(message, theme, MessageBoxButtons.YesNo);
        }

        // Обработчик события двойного клика по объекту в списке
        private void listBoxObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            presenter.openChangeOBjectDataForm(listBoxObjects.SelectedItem.ToString(), textBoxSearch.Text);
        }
        // Обновление полей формы при выборе какого-то объекта
        private void listBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.updateInfoAboutSelectedItem(listBoxObjects.SelectedIndex);
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

        // Обработчик события нажатия кнопки "Создать звездную систему"
        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            presenter.createStarSystem(textBoxSearch.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            presenter.clearSearchTextBox();
        }
        public void setTextBoxSearch(string text)
        {
            textBoxSearch.Text = text;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            presenter.updateListBox(textBoxSearch.Text);
        }

        public void clearListBoxObjects()
        {
            listBoxObjects.Items.Clear();
        }

        public void addObjectToListBoxObjects(string objectName)
        {
            listBoxObjects.Items.Add(objectName);
        }

        public void removeObjectFromListBoxObjects(int index)
        {
            listBoxObjects.Items.RemoveAt(index);
        }

        public void setLabelCount(string count)
        {
            labelCountObjectsInListBox.Text = count;
        }

        private void comboBoxSort_SelectedValueChanged(object sender, EventArgs e)
        {
            presenter.sortObjectsList(comboBoxSort.SelectedItem.ToString(), textBoxSearch.Text);
        }
    }
}
