using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVP.View
{
    public interface IChangeDataOfObjects
    {
        void setTextInTextBoxName(string text);
        void setNumericUpDownAge(long value);
        void setDateTimePickerDateOfDiscovery(DateTime date);
        void setButtonColor(Color color);
        void setPictureBoxObjectImage(Image image);
        void setImageInPictureBox(string imagePath);
        void changeAvailableElements(string selected);
        void setNumericUpDownWeight(double objectWeight);
        void setNumericUpDownAccelerationOfFreeFall(double objectAccelerationOfFreeFall);
        ColorDialog getButtonColorFromDialog();
        string getImagePath();
        Color getObjectColor();
        string getImageTag();
        string getSpaceObjectName();
        DateTime getDateOfDiscovery();
        long getNumericUpDownAge();
        string getObjectTypeFromTextBox();
        double getNumericUpDownWeight();
        double getNumericUpDownAccelerationOfFreeFall();
        void showMessageBox(string message, string theme = "");
        DialogResult showImageDialog();
        void updatePictureBox();
        void setTextBoxType(string text);
        void Close();

    }
}
