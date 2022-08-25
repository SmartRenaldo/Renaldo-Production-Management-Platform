using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenaldoProductionManagementPlatform.ViewModel
{
    internal class MainViewModel
    {
        private object _pageContent;

        public object PageContent
        {
            get { return _pageContent; }
            set { _pageContent = value; }
        }
    }
}
