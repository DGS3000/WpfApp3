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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1fg.Logic;

namespace WpfApp1fg
{

    

    public partial class MainWindow : Window
    {

        private AuthLogic authLogic = new AuthLogic();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Login = login.Text;
            string Password = password.Password;

            if (authLogic.Auth(Login, Password))
            {
                MessageBox.Show("ув");
                PWindow PWindow = new PWindow();
                PWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("teув");
            }
        }
    }
}
