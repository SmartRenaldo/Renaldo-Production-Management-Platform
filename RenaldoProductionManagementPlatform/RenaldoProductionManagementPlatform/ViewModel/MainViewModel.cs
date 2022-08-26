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
        private Random _random = new Random();

        public object PageContent
        {
            get { return _pageContent; }
            set { SetProperty(ref _pageContent, value); }
        }

        private string _totalCount;
        public string TotalCount
        {
            get { return _totalCount; }
            set { SetProperty(ref _totalCount, value); }
        }

        public MainViewModel()
        {
            TotalCount = _random.Next(0, 5000).ToString("00000");
        }
    }
}
