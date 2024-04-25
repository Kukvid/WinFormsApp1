using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.MVP.Model;
using WinFormsApp1.MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.MVP.Presenter
{
    public class ChangeDataStarSystemPresenter
    {
        ObjectsModel model;
        StarSystemModel starSystemModel;
        IChangeDataStarSystem view;

        // Получение объекта для изменения данных
        SpaceObject starSystemToChange;

        public ChangeDataStarSystemPresenter(ObjectsModel model, IChangeDataStarSystem view, string objectToChangeName)
        {
            this.model = model;
            this.view = view;
            this.starSystemModel = new StarSystemModel();
            starSystemToChange = model.objects[getIndexOfItemInObjectsList(objectToChangeName)];

            starSystemModel.updateFreeObjectsLists(model.moons, model.planets, model.stars);

            updateObjectsListBoxes();
            
        }
        //Получить индекс объекта в списке объектов objects
        public int getIndexOfItemInObjectsList(string objectName)
        {
            string selectedObjectName = objectName;
            for (int i = 0; i <= model.objects.Count; i++)
            {
                if (selectedObjectName == model.objects[i].NameWithType)
                {
                    return i;
                }
            }
            return -1;
        }
        public void updateObjectsListBoxes()
        {
            List<string> freeMoonsNames = new List<string> { };
            List<string> freePlanetsNames = new List<string> { };
            List<string> freeStarsNames = new List<string> { };

            List<string> occupiedMoonsNames = new List<string> { };
            List<string> occupiedPlanetsNames = new List<string> { };
            List<string> occupiedStarsNames = new List<string> { };

            //Добавление имен свободных объектов в соответствующие списки
            foreach (Moon moon in starSystemModel.freeMoons)
            {
                freeMoonsNames.Add(moon.Name);
            }
            foreach (Planet planet in starSystemModel.freePlanets)
            {
                freePlanetsNames.Add(planet.Name);
            }
            foreach (Star star in starSystemModel.freeStars)
            {
                freeStarsNames.Add(star.Name);
            }

            // Добавление звезд в составе текущей звездной системы в ListBox
            foreach (Star star in model.stars)
            {
                if (star.ParentStarSystem.Name == starSystemToChange.Name)
                {
                    occupiedStarsNames.Add(star.Name);
                }
            }
            // Добавление планет в составе текущей звездной системы в ListBox
            foreach (Planet planet in model.planets)
            {
                if (planet.ParentStarSystem.Name == starSystemToChange.Name)
                {
                    occupiedPlanetsNames.Add(planet.Name);
                }
            }

            // Добавление лун в составе текущей звездной системы в ListBox
            foreach (Moon moon in model.moons)
            {
                if (moon.ParentStarSystem.Name == starSystemToChange.Name)
                {
                    occupiedMoonsNames.Add(moon.Name);
                }
            }
            foreach (string objectName in freeMoonsNames)
            {
                view.addFreeMoonToListBox(objectName);
            }
            foreach (string objectName in freePlanetsNames)
            {
                view.addFreePlanetToListBox(objectName);
            }
            foreach (string objectName in freeStarsNames)
            {
                view.addFreeStarToListBox(objectName);
            }


            foreach (string objectName in occupiedMoonsNames)
            {
                view.addOccupiedMoonToListBox(objectName);
            }
            foreach (string objectName in occupiedPlanetsNames)
            {
                view.addOccupiedPlanetToListBox(objectName);
            }
            foreach (string objectName in occupiedStarsNames)
            {
                view.addOccupiedStarToListBox(objectName);
            }
        }
        public void setInfoAboutSelectedItem()
        {
            view.setStarSystemName(starSystemToChange.Name);
            // Заполнение полей данными из выбранного объекта
            view.setNumericUpDownAge(starSystemToChange.Age);
            view.setDateTimePickerDateOfDiscovery(starSystemToChange.DateOfDiscovery);
            view.setImageInPictureBox(starSystemToChange.Photo);

        }

        public void addPhoto()
        {
            // Открытие диалогового окна для выбора фотографии
            if (view.showImageDialog() != DialogResult.Cancel)
            {
                view.updatePictureBox();

                string imagePath = view.getImagePath();
                view.setImageInPictureBox(imagePath);
            }
        }
        public void addStar(int indexOfStar)
        {
            // Проверка выбранного элемента в списке звезд текущей звездной системы
            if (indexOfStar != -1)
            {
                view.moveStarToStarSystem();
            }
        }
        public void removeStar(int indexOfStar)
        {
            // Проверка: выбран ли какой-либо объект на форме или кнопка нажата просто так
            if (indexOfStar != -1)
            {
                view.removeStarFromStarSystem();
            }
        }
        public void addPlanet(int indexOfPlanet)
        {

            if (indexOfPlanet != -1)
            {
                view.movePlanetToStarSystem();
            }
        }
        public void removePlanet(int indexOfPlanet)
        {
            if (indexOfPlanet != -1)
            {
                view.removePlanetFromStarSystem();
            }
        }
        public void addMoon(int indexOfMoon)
        {
            if (indexOfMoon != -1)
            {
                view.moveMoonToStarSystem();
            }
        }
        public void removeMoon(int indexOfMoon)
        {
            if (indexOfMoon != -1)
            {
                view.removeMoonFromStarSystem();
            }
        }
        public string[] getStringsArrayFromListBoxItems(ListBox.ObjectCollection objectsNames)
        {
            string[] temp = { };

            foreach(string item in objectsNames)
            {
                temp.Append(item);
            }
            return temp;

        }

        public void saveStarSystem()
        {
            // Переменная для хранения сообщения об ошибке
            string message_if_wrong = "";
            // Проверка на уникальность имени объекта
            while (model.spaceObjectIterator.HasNext())
            {
                // Если у объекта меняется имя на то которое уже есть
                if (starSystemToChange.Name.ToLower() == model.spaceObjectIterator.Next().Name
                    & starSystemToChange.Name.ToLower() != view.getStarSystemName())
                {
                    message_if_wrong += "Объект с таким именем уже существует, измените имя объекта;";
                }
                
            }
            model.spaceObjectIterator.resetIndex();

            // Проверка наличия названия звездной системы
            if (string.IsNullOrEmpty(view.getStarSystemName()) |
                view.getStarSystemName() == "Не указано" |
                view.getStarSystemName().Contains("!"))
            {
                message_if_wrong += "\nИзмените название звездной системы;";
            }

            // Проверка выбора возраста звездной системы
            if (view.getNumericUpDownAge() == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст звездной системы;";
            }

            // Получение даты открытия звездной системы
            DateTime dateOfDiscovery = view.getDateOfDiscovery();

            // Если есть ошибки, вывод сообщения об ошибке
            if (message_if_wrong != "")
            {
                view.showMessageBox(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Списки звезд, планет и лун для новой звездной системы
                List<Star> tempStars = new List<Star>();
                List<Planet> tempPlanets = new List<Planet>();
                List<Moon> tempMoons = new List<Moon>();

                // Перебор элементов в списке выбранных звезд и добавление их в соответствующий список
                foreach (string item in view.getOccupiedStarsFromListBoxStars())
                {
                    foreach (Star star in model.stars)
                    {
                        if (star.Name == item)
                        {
                            tempStars.Add(star);
                        }
                    }
                }

                // Перебор элементов в списке выбранных планет и добавление их в соответствующий список
                foreach (string item in view.getOccupiedPlanetsFromListBoxPlanets())
                {

                    foreach (Planet planet in model.planets)
                    {
                        if (planet.Name == item)
                        {
                            tempPlanets.Add(planet);
                        }
                    }
                }
                // Перебор элементов в списке выбранных планет и добавление их в соответствующий список
                foreach (string item in view.getOccupiedMoonsFromListBoxMoons())
                {

                    foreach (Moon moon in model.moons)
                    {
                        if (moon.Name == item)
                        {
                            tempMoons.Add(moon);
                        }
                    }
                }
                // Перебор элементов в списке свободных лун и удаление привязки к текущей звездной системе
                foreach (string item in view.getFreeMoonsFromListBoxMoons())
                {
                    foreach (Moon moon in model.moons)
                    {

                        if (moon.Name == item)
                        {
                            if (moon.ParentStarSystem.Name == starSystemToChange.Name)
                            {
                                moon.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                    }
                }


                // Перебор элементов в списке свободных планет и удаление привязки к текущей звездной системе
                foreach (string item in view.getFreePlanetsFromListBoxPlanets())
                {
                    foreach (Planet planet in model.planets)
                    {

                            if (planet.Name == item)
                            {
                                if (planet.ParentStarSystem.Name == starSystemToChange.Name)
                                {
                                    planet.ParentStarSystem = new StarSystem("Не указано");
                                }
                            }
                        }
                    
                }


                // Перебор элементов в списке свободных звезд и удаление привязки к текущей звездной системе
                foreach (string item in view.getFreeStarsFromListBoxStars())
                {
                    foreach (Star star in model.stars)
                    {
                        if (star.Name == item)
                        {
                            if (star.ParentStarSystem.Name == starSystemToChange.Name)
                            {
                                star.ParentStarSystem = new StarSystem("Не указано");
                            }
                        }
                    }
                }
                // Обновление данных о звездной системе
                foreach (StarSystem starSystem in model.starSystems)
                {
                    if (starSystem.Name == starSystemToChange.Name)
                    {
                        starSystem.Name = view.getStarSystemName();
                        starSystem.Age = view.getNumericUpDownAge();
                        starSystem.DateOfDiscovery = dateOfDiscovery;
                        starSystem.setPhoto(view.getImageTag());
                        starSystem.updateChildrenLists(tempMoons, tempPlanets, tempStars);
                        break;
                    }
                }
                // Обновление привязок и закрытие формы
                view.showMessageBox("Изменения успешно сохранены", "Сохранение");
                view.Close();
            }
        }

    }
}
