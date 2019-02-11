using System;
using Galaxy.Base;
using Galaxy.DependencyInjection;
using Ninject;

namespace Galaxy.TestConsole.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new Injection());
            var warrior = kernel.Get<IBusinessObjectRepository>();
           warrior.Persist();

            Console.Read();
        }
    }
}
