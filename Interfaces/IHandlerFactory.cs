using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Interfaces
{
    public interface IHandlerFactory
    {
        IHandler CreateHandler();
    }
}
