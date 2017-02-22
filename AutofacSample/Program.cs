using Autofac;
using AutofacSample.LayerA;
using AutofacSample.LayerC;
using AutofacSample.LayerB;
using System;
using System.Runtime.CompilerServices;

namespace AutofacSample
{
    class Program
    {
        static void Main(string[] args)
        { 
            SimpleRegistration();

            RegistrationWithTwoImplementationForOneIntrerface();


            Console.ReadLine();
        }

        private static void BuildAndResolve(ContainerBuilder containerBuilder, [CallerMemberName] string callerName = null)
        {
            var container = containerBuilder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var layerA = scope.Resolve<ILayerA>();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{callerName}:\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(layerA.Name);
            }
        }

        private static void SimpleRegistration()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<LayerCImplementationOne>().AsImplementedInterfaces();
            containerBuilder.RegisterType<LayerBImplementationOne>().AsImplementedInterfaces();
            containerBuilder.RegisterType<LayerAImplementationOne>().AsImplementedInterfaces();

            BuildAndResolve(containerBuilder);
        }

        private static void RegistrationWithTwoImplementationForOneIntrerface()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<LayerCImplementationOne>().AsImplementedInterfaces();
            containerBuilder.RegisterType<LayerCImplementationTwo>().AsImplementedInterfaces();

            containerBuilder.RegisterType<LayerBImplementationOne>().AsImplementedInterfaces();
            containerBuilder.RegisterType<LayerBImplementationTwo>().AsImplementedInterfaces();

            containerBuilder.RegisterType<LayerAImplementationOne>().AsImplementedInterfaces();
            containerBuilder.RegisterType<LayerAImplementationTwo>().AsImplementedInterfaces();


            BuildAndResolve(containerBuilder);
        }
    }
}
