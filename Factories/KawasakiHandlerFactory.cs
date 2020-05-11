using AbstractFactoryDemo.Handlers;
using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Factories
{
    public class KawasakiHandlerFactory : IHandlerFactory
    {
        public IHandler CreateHandler()
        {
            return new KawasakiHandler();
        }
    }
}
