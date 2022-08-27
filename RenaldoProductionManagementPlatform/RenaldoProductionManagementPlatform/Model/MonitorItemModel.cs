using RenaldoProductionManagementPlatform.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenaldoProductionManagementPlatform.Model
{
    internal class MonitorItemModel:NotifyBase
    {
        public string Header { get; set; }
        private double _value;
        public double Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
    }
}
