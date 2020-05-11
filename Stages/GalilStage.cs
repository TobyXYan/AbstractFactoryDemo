using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Stages
{
    public class GalilStage : IStage
    {
        public void Flip()
        {
            Console.WriteLine("Galil Stage Flip");
        }

        public void Roatate()
        {
            Console.WriteLine("Galil Stage Rotate");
        }
    }
}
