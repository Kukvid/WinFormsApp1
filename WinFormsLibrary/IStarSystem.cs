using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{
    public interface IStarSystem
    {
        //Объявляются три свойства типа List<...>, представляющих коллекции объектов типов Star, Planet и Moon.
        //Они являются дочерними объектами для данной звездной системы.
        public List<Star> ChildrenStars { get; set; }
        public List<Planet> ChildrenPlanets { get; set; }
        public List<Moon> ChildrenMoons { get; set; }
        //Объявляются три метода Join, каждый из которых принимает разделитель (separator) и список объектов соответствующего типа (звезд, планет или лун).
        //Эти методы используются для объединения информации об объектах в строку с использованием заданного разделителя.
        string Join(string separator, List<Star> objects);
        string Join(string separator, List<Planet> objects);
        string Join(string separator, List<Moon> objects);
        //Метод, который предназначен для получения информации о дочерних объектах в виде строки.
        string getChildrenInfo();
        //Метод, который обновляет списки дочерних объектов звездной системы на основе предоставленных списков лун, планет и звезд.
        void updateChildrenLists(List<Moon> moons, List<Planet> planets, List<Star> stars);
        //Метод для установки связей между звездной системой и дочерними элементами, который заполняет списки дочерних элементов,
        //у которых в качестве родителя прописана данная звездная система.
        void linkWithChildren(List<Moon> moons, List<Planet> planets, List<Star> stars);

        // Делегат для обработки события логирования.
        delegate void LogHandler(string log);

        // Событие логирования, связанное с делегатом LogHandler.
        static event LogHandler LoggingInFileEventStarSystem;
    }
}
