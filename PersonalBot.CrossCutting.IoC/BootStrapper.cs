using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using PersonalBot.Domain;
using PersonalBot.Repository;
using PersonalBot.Application;

namespace PersonalBot.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //container.Register<IFluxoAppService, FluxoAppService>(Lifestyle.Singleton);
            container.Register<IAtividadeAppService, AtividadeAppService>(Lifestyle.Singleton);
            container.Register<IAparelhoAppService,AparelhoAppService>(Lifestyle.Singleton);
            container.Register<IFluxoAppService, FluxoAppService>(Lifestyle.Singleton);

            container.Register<IAtividadeService, AtividadeService>(Lifestyle.Singleton);
            container.Register<IAparelhoService, AparelhoService>(Lifestyle.Singleton);

            container.Register<IAparelhoRepository, AparelhoRepository>(Lifestyle.Singleton);
            container.Register<IAtividadeRepository, AtividadeRepository>(Lifestyle.Singleton);


        }
    }
}
