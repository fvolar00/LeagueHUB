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
using System.Windows.Shapes;

namespace LeagueHUB_UI
{
    /// <summary>
    /// Interaction logic for Match.xaml
    /// </summary>
    public partial class Match : Window
    {
        List<Team> myTeams { get; set; }
        List<Referee> referees { get; set; }
        public Match()
        {
            InitializeComponent();
            using(LeagueContext context = new LeagueContext())
            {
                myTeams = context.Team.ToList();
                HomePicker.ItemsSource = myTeams;
                GuestPicker.ItemsSource = myTeams;
                HomePicker.DisplayMemberPath = "Name";
                HomePicker.SelectedValuePath = "Id";
                GuestPicker.DisplayMemberPath = "Name";
                GuestPicker.SelectedValuePath = "Id";
                referees =context.Referee.ToList();
                RefereePicker.ItemsSource = referees;
                RefereePicker.DisplayMemberPath = "Name";
                RefereePicker.SelectedValuePath = "Id";

            }
            DatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            using(LeagueContext context = new LeagueContext())
            {
                Game game = new Game();
                
                Team selectedHome = context.Team.Find(HomePicker.SelectedValue);
                Team selectedGuest = context.Team.Find(GuestPicker.SelectedValue);
                Referee selectedReferee = context.Referee.Find(RefereePicker.SelectedValue);
                int homescore = int.Parse(HomeGoals.Text);
                int guestscore = int.Parse(GuestGoals.Text);
                if ( selectedHome != selectedGuest)
                {
                    game.date = DatePicker.SelectedDate.Value.Date;
                    game.Home = selectedHome;
                    game.Referee = selectedReferee;
                    game.Guest = selectedGuest;
                    game.HomeScore = homescore;
                    game.GuestScore = guestscore;

                    selectedHome.GamesPlayed += 1;
                    selectedGuest.GamesPlayed += 1;
                    selectedHome.GoalsScored += homescore;
                    selectedHome.GoalsConceded += guestscore;
                    selectedGuest.GoalsScored += guestscore;
                    selectedGuest.GoalsConceded += homescore;

                    if (homescore > guestscore)
                    {
                        selectedHome.Points += 3;
                        selectedHome.Wins += 1;
                        selectedGuest.Losses += 1;
                    }
                    else if (homescore == guestscore)
                    {
                        selectedHome.Points += 1;
                        selectedGuest.Points += 1;
                        selectedHome.Draws += 1;
                        selectedGuest.Draws += 1;
                    }
                    else
                    {
                        selectedGuest.Points += 3;
                        selectedGuest.Wins += 1;
                        selectedHome.Losses += 1;
                    }
                    context.Game.Add(game);
                    context.SaveChanges();
                }
                else
                {
                    ErrorBox.Text = "Team cannot play against itself!";
                }

            }
        }
    }
}
