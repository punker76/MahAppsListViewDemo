using Caliburn.Micro;
using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.ViewModels
{
    public class CViewModel : Screen
    {
        public BindableCollection<DemoModel> Monday { get; set; }
        public BindableCollection<DemoModel> Tuesday { get; set; }
        public BindableCollection<DemoModel> Wednesday { get; set; }
        public BindableCollection<DemoModel> Thursday { get; set; }
        public BindableCollection<DemoModel> Friday { get; set; }
        public BindableCollection<DemoModel> Saturday { get; set; }
        public BindableCollection<DemoModel> Sunday { get; set; }

        public CViewModel()
        {
            DisplayName = "View C";

            Monday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Tuesday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Wednesday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Thursday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Friday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Saturday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
            Sunday = new BindableCollection<DemoModel>()
            {
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
                new DemoModel(),
            };
        }
    }
}
