using RenaldoProductionManagementPlatform.Base;
using RenaldoProductionManagementPlatform.Model;
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

        private string _defectiveItemsTotalCount;
        public string DefectiveItemsTotalCount
        {
            get { return _defectiveItemsTotalCount; }
            set { SetProperty(ref _defectiveItemsTotalCount, value); }
        }

        public List<MonitorItemModel> Environment { get; set; }

        public MainViewModel()
        {
            TotalCount = _random.Next(10, 500).ToString("0000");
            var ProductionTotalCountInt = _random.Next(1000, 20000);
            ProductionTotalCount = ProductionTotalCountInt.ToString("00000");
            DefectiveItemsTotalCount = (0.01 * ProductionTotalCountInt * _random.Next(3, 9)).ToString("0000");

            // init Environment
            Environment = new List<MonitorItemModel>();
            Environment.Add(new MonitorItemModel { Header = "PM 2.5 (m³)" });
            Environment.Add(new MonitorItemModel { Header = "CO (ppm)" });
            Environment.Add(new MonitorItemModel { Header = "H2S (ppm)" }); 
            Environment.Add(new MonitorItemModel { Header = "Temprature (°C)" });
            Environment.Add(new MonitorItemModel { Header = "Humidity (%)" });
            Environment.Add(new MonitorItemModel { Header = "Illumination (%)" });

            Environment[0].Value = Math.Round(_random.NextDouble() * 0.01, 3);
            Environment[1].Value = Math.Round(_random.NextDouble() * 0.03, 4);
            Environment[2].Value = Math.Round(_random.NextDouble() * 0.02, 4);
            Environment[3].Value = _random.Next(5, 30);
            Environment[4].Value = Math.Round(_random.NextDouble() * 0.1, 4);
            Environment[5].Value = Math.Round(10 * _random.NextDouble(), 2);
        }
    }
}
