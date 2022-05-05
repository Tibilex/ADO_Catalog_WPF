using ADO_Catalog_WPF.DB;
using ADO_Catalog_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace ADO_Catalog_WPF.ViewModels
{
    public class PhoneViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ProductBlockButton> Block { get; set; }
        
        private string _blockName;
        private string _blockProduct;
        private int _blockPrice;
        private MainWindow _mainWindow;

        public string BlockName { get { return _blockName; } 
            set 
            {
                _blockName = value;
                OnPropertyChanged("BlockName");
            }
        }
        public string BlockProduct { get { return _blockProduct; } 
            set
            { 
                _blockProduct = value;
                OnPropertyChanged("BlockProduct");
            } 
        }

        public int BlockPrice { get { return _blockPrice; } 
            set
            {
                _blockPrice = value;
                OnPropertyChanged("BlockPrice");
            }
        }
        //public PhoneViewModel(string productName, int price) { }
        public PhoneViewModel()
        {
            //Block = new ObservableCollection<ProductBlockButton>();
        }
        public PhoneViewModel(MainWindow main)
        {
            _mainWindow = main;
            ProductBlock(_mainWindow.New);
        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ProductBlock(Grid grid)
        {
            
            foreach (Button it in grid.Children)
            {
                foreach (ProductBlockButton iterator in ConectionBlockButton.GetTopCatalog())
                {
                    if (it.Name.ToString() == iterator.ProductBlock)
                    {
                        Block = new ObservableCollection<ProductBlockButton>
                        {
                            new ProductBlockButton{ ProductName = iterator.ProductName, Price = iterator.Price}
                        };
                        //PhoneViewModel.Block.Add(new ProductBlockButton { ProductName = iterator.ProductName, Price = iterator.Price });
                        //PhoneViewModel.Block.Add(new ProductBlockButton { ProductName = iterator.ProductName.ToString(), Price = iterator.Price });
                        //PhoneViewModel.BlockName = iterator.ProductName.ToString();
                        //PhoneViewModel.BlockPrice = iterator.Price;
                    };
                }

            }
        }
    }
}
