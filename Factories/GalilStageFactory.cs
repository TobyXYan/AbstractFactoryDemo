﻿using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Stages;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Factories
{
    public class GalilStageFactory : IStageFactory
    {
        public IStage CreateStage()
        {
            return new GalilStage();
        }
    }
}
