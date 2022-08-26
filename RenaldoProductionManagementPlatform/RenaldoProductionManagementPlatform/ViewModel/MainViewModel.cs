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

        private string _productionTotalCount;
        public string ProductionTotalCount
        {
            get { return _productionTotalCount; }
            set { SetProperty(ref _productionTotalCount, value); }
        }

        public MainViewModel()
        {
            TotalCount = _random.Next(10, 500).ToString("0000");
            ProductionTotalCount = _random.Next(1000, 10000).ToString("00000");
        }
    }
}
