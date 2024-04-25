using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.FormListOfObjects.Model;
using WinFormsApp1.FormListOfObjects_MVP.View;
using WinFormsLibrary;
using WinFormsLibrary.classes;

namespace WinFormsApp1.FormListOfObjects_MVP.Presenter
{
    internal class ListOfObjectsPresenter
    {
        public IListOfObjectsView view;
        public ObjectsModel model;


        public ListOfObjectsPresenter(IListOfObjectsView view)
        {
            this.view = view;
            this.model = new ObjectsModel();
        }

        // Сохранить все объекты в файл
        public void saveSpaceObjects()
        {
            model.WriteToFile();
        }

        //Метод получения дополнительной информации об объекте
        public void getAdditionalInfo(int objectIndex)
        {
            
            // Проверка выбранного объекта в списке
            if (objectIndex != -1)
            {
                int objectIndexInObjectList = getIndexOfItemInObjectsList(view.getSelectedItemFromListBoxObjects());
                // Отображение дополнительной информации о выбранном объекте
                view.showMessageBox(model.objects[objectIndexInObjectList].AdditionalInfo, "Дополнительная информация");
            }
            else
            {
                view.showMessageBox("Для получения дополнительной информации об объекте вы должны выбрать его в списке!", "Дополнительная информация");
            }
        }
        
        //Метод удаления объекта
        public void deleteObject(int listBoxObjectIndex, string searchText)
        {
     

            // Проверка выбранного объекта в списке
            if (listBoxObjectIndex != -1)
            {
                string objectName = view.getSelectedItemFromListBoxObjects();
                int indexOfItemInObjectsList = getIndexOfItemInObjectsList(objectName);
                // Запрос подтверждения удаления
                DialogResult AnswerResult = view.showDialogResult($"Вы действительно хотите удалить " +
                    $"{model.objects[indexOfItemInObjectsList].Name} " +
                    $"из списка объектов?", "Удаление объекта");

                // Удаление объекта при положительном ответе пользователя
                if (AnswerResult == DialogResult.Yes)
                {
                    model.deleteSpaceObjectFromLists(objectName, indexOfItemInObjectsList);

                    // Обновление отображаемого списка объектов
                    view.removeObjectFromListBoxObjects(listBoxObjectIndex);
                    view.showMessageBox("Объект успешно удалён!", "Удаление объекта");
                }
                updateListBox(searchText);
            }
            else
            {
                view.showMessageBox("Для удаления объекта вы должны выбрать его в списке!", "Удаление объекта");
            }
        }

        //Очистить поле поиска
        public void clearSearchTextBox()
        {
            view.setTextBoxSearch("");
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

        //Обновить список объектов в форме
        public void updateListBox(string searchText)
        {
            string textFromTextBoxSearch = searchText;
            view.clearListBoxObjects();
            int objectCount = 0;
            
            if (string.IsNullOrEmpty(textFromTextBoxSearch))
            {
                while (model.spaceObjectIterator.HasNext())
                {
                    view.addObjectToListBoxObjects(model.spaceObjectIterator.Next().NameWithType);
                    objectCount++;
                }
            }
            else
            {
                while (model.spaceObjectIterator.HasNext())
                {
                    SpaceObject currentSpaceObject = model.spaceObjectIterator.Next();
                    if (currentSpaceObject.Name.ToLower().Contains(textFromTextBoxSearch.ToLower()))
                    {
                        view.addObjectToListBoxObjects(currentSpaceObject.NameWithType);
                        objectCount++;
                    }
                }
            }
            model.spaceObjectIterator.resetIndex();
            view.setLabelCount(objectCount.ToString());
        }

        //Открыть форму с изменением объекта
        public void openChangeOBjectDataForm(string selectedItemName, string searchText)
        {
            // Открытие формы изменения данных объекта или звездной системы в зависимости от типа объекта
            if (model.objects[getIndexOfItemInObjectsList(selectedItemName)].ToString() == "Звездная система")
            {
                ChangeDataStarSystemView formChangeDataStarSystem = new ChangeDataStarSystemView(model, selectedItemName);
                formChangeDataStarSystem.ShowDialog();
            }
            else
            {
                ChangeDataOfObjectView formChangeDataOfObject = new ChangeDataOfObjectView(model, selectedItemName);
                formChangeDataOfObject.ShowDialog();
            }
            updateListBox(searchText);
        }

        //Обнновить информацию о выбранном объекте в соответствующих ячейках
        public void updateInfoAboutSelectedItem(int selectedIndex)
        {
            if (selectedIndex != -1)
            {
                int objectIndex = getIndexOfItemInObjectsList(view.getSelectedItemFromListBoxObjects());
                view.setTextInTextBoxName(model.objects[objectIndex].Name);
                view.setNumericUpDownAge(model.objects[objectIndex].Age);
                view.setDateTimePickerDateOfDiscovery(model.objects[objectIndex].DateOfDiscovery);
                view.setButtonColor(model.objects[objectIndex].SpaceObjectColor);
                view.setImageInPictureBox(model.objects[objectIndex].Photo);
                view.setTextBoxType(model.objects[objectIndex].ToString());
            }
        }

        //Отсортировать список объектов согласно какому-то способу сортировки
        public void sortObjectsList(string mode, string searchText)
        {
            model.objects.SortSpaceObjectsList(mode);
            updateListBox(searchText);
        }

        public void createSpaceObject(string searchText)
        {
            //Открытие формы для создания нового космического объекта
            CreateSpaceObjectView formCreateSpaceObjectView = new CreateSpaceObjectView(model);
            formCreateSpaceObjectView.ShowDialog();
            updateListBox(searchText);
        }

        public void createStarSystem(string searchText)
        {
            // Открытие формы создания новой звездной системы
            CreateStarSystemView formCreateStarSystem = new CreateStarSystemView(model);
            formCreateStarSystem.ShowDialog();
            updateListBox(searchText);
        }
    }
}
