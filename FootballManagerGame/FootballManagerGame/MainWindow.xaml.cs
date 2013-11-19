using System;
using System.Collections.Generic;
using System.IO;
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

namespace FootballManagerGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateClubButton_Click(object sender, RoutedEventArgs e)
        {
            Club club = generateClub();
            LobbyWindow lobby = new LobbyWindow(club);
            lobby.Show();
            this.Close();
        }

        private Club generateClub()
        {
            List<Player> squad = generateSquad();
            string clubName = clubNameTextBox.Text;
            string managerName = managerNameTextBox.Text;

            Club newClub = new Club(squad, clubName, managerName, squad.Count);
            return newClub;
        }

        private List<Player> generateSquad()
        {
            List<Player> playerList = new List<Player>();
            for (int i = 0; i < 20; i++)
            {
                if (i < 4)
                {
                    Player player = new Player(RNG.rand.Next(17, 21), clubNameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 11)
                {
                    Player player = new Player(RNG.rand.Next(21, 25), clubNameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 17)
                {
                    Player player = new Player(RNG.rand.Next(25, 29), clubNameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 20)
                {
                    Player player = new Player(RNG.rand.Next(29, 31), clubNameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
            }
            return playerList;
        }
    }
}
