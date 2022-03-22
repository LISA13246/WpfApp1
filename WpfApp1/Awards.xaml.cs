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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Awards.xaml
    /// </summary>
    public partial class Awards : Window
    {
        ppEntities context;
        public Awards()
        {
            InitializeComponent();
            context = new ppEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridAward.ItemsSource = context.Awards.ToList();
           
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void DataGridAward_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdateData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDaleteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
