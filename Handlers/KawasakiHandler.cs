using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Handlers
{
    public class KawasakiHandler:IHandler
    {
        public void PickUpWafer()
        {
            Console.WriteLine("Kawasaki Pick Up Wafer");
        }

        public void DeliverWafer()
        {
            Console.WriteLine("Kawasaki Deliver Wafer");
        }
    }
}
