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
        List<Player> playerList = new List<Player>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            generateTeam();
            teamListBox.ItemsSource = playerList;
        }

        private void generateTeam()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i < 4)
                {
                    Player player = new Player(RNG.rand.Next(17, 21), clubnameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 11)
                {
                    Player player = new Player(RNG.rand.Next(21, 25), clubnameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 17)
                {
                    Player player = new Player(RNG.rand.Next(25, 29), clubnameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
                else if (i < 20)
                {
                    Player player = new Player(RNG.rand.Next(29, 31), clubnameTextBox.Text, 0d, true);
                    playerList.Add(player);
                }
            }
        }
    }
}
