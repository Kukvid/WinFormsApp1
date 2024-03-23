using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsLibrary.classes;

namespace WinFormsLibrary
{
    public interface IStarSystem
    {
        //Объявляются три свойства типа List<...>, представляющих коллекции объектов типов Star, Planet и Moon.
        //Они являются дочерними объектами для данной звездной системы.
        public List<Star> ChildrenStars { get; set; }
        public List<Planet> ChildrenPlanets { get; set; }
        public List<Moon> ChildrenMoons { get; set; }

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
