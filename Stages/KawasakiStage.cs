using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Stages
{
    public class KawasakiStage:IStage
    {
        public void Roatate()
        {
            Console.WriteLine("Kawasaki stage roatate");
        }

        public void Flip()
        {
            Console.WriteLine("Kawasaki Stage Flip");
        }
    }
}
