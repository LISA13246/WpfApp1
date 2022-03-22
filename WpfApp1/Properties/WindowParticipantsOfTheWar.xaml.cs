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

namespace WpfApp1.Properties
{
    /// <summary>
    /// Логика взаимодействия для WindowParticipantsOfTheWar.xaml
    /// </summary>
    public partial class WindowParticipantsOfTheWar : Window
    {
        ppEntities context;
        public WindowParticipantsOfTheWar(ppEntities context, ParticipantsOfTheWar participantsOfTheWar)
        {
            InitializeComponent();
          
            this.context = context;
            CmbGender.ItemsSource = context.Genders.ToList();
            CmbMilitaryRank.ItemsSource = context.MilitaryRanks.ToList();
            this.DataContext = participantsOfTheWar;
        }

        private void SaveImage()
        {
            SaveImage();
            context.SaveChanges();
            this.Close();
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
