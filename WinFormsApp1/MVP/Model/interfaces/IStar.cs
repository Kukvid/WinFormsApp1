﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{
    public interface IStar
    {

        // Делегат для обработки события логирования.
        delegate void LogHandler(string log);

        // Событие логирования, связанное с делегатом LogHandler.
        static event LogHandler LoggingInFileEventStar;

    }
}
