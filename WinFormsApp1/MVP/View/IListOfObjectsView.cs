using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.FormListOfObjects_MVP.View
{
    internal interface IListOfObjectsView
    {
        void showMessageBox(string message, string theme = "");

        DialogResult showDialogResult(string message, string theme);

        void setTextBoxSearch(string text);

        void clearListBoxObjects();

        void removeObjectFromListBoxObjects(int index);

        string getSelectedItemFromListBoxObjects();

        void addObjectToListBoxObjects(string objectName);

        void setLabelCount(string count);

        void setTextInTextBoxName(string text);

        void setNumericUpDownAge(long value);

        void setDateTimePickerDateOfDiscovery(DateTime date);

        void setButtonColor(Color color);

        void setImageInPictureBox(string imagePath);

        void setTextBoxType(string text);


    }
}
