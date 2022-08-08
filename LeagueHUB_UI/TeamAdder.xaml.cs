using LeagueHUB_infrastructure;
using Microsoft.Data.SqlClient;
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

namespace LeagueHUB_UI
{
    /// <summary>
    /// Interaction logic for TeamAdder.xaml
    /// </summary>
    public partial class TeamAdder : Window
    {
        public TeamAdder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LeagueContext context = new LeagueContext();
            var teamname = teamName.Text;
            var coachname = coachName.Text;

            if (teamname != null && coachname != null)
            {
                //Team team = new Team() { Name = teamname };
                //team.Coach = new Coach() { Name = coachname };
                //context.Team.Add(team);
                //context.SaveChanges();

                Team team = new Team() { Name = teamname };
                Coach coach = new Coach() { Name = coachname };
                team.Coach = coach;
                context.Team.Add(team);
                context.SaveChanges();
                context.Coach.Add(coach);
                context.SaveChanges();
            }
        }
       
    }
}
