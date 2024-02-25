using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{
    internal interface IPlanet
    {
        // Масса планеты
        double Weight { get; set; }

        // Ускорение свободного падения на планете
        double AccelerationOfFreeFall { get; set; }

        // Получить имя родительской звездной системы
        string getParentInfo();

        // Делегат для обработки события логирования.
        delegate void LogHandler(string log);

        // Событие логирования, связанное с делегатом LogHandler.
        static event LogHandler LoggingInFileEventPlanet;
    }
}
