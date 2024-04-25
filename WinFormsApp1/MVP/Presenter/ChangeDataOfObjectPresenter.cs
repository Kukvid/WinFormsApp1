using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;

namespace WinFormsApp1.MVP.Presenter
{
    public class ChangeDataOfObjectPresenter
    {
        IChangeDataOfObjects view;
        ObjectsModel model;

        // Получение информации о выбранном объекте для изменения
        SpaceObject spaceObjectToChange;

        public ChangeDataOfObjectPresenter(IChangeDataOfObjects view,ObjectsModel model, string objectToChangeName)
        {
            this.view = view;
            this.model = model;

            spaceObjectToChange = model.objects[getIndexOfItemInObjectsList(objectToChangeName)];
        }
        //Получить индекс объекта в списке объектов objects
        public int getIndexOfItemInObjectsList(string objectName)
        {
            string selectedObjectName = objectName;

            for (int i = 0; i <= model.objects.Count; i++)
            {
                if ( selectedObjectName == model.objects[i].NameWithType)
                {
                    return i;
                }
            }
            return -1;
        }
        public void setInfoAboutSelectedItem()
        {
            view.setTextInTextBoxName(spaceObjectToChange.Name);
            view.setNumericUpDownAge(spaceObjectToChange.Age);
            view.changeAvailableElements(spaceObjectToChange.ToString());
            view.setDateTimePickerDateOfDiscovery(spaceObjectToChange.DateOfDiscovery);
            view.setButtonColor(spaceObjectToChange.SpaceObjectColor);
            view.setImageInPictureBox(spaceObjectToChange.Photo);
            view.setTextBoxType(spaceObjectToChange.ToString());
            if (spaceObjectToChange.ToString() == "Планета")
            {
                foreach (Planet planet in model.planets)
                {
                    if (planet.Name == spaceObjectToChange.Name)
                    {
                        view.setNumericUpDownWeight(planet.Weight);
                        view.setNumericUpDownAccelerationOfFreeFall(planet.AccelerationOfFreeFall);
                        break;
                    }
                }
            }
            else if (spaceObjectToChange.ToString() == "Луна")
                foreach(Moon moon in model.moons)
                {
                    if (moon.Name == spaceObjectToChange.Name)
                    {
                        view.setNumericUpDownWeight(moon.Weight);
                    }
                }
        }
        public void setButtonColor()
        {
            ColorDialog result = view.getButtonColorFromDialog();
            if (result.ShowDialog() == DialogResult.OK)
            {
                view.setButtonColor(result.Color);
            }
        }
        public void changeSpaceObjectData()
        {
            string message_if_wrong = "";

            // Проверка уникальности имени объекта
            while (model.spaceObjectIterator.HasNext())
            {
                if (model.spaceObjectIterator.Next().Name == view.getSpaceObjectName().ToLower())
                {
                    message_if_wrong += "\nДанное имя уже находится в списке;";
                }
                
            }
            model.spaceObjectIterator.resetIndex();
            // Проверка корректности введенных данных
            if (string.IsNullOrEmpty(view.getSpaceObjectName()) | view.getSpaceObjectName() == "Не указано"|
                view.getSpaceObjectName().Contains("!"))
            {
                message_if_wrong += "\nИзмените название космического объекта;";
            }

            if (view.getNumericUpDownAge() == 0)
            {
                message_if_wrong += "\nОбязательно выберите возраст космического объекта;";
            }

            if (view.getObjectTypeFromTextBox() == "Планета")
            {
                if (view.getNumericUpDownWeight() <= 0)
                {
                    message_if_wrong += "\nДобавьте массу для планеты;";
                }
                if (view.getNumericUpDownAccelerationOfFreeFall() <= 0)
                {
                    message_if_wrong += "\nДобавьте ускорение свободного падения для планеты;";
                }
            }
            else if (view.getObjectTypeFromTextBox() == "Луна")
            {
                if (view.getNumericUpDownWeight() <= 0)
                {
                    message_if_wrong += "\nДобавьте массу для луны;";
                }
            }
            // Вывод сообщения об ошибках, если они есть
            if (message_if_wrong != "")
            {
                MessageBox.Show(message_if_wrong, "Нехватает данных для создания космического тела");
            }
            else
            {
                // Обновление информации об объекте с учетом внесенных изменений
                DateTime dateOfDiscovery = view.getDateOfDiscovery();
                spaceObjectToChange.Name = view.getSpaceObjectName();
                spaceObjectToChange.Age = view.getNumericUpDownAge();
                spaceObjectToChange.DateOfDiscovery = dateOfDiscovery;
                spaceObjectToChange.SpaceObjectColor = view.getObjectColor();
                spaceObjectToChange.setPhoto(view.getImageTag());

                // Обновление информации для объектов конкретных типов (звезда, планета, луна)
                if (spaceObjectToChange.ToString() == "Звезда")
                {
                    foreach (Star star in model.stars)
                    {
                        if (star.Name == spaceObjectToChange.Name)
                        {
                            star.Name = view.getSpaceObjectName();
                            star.Age = view.getNumericUpDownAge();
                            star.DateOfDiscovery = dateOfDiscovery;
                            star.SpaceObjectColor = view.getObjectColor();
                            star.setPhoto(view.getImageTag());
                            break;
                        }
                    }
                }
                else if (spaceObjectToChange.ToString() == "Планета")
                {
                    foreach (Planet planet in model.planets)
                    {
                        if (planet.Name == spaceObjectToChange.Name)
                        {
                            planet.Name = view.getSpaceObjectName();
                            planet.Age = view.getNumericUpDownAge();
                            planet.DateOfDiscovery = dateOfDiscovery;
                            planet.SpaceObjectColor = view.getObjectColor();
                            planet.Weight = view.getNumericUpDownWeight();
                            planet.AccelerationOfFreeFall = view.getNumericUpDownAccelerationOfFreeFall();
                            planet.setPhoto(view.getImageTag());

                            /*
                            Planet spaceObjectToChangePlanet = (Planet)spaceObjectToChange;
                            spaceObjectToChangePlanet.Weight = view.getNumericUpDownWeight();
                            spaceObjectToChangePlanet.AccelerationOfFreeFall = view.getNumericUpDownAccelerationOfFreeFall();
                            spaceObjectToChange = (SpaceObject)spaceObjectToChangePlanet;*/
                            break;
                        }
                    }
                }
                else if (spaceObjectToChange.ToString() == "Луна")
                {
                    foreach (Moon moon in model.moons)
                    {
                        if (moon.Name == spaceObjectToChange.Name)
                        {
                            moon.Name = view.getSpaceObjectName();
                            moon.Age = view.getNumericUpDownAge();
                            moon.DateOfDiscovery = dateOfDiscovery;
                            moon.SpaceObjectColor = view.getObjectColor();
                            moon.Weight = view.getNumericUpDownWeight();
                            moon.setPhoto(view.getImageTag());

                            /*
                            Moon spaceObjectToChangeMoon = (Moon)spaceObjectToChange;
                            spaceObjectToChangeMoon.Weight = view.getNumericUpDownWeight();
                            spaceObjectToChange = (SpaceObject)spaceObjectToChangeMoon;*/
                            break;
                        }
                    }
                }
                view.showMessageBox("Изменения успешно сохранены", "Сохранение");
                view.Close();
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

    }
}
