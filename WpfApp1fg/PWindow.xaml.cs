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

namespace WpfApp1fg
{

    public partial class PWindow : Window
    {

        private ShopDBDGREntities db = new ShopDBDGREntities();
        public PWindow()
        {
            InitializeComponent();

            LoadInvent();
        }


        private void LoadInvent()
        {

            UsersData.ItemsSource = db.Invent.ToList();


        }




        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Invent = UsersData.SelectedItem as Invent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UsersData.SelectedItem is Invent selectedInvent)
            {

                db.Invent.Remove(selectedInvent);
                db.SaveChanges();
                LoadInvent();
                MessageBox.Show("успешноудал");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string login = log.Text.Trim();
            string password = pas.Text.Trim();

            {
                Invent newUser = new Invent
                {
                    Name = login,
                    Type = password,

                };

                db.Invent.Add(newUser);
                db.SaveChanges();
                LoadInvent();
                MessageBox.Show("инвентарь добавлен!");
            }
        }
    }
}
