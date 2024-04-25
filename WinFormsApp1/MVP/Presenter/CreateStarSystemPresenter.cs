using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.View;
using WinFormsApp1.MVP.Model;
using WinFormsApp1.MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;
using WinFormsLibrary.utils;

namespace WinFormsApp1.MVP.Presenter
{
    public class CreateStarSystemPresenter
    {

        public ICreateStarSystemView view;
        public ObjectsModel model;
        public StarSystemModel starSystemModel;

        public CreateStarSystemPresenter(ICreateStarSystemView view, ObjectsModel model)
        {
            this.view = view;
            this.model = model;
            this.starSystemModel = new StarSystemModel();

            starSystemModel.updateFreeObjectsLists(model.moons, model.planets, model.stars);
        }
        public void updateFreeListBoxes()
        {
            List<string> moonsNames = new List<string> { };
            List<string> planetsNames = new List<string> { };
            List<string> starsNames = new List<string> { };
            foreach(Moon moon in starSystemModel.freeMoons)
            {
                view.addFreeMoonToListBox(moon.Name);
            }
            foreach (Planet planet in starSystemModel.freePlanets)
            {
                view.addFreePlanetToListBox(planet.Name);
            }
            foreach (Star star in starSystemModel.freeStars)
            {
                view.addFreeStarToListBox(star.Name);
            }


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
        public void createStarSystem()
        {
            // Переменная для хранения сообщения об ошибках
            string message_if_wrong = "";
            // Проверка введенных данных для создания звездной системы
            if (string.IsNullOrEmpty(view.getStarSystemName()) | view.getStarSystemName() == "Не указано" | view.getStarSystemName().Contains("!"))
            {
                message_if_wrong += "\nИзмените название звездной системы;";
            }
            while (model.spaceObjectIterator.HasNext())
            {
                if (model.spaceObjectIterator.Next().Name == view.getStarSystemName().ToLower())
                {
                    message_if_wrong += "\nДанное имя уже находится в списке;";
                }
            }
            model.spaceObjectIterator.resetIndex();
            if (view.getNumericUpDownAge() == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст звездной системы;";
            }

            DateTime dateOfDiscovery = view.getDateOfDiscovery();

            // Вывод сообщения об ошибках, если они есть
            if (message_if_wrong != "")
            {
                view.showMessageBox(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Строка для сообщения об успешном создании звездной системы
                string star_system_str =
                "Звездная система успешно создана: {0},\n" +
                "Имя звездной системы: {0},\n" +
                "Возраст системы: {1} лет,\n" +
                "Дата открытия системы: {2}\n" +
                "Звезды в составе системы: {3};\n" +
                "Планеты в составе системы: {4};\n" +
                "Луны в составе системы: {5};\n";

                // Списки звезд, планет и лун для новой звездной системы
                List<Star> tempStars = new List<Star>();
                List<Planet> tempPlanets = new List<Planet>();
                List<Moon> tempMoons = new List<Moon>();

                // Проверка и добавление выбранных звезд в состав системы
                foreach (Star star in model.stars)
                {
                    foreach (string item in view.getStarsFromListBoxStars2())
                    {
                        if (star.Name == item)
                        {
                            tempStars.Add(star);
                        }
                    }
                }
                // Проверка и добавление выбранных планет в состав системы
                foreach (Planet planet in model.planets)
                {
                    foreach (string item in view.getPlanetsFromListBoxPlanets2())
                    {
                        if (planet.Name == item)
                        {
                            tempPlanets.Add(planet);
                        }
                    }
                }
                // Проверка и добавление выбранных лун в состав системы
                foreach (Moon moon in model.moons)
                {
                    foreach (string item in view.getMoonsFromListBoxMoons2())
                    {
                        if (moon.Name == item)
                        {
                            tempMoons.Add(moon);
                        }
                    }
                }
                // Создание новой звездной системы
                StarSystem newObject = new StarSystem(view.getStarSystemName(), view.getNumericUpDownAge(), dateOfDiscovery, view.getImageTag(), tempMoons, tempPlanets, tempStars);

                // Вывод сообщения об успешном создании звездной системы
                view.showMessageBox(String.Format(star_system_str, newObject.Name, newObject.Age, dateOfDiscovery, Utils.Join(",", newObject.ChildrenStars), Utils.Join(",", newObject.ChildrenPlanets), Utils.Join(",", newObject.ChildrenMoons)), "Звездная система успешно создана");

                // Добавление новой звездной системы в списки и обновление отображаемого списка объектов
                model.objects.AddSpaceObject(newObject);
                model.starSystems.Add(newObject);
                view.Close();
            }
        }
    }
}
