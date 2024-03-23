using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using WinFormsLibrary.classes;

namespace WinFormsLibrary
{

    public interface ISpaceObject
    {
        // Поле, хранящее путь к файлу, в котором созраняются все космические объекты
        static string spaceObjectsPath;

        // Свойство для получения и установки имени космического объекта.
        string Name { get; set; }

        // Свойство для получения возраста космического объекта.
        long Age { get; set; }

        // Свойство для получения дополнительной информации о космическом объекте (только для чтения).
        string AdditionalInfo { get; }

        // Свойство для получения пути к фотографии космического объекта (только для чтения).
        string Photo { get; }

        // Свойство для получения и установки цвета космического объекта.
        Color SpaceObjectColor { get; set; }

        // Свойство для получения и установки даты открытия космического объекта.
        DateTime DateOfDiscovery { get; set; }

        // Свойство для более наглядного отображения созданных объектов в списке объектов( только для чтения)
        string NameWithType { get; }

        // Метод для получения строки с дополнительной информацией.
        string getStringWithAdditionalInfo();

        // Метод для установки фотографии космического объекта.
        void setPhoto(string photo, bool isRead);

        // Виртуальный метод для представления типа объекта в виде строки.
        virtual string ToString()
        {
            return "Тип объекта";
        }

        // Делегат для обработки события логирования.
        delegate void LogHandler(string log);

        // Событие логирования, связанное с делегатом LogHandler.
        static event LogHandler LoggingInFileEvent;

        // Метод для записи лога в файл.
        static void WriteLog(string log) { }
    }
}
