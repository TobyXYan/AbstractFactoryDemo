using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Handlers
{
    public class GalilHandler:IHandler
    {
        public  void PickUpWafer()
        {
            Console.WriteLine("Galil Pick Up Wafer");
        }

        public void DeliverWafer()
        {
            Console.WriteLine("Galil Deliver Wafer");
        }

    }
}
