using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private AViewModel aViewModel;
        private BViewModel bViewModel;
        private CViewModel cViewModel;

        public ShellViewModel(AViewModel a, BViewModel b, CViewModel c)
        {
            aViewModel = a;
            bViewModel = b;
            cViewModel = c;

            ActivateItem(aViewModel);
        }


        public void LoadA()
        {
            ActivateItem(aViewModel);
        }

        public void LoadB()
        {
            ActivateItem(bViewModel);
        }

        public void LoadC()
        {
            ActivateItem(cViewModel);
        }
    }
}
