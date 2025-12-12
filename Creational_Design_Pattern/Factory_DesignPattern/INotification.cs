using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    public interface INotification
    {
        void Send(string message);
    }
}