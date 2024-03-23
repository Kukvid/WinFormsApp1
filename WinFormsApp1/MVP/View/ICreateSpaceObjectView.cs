using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.FormListOfObjects_MVP.View
{
    public interface ICreateSpaceObjectView
    {
        string getComboBoxTypeText();
        string getSpaceObjectName();
        long getNumericUpDownAge();
        DateTime getDateOfDiscovery();
        double getNumericUpDownWeight();
        double getNumericUpDownAccelerationOfFreeFall();
        void showMessageBox(string message, string theme = "");
        Color getObjectColor();
        string getImageTag();
        void Close();
        DialogResult showImageDialog();
        void updatePictureBox();
        string getImagePath();
        void setImageInPictureBox(string imagePath);
        void setButtonColor(Color color);
        ColorDialog getButtonColorFromDialog();
        void changeAvailableElements(string selected);

    }
}
