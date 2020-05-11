using AbstractFactoryDemo.Factories;
using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryDemo.Enumeration;

namespace AbstractFactoryDemo
{
    public class AccessLayer
    {
        static IHandler GetHandler(EnHandlers handler)
        {
            IHandlerFactory handlerFac;
            switch (handler)
            {
                case EnHandlers.KaHandler:
                    handlerFac = new KawasakiHandlerFactory();
                    break;
                case EnHandlers.GaHanlder:
                    handlerFac = new GalilHandlerFactory();
                    break;
                default:
                    handlerFac = null;
                    break;
            }
            return handlerFac?.CreateHandler();
        }

        static IStage GetStage(EnStages stage)
        {
            IStageFactory stageFac;
            switch (stage)
            {
                case EnStages.KaStage:
                    stageFac = new KawasakiStageFactory();
                    break;
                case EnStages.GaStage:
                    stageFac = new GalilStageFactory();
                    break;
                default:
                    stageFac = null;
                    break;
            }
            return stageFac?.CreateStage();
        }
    }
}
