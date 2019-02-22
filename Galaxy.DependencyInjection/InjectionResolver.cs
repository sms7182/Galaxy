using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Castle.Core;
using Castle.MicroKernel.Context;
using Castle.MicroKernel.Handlers;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Galaxy.Base;
using Galaxy.Base.Data;

using Sky.Business;
using Sky.Business.Data;

namespace Galaxy.DependencyInjection
{
    public class InjectionRegistration:IWindsorInstaller
    {

        public InjectionRegistration()
        {
            
        }
       
        

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {



            var basedOnDescriptor = Classes.From(typeof(HotelRepository).Assembly.GetTypes()).BasedOn<BusinessObjectRepository>();
            
            var serviceDescriptor = basedOnDescriptor.WithService;
           var defaultInterfaces = serviceDescriptor.DefaultInterfaces();
           container.Register(defaultInterfaces.LifestyleTransient());
       

        }
       
    }
    public class UseStringGenericStrategy : IGenericImplementationMatchingStrategy
    {
        public Type[] GetGenericArguments(ComponentModel model, CreationContext context)
        {
            return new[]
            {
                context.RequestedType.GetGenericArguments().Single(),
                typeof (string)
            };
        }
    }


}
