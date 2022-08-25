using RenaldoProductionManagementPlatform.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenaldoProductionManagementPlatform.ViewModel
{
    internal class MainViewModel : NotifyBase
    {
        private object _pageContent;

        public object PageContent
        {
            get { return _pageContent; }
            set { SetProperty(ref _pageContent, value); }
        }
    }
}
