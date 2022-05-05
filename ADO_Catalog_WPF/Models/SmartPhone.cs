namespace ADO_Catalog_WPF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmartPhone")]
    public partial class SmartPhone : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _price;
        private string _company;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        [Required]
        [StringLength(100)]
        public string Name {
            get { return _name; }
            set
            { 
                _name = value; 
                OnPropertyChanged("Name");
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        [Required]
        [StringLength(50)]
        public string Company 
        {  
            get { return _company; }
            set
            {
                _company = value;
                OnPropertyChanged("Company");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
