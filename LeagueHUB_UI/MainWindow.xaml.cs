using LeagueHUB_infrastructure;
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

namespace LeagueHUB_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Team> teams;

        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var secondWindow = new Match();
            secondWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var secondWindow = new TeamAdder();
            secondWindow.Show();
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddReferee_Click(object sender, RoutedEventArgs e)
        {
            var secondWindow = new RefereeAdder();
            secondWindow.Show();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            using (LeagueContext context = new LeagueContext())
            {
                teams = context.Team.ToList();
                Table.ItemsSource = teams;

            }
        }
    }
}
