using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVP.View
{
    public interface ICreateStarSystemView
    {
        DialogResult showImageDialog();
        void updatePictureBox();
        string getImagePath();
        void setImageInPictureBox(string imagePath);
        void moveStarToStarSystem();
        void removeStarFromStarSystem();
        void movePlanetToStarSystem();
        void removePlanetFromStarSystem();
        void moveMoonToStarSystem();
        void removeMoonFromStarSystem();
        string getStarSystemName();
        void Close();
        long getNumericUpDownAge();
        DateTime getDateOfDiscovery();
        void showMessageBox(string message, string theme = "");
        void addFreeMoonToListBox(string objectName);
        void addFreePlanetToListBox(string objectName);
        void addFreeStarToListBox(string objectName);
        ListBox.ObjectCollection getStarsFromListBoxStars2();
        ListBox.ObjectCollection getPlanetsFromListBoxPlanets2();
        ListBox.ObjectCollection getMoonsFromListBoxMoons2();
        string getImageTag();
    }
}
