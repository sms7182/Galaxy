using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Castle.Core;
using Castle.Core.Configuration;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;
using Castle.MicroKernel.Lifestyle;
using Castle.MicroKernel.ModelBuilder.Descriptors;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Galaxy.Base;
using Galaxy.Base.Data;
using Galaxy.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Sky.Business;
using Sky.Business.Data;

namespace Galaxy.TestConsole.App
{
   
   
  
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();//  .AddFacility<ArrayFacility>();
           container.Register(Classes.From(typeof(Controller<>).Assembly.GetTypes()).BasedOn<ApiController>());
            container.Install(FromAssembly.Containing(typeof(InjectionRegistration)));
         
         container.Resolve<MyController>();
       
            Console.Read();
         
        }
        
        
       
    }

    public class ApiController
    {

    }
    public class MyController : Controller<HotelInformation>
    {
        public IHotelInformationRepository HotelInformationRepository { get; set; }
        public MyController(IHotelInformationRepository hotelInformationRepository)
        {
                     HotelInformationRepository = hotelInformationRepository;
        }

        public override void Publish()
        {
           
        }

        

    }

    public abstract class Controller<T>:ApiController where T : BusinessObject
    {
        public abstract void Publish();
    }
}
