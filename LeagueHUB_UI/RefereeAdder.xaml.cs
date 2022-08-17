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
    /// Interaction logic for RefereeAdder.xaml
    /// </summary>
    public partial class RefereeAdder : Window
    {
        public RefereeAdder()
        {
            InitializeComponent();
        }

        private void AddRef_Click(object sender, RoutedEventArgs e)
        {
            using(LeagueContext context = new LeagueContext())
            {
                if (Ref.Text != null)
                {
                    Referee referee = new Referee() { Name=Ref.Text};
                    context.Add(referee);
                    context.SaveChanges();

                }
            }
        }
    }
}
