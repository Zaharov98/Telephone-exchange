﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Interfaces
{
    public interface ITerminal
    {
        Phone PhoneNumber { get; }

        CallState MakeCall(Phone phone);
        CallState ReceiveCall();
        CallState CloseCall();

        bool ConnectToExchange();
        bool DisconnectFromExchange();

        string RunUSSD(string request);
    }
}
