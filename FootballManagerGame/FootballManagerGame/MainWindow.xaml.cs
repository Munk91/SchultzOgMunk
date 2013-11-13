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

        private string generateName()
        {
            List<string> firstNames = new List<string>(File.ReadAllLines("firstNames.txt"));
            List<string> secondNames = new List<string>(File.ReadAllLines("secondNames.txt"));
            Random rand = new Random();

            return firstNames[rand.Next(0, firstNames.Count)] + " " + secondNames[rand.Next(0, secondNames.Count)];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            generateTeam();
        }

        private void generateTeam()
        {
            for (int i = 0; i < 20; i++)
            {
                Player player = new Player(generateName(), 0, clubnameTextBox.Text, 0d, true);
                teamTextBlock.Text += player.ToString() + "\n";
            }
        }
    }
}
