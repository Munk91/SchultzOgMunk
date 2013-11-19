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

namespace FootballManagerGame
{
    /// <summary>
    /// Interaction logic for LobbyWindow.xaml
    /// </summary>
    public partial class LobbyWindow : Window
    {
        #region Fields

        List<Club> listOfClubs = new List<Club>();

        #endregion

        #region Constructor

        public LobbyWindow(Club club)
        {
            InitializeComponent();
            clubNameLabel.Content = club.ClubName;
            managerNameLabel.Content = club.ManagerName;
            squadListBox.ItemsSource = club.Squad;
            squadSizeLabel.Content = club.Squad.Count;
        }

        #endregion

        #region Events

        

        #endregion

        #region Private Methods

        

        #endregion

        
    }
}
