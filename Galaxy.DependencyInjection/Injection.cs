using System;
using System.Collections.Generic;
using System.Text;
using Galaxy.Base;
using Galaxy.Base.Data;
using Ninject;
using Ninject.Modules;

namespace Galaxy.DependencyInjection
{
    public class Injection:NinjectModule
    {

        public Injection()
        {
            
        }
       
        

        public override void Load()
        {
          Bind(typeof(IBusinessObjectRepository)).To(typeof(BusinessObjectRepository));
        }
    }
}
