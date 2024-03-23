using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.View;
using WinFormsLibrary.classes;
using WinFormsLibrary;

namespace WinFormsApp1.FormListOfObjects_MVP.Presenter
{
    internal class CreateSpaceObjectPresenter
    {
        public ICreateSpaceObjectView view;
        public ObjectsModel model;

        public CreateSpaceObjectPresenter(ICreateSpaceObjectView view, ObjectsModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void CreateSpaceObject()
        {
            // Обработчик события нажатия кнопки "Создать космический объект"
                // Переменная для хранения сообщения об ошибках
                string message_if_wrong = "";
                // Проверка выбранного типа объекта
                if (string.IsNullOrEmpty(view.getComboBoxTypeText()))
                {
                    message_if_wrong += "\nВыберите тип объекта;";
                }
                // Проверка корректности названия объекта
                if (string.IsNullOrEmpty(view.getSpaceObjectName()) | 
                view.getSpaceObjectName() == "Не указано" | view.getSpaceObjectName().Contains("!"))
                {
                    message_if_wrong += "\nИзмените название космического объекта;";
                }
                // Проверка уникальности имени объекта
                foreach (SpaceObject spaceObject in model.objects)
                {
                    if (spaceObject.Name.ToLower() == view.getSpaceObjectName().ToLower())
                    {
                        message_if_wrong += "\nДанное имя уже находится в списке;";
                    }
                }
                // Проверка наличия выбранного возраста объекта
                if (view.getNumericUpDownAge() == 0)
                {
                    message_if_wrong += "\nОбязательно выберите возраст космического объекта;";
                }
                // Получение даты открытия объекта
                DateTime dateOfDiscovery = view.getDateOfDiscovery();

                // Дополнительные проверки для планет и лун
                if (view.getComboBoxTypeText() == "Планета")
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
                else if (view.getComboBoxTypeText() == "Луна")
                {
                    if (view.getNumericUpDownWeight() <= 0)
                    {
                        message_if_wrong += "\nДобавьте массу для луны;";
                    }
                }
                // Вывод сообщения об ошибках, если они есть
                if (message_if_wrong != "")
                {
                    view.showMessageBox(message_if_wrong, "Нехватает данных для создания космического тела");
                }
                else
                {
                    // Строки для сообщений об успешном создании объекта
                    string star_str =
                        "Успешно создана звезда\n" +
                        "Имя звезды: {0},\n" +
                        "Возраст звезды: {1} лет,\n" +
                        "Дата открытия звезды: {2}\n" +
                        "Цвет звезды: {3}.";
                    string planet_str = "Успешно создана планета\n" +
                        "Имя планеты: {0},\n" +
                        "Возраст планеты: {1} лет,\n" +
                        "Дата открытия планеты: {2}\n" +
                        "Цвет планеты: {3}.\n" +
                        "Масса планеты: {4} 10^24 кг.\n" +
                        "Ускорение свободного падения: {5} м/с^2.\n";
                    string moon_str = "Успешно создана луна\n" +
                        "Имя луны: {0},\n" +
                        "Возраст луны: {1} лет,\n" +
                        "Дата открытия луны: {2}\n" +
                        "Цвет луны: {3}.\n" +
                        "Масса луны: {4} кг.";
                    // Создание нового объекта в зависимости от выбранного типа
                    if (view.getComboBoxTypeText() == "Звезда")
                    {
                        Star newObject = new Star(view.getSpaceObjectName(), view.getNumericUpDownAge(), dateOfDiscovery, view.getObjectColor(), view.getImageTag());

                        view.showMessageBox(String.Format(star_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor), "Космический объект успешно создан");
                        // Добавление объекта в списки
                        model.objects.Add(newObject);
                        model.stars.Add(newObject);
                    }
                    else if (view.getComboBoxTypeText() == "Планета")
                    {
                        Planet newObject = new Planet(view.getSpaceObjectName(), view.getNumericUpDownAge(), view.getNumericUpDownWeight(), view.getNumericUpDownAccelerationOfFreeFall(), dateOfDiscovery, view.getObjectColor(), view.getImageTag());
                        newObject.DateOfDiscovery = dateOfDiscovery;

                        view.showMessageBox(String.Format(planet_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight, newObject.AccelerationOfFreeFall), "Космический объект успешно создан");
                        // Добавление объекта в списки
                        model.objects.Add(newObject);
                        model.planets.Add(newObject);
                    }
                    else if (view.getComboBoxTypeText() == "Луна")
                    {

                        Moon newObject = new Moon(view.getSpaceObjectName(), view.getNumericUpDownAge(), view.getNumericUpDownWeight(), dateOfDiscovery, view.getObjectColor(), view.getImageTag());
                        view.showMessageBox(String.Format(moon_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight), "Космический объект успешно создан");
                        // Добавление объекта в списки
                        model.objects.Add(newObject);
                        model.moons.Add(newObject);
                    }
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

        public void setButtonColor()
        {
            ColorDialog result = view.getButtonColorFromDialog();
            if (result.ShowDialog() == DialogResult.OK)
            {
                view.setButtonColor(result.Color);
            }
        }
        
        public void changeElementsVisibility(string mode)
        {
            view.changeAvailableElements(mode);
        }
    }
}
