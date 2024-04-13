using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
    internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
            action.CreatedDateTime, action.User, action.Description);
        }
    }
}