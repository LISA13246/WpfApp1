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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ppEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new ppEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridParticipantsOfTheWar.ItemsSource = context.ParticipantsOfTheWars.ToList();
        }

        private void BtnAdateData_Click(object sender, RoutedEventArgs e)
        {
            var NEWParticipantsOfTheWar = new ParticipantsOfTheWar();
            context.ParticipantsOfTheWars.Add(NEWParticipantsOfTheWar);
            var EditWindow = new Window1 (context, NEWParticipantsOfTheWar);
            EditWindow.ShowDialog();
            MessageBox.Show("Данные добавлены");
        }

        private void BtnDaleteData_Click(object sender, RoutedEventArgs e)
        {
            var currentParticipantsOfTheWar = DataGridParticipantsOfTheWar.SelectedItem as ParticipantsOfTheWar;
            if (currentParticipantsOfTheWar == null)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.ParticipantsOfTheWars.Remove(currentParticipantsOfTheWar);
                context.SaveChanges();
                MessageBox.Show("Данные удалены");
                ShowTable();
            }
        }

        private void DataGridParticipantsOfTheWar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var ccurrentParticipantsOfTheWar = BtnEdit.DataContext as ParticipantsOfTheWar;
            var EditWindow = new Window1(context, ccurrentParticipantsOfTheWar);
            EditWindow.ShowDialog();
            MessageBox.Show("Данные изменены");
        }

        private void BtnAwards_Click(object sender, RoutedEventArgs e)
        {
           Awards award = new Awards();
            award.Show();
            this.Hide();
        }
    }
}
