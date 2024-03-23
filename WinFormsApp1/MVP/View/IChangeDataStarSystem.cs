using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVP.View
{
    public interface IChangeDataStarSystem
    {
        void moveStarToStarSystem();
        void removeStarFromStarSystem();
        void movePlanetToStarSystem();
        void removePlanetFromStarSystem();
        void moveMoonToStarSystem();
        void removeMoonFromStarSystem();
        DialogResult showImageDialog();
        void updatePictureBox();
        string getImagePath();
        string getImageTag();
        void setImageInPictureBox(string imagePath);

        void addFreeMoonToListBox(string objectName);
        void addFreePlanetToListBox(string objectName);
        void addFreeStarToListBox(string objectName);
        void addOccupiedMoonToListBox(string objectName);
        void addOccupiedPlanetToListBox(string objectName);
        void addOccupiedStarToListBox(string objectName);

        long getNumericUpDownAge();
        DateTime getDateOfDiscovery();
        void showMessageBox(string message, string theme = "");
        ListBox.ObjectCollection getOccupiedStarsFromListBoxStars();
        ListBox.ObjectCollection getOccupiedPlanetsFromListBoxPlanets();
        ListBox.ObjectCollection getOccupiedMoonsFromListBoxMoons();
        ListBox.ObjectCollection getFreeStarsFromListBoxStars();
        ListBox.ObjectCollection getFreePlanetsFromListBoxPlanets();
        ListBox.ObjectCollection getFreeMoonsFromListBoxMoons();
        string getStarSystemName();
        void setStarSystemName(string objectName);
        void setDateTimePickerDateOfDiscovery(DateTime date);
        void setNumericUpDownAge(long age);
        void Close();
    }
}
