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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ppEntities context;
        public Window1(ppEntities context, ParticipantsOfTheWar participantsOfTheWar)
        {
            InitializeComponent();
            this.context = context;
            CmbGender.ItemsSource = context.Genders.ToList();
            CmbMilitaryRank.ItemsSource = context.MilitaryRanks.ToList();
            this.DataContext = participantsOfTheWar;
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            SaveImage();
            context.SaveChanges();
            this.Close();
        }
        private void SaveImage()
        {

        }
    }
}
