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
    /// Логика взаимодействия для SbrosParoyla.xaml
    /// </summary>
    public partial class SbrosParoyla : Window
    {
        public SbrosParoyla()
        {
            InitializeComponent();
        }

        private void RecoverBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вам выслан новый пароль на " + MailPhoneTb.Text);
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
