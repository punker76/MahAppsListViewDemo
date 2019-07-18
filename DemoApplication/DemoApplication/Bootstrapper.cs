using Caliburn.Micro;
using DemoApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DemoApplication
{
    class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            container.Instance(container);

            container.Singleton<IWindowManager, WindowManager>()
                     .Singleton<IEventAggregator, EventAggregator>();

            GetType().Assembly.GetTypes().Where(x => x.IsClass)
                                         .Where(y => y.Name.EndsWith("ViewModel")).ToList()
                                         .ForEach(z => container.RegisterPerRequest(z, z.ToString(), z));
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
