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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            generateTeam();
        }

        private void generateTeam()
        {
            for (int i = 0; i < 20; i++)
            {
                Player player = new Player(0, clubnameTextBox.Text, 0d, true);
                //player.Name = "lars";
                player.Age = 2;
                teamTextBlock.Text += player.ToString() + "\n";
            }
        }
    }
}
