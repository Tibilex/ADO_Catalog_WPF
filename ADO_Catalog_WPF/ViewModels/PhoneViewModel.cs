using ADO_Catalog_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Catalog_WPF.ViewModels
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        public SmartPhone smartPhone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<SmartPhone> Phones { get; set; }
        public PhoneViewModel()
        {
            //Phones = new ObservableCollection<SmartPhone>
            //{
            //    new SmartPhone {id = 1, Name = "Galaxy S20", Company = "Samsung", Price = 35000}
            //};
            Phones = new ObservableCollection<SmartPhone>
            {
                new SmartPhone {id = 1, Name = "Смартфон Xiaomi Mi 11 Pro 8/256GB (Purple) CN w/Global ROM", Company = "Samsung", Price = 35000}
            };

        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
