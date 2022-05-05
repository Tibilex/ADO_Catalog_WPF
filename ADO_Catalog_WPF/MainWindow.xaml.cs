using ADO_Catalog_WPF.Models;
using ADO_Catalog_WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO_Catalog_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginPage _loginPage;
        //public RegistarionPage _registeredPage;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            //GridSubWindow.Children.Add(new MainWindow(GridSubWindow));
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
        private void Smartphone_MouseLeave(object sender, MouseEventArgs e) { Visibled(Smartphone); banerImage.Visibility = Visibility.Hidden; }
        private void Computers_MouseLeave(object sender, MouseEventArgs e) { Visibled(Computers); banerImage.Visibility = Visibility.Hidden; }
        private void PhotoAudioPS5_MouseEnter(object sender, MouseEventArgs e) { Visibled(PhotoAudioPS5); banerImage.Visibility = Visibility.Hidden; }
        private void Tv_MouseLeave(object sender, MouseEventArgs e) { Visibled(Tv); banerImage.Visibility = Visibility.Hidden; }
        private void Gadgets_MouseLeave(object sender, MouseEventArgs e) { Visibled(Gadgets); banerImage.Visibility = Visibility.Hidden; }
        private void Appliances_MouseEnter(object sender, MouseEventArgs e) { Visibled(Appliances); banerImage.Visibility = Visibility.Hidden; }

        private void Apple_MouseLeave(object sender, MouseEventArgs e) { Apple.Visibility = Visibility.Hidden; }
        private void Smartphone_MouseEnter(object sender, MouseEventArgs e) { Smartphone.Visibility = Visibility.Hidden; }
        private void Computers_MouseEnter(object sender, MouseEventArgs e) { Computers.Visibility = Visibility.Hidden; }
        private void PhotoAudioPS5_MouseLeave(object sender, MouseEventArgs e) { PhotoAudioPS5.Visibility = Visibility.Hidden; }
        private void Tv_MouseEnter(object sender, MouseEventArgs e) { Tv.Visibility = Visibility.Hidden; }
        private void Gadgets_MouseEnter(object sender, MouseEventArgs e) { Gadgets.Visibility = Visibility.Hidden; }
        private void Appliances_MouseLeave(object sender, MouseEventArgs e) { Appliances.Visibility = Visibility.Hidden; }

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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void Visibled(Grid grid)
        {
            foreach (Grid it in GridSubWindow.Children)
            {
                if (it == grid) it.Visibility = Visibility.Visible;
                else it.Visibility = Visibility.Hidden;
            }
        }
        
    }
}
