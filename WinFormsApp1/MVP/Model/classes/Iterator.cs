using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using WinFormsLibrary.classes;
using WinFormsLibrary.utils;

namespace WinFormsApp1.MVP.Model.classes
{
    // Абстрактное описание интерфейса для создания объекта-итератора
    public interface ISpaceObjectNumerable
    {
        ISpaceObjectIterator CreateIterator();
        void SortSpaceObjectsList(string mode);
        void RemoveSpaceObject(int objectIndex);
        int Count { get; }
        SpaceObject this[int index] { get; }
    }
    internal class Objects : ISpaceObjectNumerable
    {
        private List<SpaceObject> _objects;

        public Objects()
        {
            _objects = new List<SpaceObject>();
        }

        public ISpaceObjectIterator CreateIterator()
        {
            return new SpaceObjectIterator(this);
        }
        public int Count
        {
            get { return _objects.Count; }
        }

        public SpaceObject this[int index]
        {
            get { return _objects[index]; }
        }

        public void AddSpaceObject(SpaceObject spaceObject)
        {
            _objects.Add(spaceObject);
        }
        public void RemoveSpaceObject(int objectIndex)
        {
            _objects.RemoveAt(objectIndex);
        }
        
        public void SortSpaceObjectsList(string mode)
        {
            switch (mode)
            {
                case "Звездная система -> Луна":
                    _objects = _objects.OrderByDescending(x => cost_of_objectsTypes[x.ToString()])
                        .ThenBy(x => x.Name).ToList();
                    break;
                case "Луна -> Звездная система":
                    _objects = _objects.OrderBy(x => cost_of_objectsTypes[x.ToString()])
                        .ThenBy(x => x.Name).ToList().ToList();
                    break;
                case "А -> Я":
                    _objects.Sort((x, y) => string.Compare(x.Name, y.Name));
                    break;
                case "Я -> А":
                    _objects.Sort((x, y) => string.Compare(x.Name, y.Name));
                    _objects.Reverse();
                    break;
                default:
                    break;
            }
        }
        // Словарь с числовыми значениями типов объектов для сортировки по типу
        Dictionary<string, int> cost_of_objectsTypes = new Dictionary<string, int>
        {
            {"Звездная система", 4},
            {"Звезда" , 3},
            {"Планета" , 2},
            {"Луна" , 1},
        };
    }
    // Абстрактное описание интерфейса для обхода составных объектов
    public interface ISpaceObjectIterator
    {
        bool HasNext();
        void resetIndex();
        SpaceObject Next();
        void SortList(string mode);
    }

    // Конкретная реализация итератора для обхода объектов Student
    internal class SpaceObjectIterator : ISpaceObjectIterator
    {
        private ISpaceObjectNumerable numerable;
        private int index = 0;

        public SpaceObjectIterator(ISpaceObjectNumerable numerable)
        {
            this.numerable = numerable;
        }

        public bool HasNext()
        {
            return index < numerable.Count;
        }

        public SpaceObject Next()
        {
            return numerable[index++];   
        }
        public void resetIndex()
        {
            index = 0;
        }
        public void SortList(string mode)
        {
            numerable.SortSpaceObjectsList(mode);
        }
    }
}
