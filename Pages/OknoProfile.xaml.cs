using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ShopMag.Pages
{
    /// <summary>
    /// Логика взаимодействия для OknoProfile.xaml
    /// </summary>
    public partial class OknoProfile : Window
    {
        public OknoProfile()
        {
            InitializeComponent();
            LViewSklad.ItemsSource = AppData.Helpers.ClassConnect.panas.Discs.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            Korzina Korzina = new Korzina();
            Korzina.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Close();
        }
    }
}
