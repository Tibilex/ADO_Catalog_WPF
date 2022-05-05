using ADO_Catalog_WPF.DB;
using ADO_Catalog_WPF.Models;
using ADO_Catalog_WPF.View;
using ADO_Catalog_WPF.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ADO_Catalog_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginPage _loginPage;
        public PhoneViewModel PhoneViewModel = new PhoneViewModel();
        //public RegistarionPage _registeredPage;

        public MainWindow()
        {
            InitializeComponent();
            //GridSubWindow.Children.Add(new MainWindow(GridSubWindow));
            //ProductBlock(New);
            PhoneViewModel PhoneViewModel = new PhoneViewModel(this);

        //buttonLogin.Click += ButtonLogin_Click;

        Apple.MouseEnter += Apple_MouseEnter;
            Apple.MouseLeave += Apple_MouseLeave;
            Smartphone.MouseEnter += Smartphone_MouseEnter;
            Smartphone.MouseLeave += Smartphone_MouseLeave;
            Computers.MouseEnter += Computers_MouseEnter;
            Computers.MouseLeave += Computers_MouseLeave;
            PhotoAudioPS5.MouseEnter += PhotoAudioPS5_MouseEnter;
            PhotoAudioPS5.MouseLeave += PhotoAudioPS5_MouseLeave;
            Tv.MouseEnter += Tv_MouseEnter;
            Tv.MouseLeave += Tv_MouseLeave;
            Gadgets.MouseEnter += Gadgets_MouseEnter;
            Gadgets.MouseLeave += Gadgets_MouseLeave;
            Appliances.MouseEnter += Appliances_MouseEnter;
            Appliances.MouseLeave += Appliances_MouseLeave;
        }

        private void Apple_MouseEnter(object sender, MouseEventArgs e) { Visibled(Apple); banerImage.Visibility = Visibility.Hidden; }
        private void Smartphone_MouseEnter(object sender, MouseEventArgs e) { Visibled(Smartphone); banerImage.Visibility = Visibility.Hidden; }
        private void Computers_MouseEnter(object sender, MouseEventArgs e) { Visibled(Computers); banerImage.Visibility = Visibility.Hidden; }
        private void PhotoAudioPS5_MouseEnter(object sender, MouseEventArgs e) { Visibled(PhotoAudioPS5); banerImage.Visibility = Visibility.Hidden; }
        private void Tv_MouseEnter(object sender, MouseEventArgs e) { Visibled(Tv); banerImage.Visibility = Visibility.Hidden; }
        private void Gadgets_MouseEnter(object sender, MouseEventArgs e) { Visibled(Gadgets); banerImage.Visibility = Visibility.Hidden; }
        private void Appliances_MouseEnter(object sender, MouseEventArgs e) { Visibled(Appliances); banerImage.Visibility = Visibility.Hidden; }

        private void Apple_MouseLeave(object sender, MouseEventArgs e) { Apple.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void Smartphone_MouseLeave(object sender, MouseEventArgs e) { Smartphone.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void Computers_MouseLeave(object sender, MouseEventArgs e) { Computers.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void PhotoAudioPS5_MouseLeave(object sender, MouseEventArgs e) { PhotoAudioPS5.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void Tv_MouseLeave(object sender, MouseEventArgs e) { Tv.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void Gadgets_MouseLeave(object sender, MouseEventArgs e) { Gadgets.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }
        private void Appliances_MouseLeave(object sender, MouseEventArgs e) { Appliances.Visibility = Visibility.Hidden; banerImage.Visibility = Visibility.Visible; }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_loginPage == null)
            {
                _loginPage = new LoginPage();
                banerImage.Visibility = Visibility.Hidden;
                MainFrame.Content = _loginPage;
            }
            else
            {
                banerImage.Visibility = Visibility.Visible;
                _loginPage = null;
            }
        }
        private void Visibled(Grid grid)
        {
            foreach (Grid it in GridSubWindow.Children)
            {
                if (it == grid) it.Visibility = Visibility.Visible;
                else it.Visibility = Visibility.Hidden;
            }
            foreach(ListView it in grid.Children)
            {
                List<string> list = new List<string>();
                it.ItemsSource = list;
                foreach (CategoryListView iterator in ConectionListView.GetTopCatalog())
                {
                    if (it.Name.ToString() == iterator.Category) list.Add(iterator.ProductName);
                }
                it.Items.Refresh();
            }
        }

        //private void ProductBlock(Grid grid)
        //{

        //    foreach (Button it in grid.Children)
        //    {
        //        foreach (ProductBlockButton iterator in ConectionBlockButton.GetTopCatalog())
        //        {
        //            if (it.Name.ToString() == iterator.ProductBlock)
        //            {
        //                //PhoneViewModel.Block.Add(new ProductBlockButton { ProductName = iterator.ProductName, Price = iterator.Price });
        //                //PhoneViewModel.Block.Add(new ProductBlockButton {ProductName = iterator.ProductName.ToString(), Price = iterator.Price});
        //                PhoneViewModel.BlockName = iterator.ProductName.ToString();
        //                PhoneViewModel.BlockPrice = iterator.Price;
        //            };
        //        }
               
        //    }
        //}
    }
}
