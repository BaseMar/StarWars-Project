using StarWars_Project.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StarWars_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationMenu_O = new NavigationMenu();
        }

        public NavigationMenu NavigationMenu_O { get; set; }

        private void btnCharacterSheet_Click(object sender, RoutedEventArgs e)
        {
            DataContext = NavigationMenu_O.CharacterSheetVM_O;
        }

        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            DataContext = NavigationMenu_O.MapVM_O;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = NavigationMenu_O.SettingsVM_O;
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            DataContext = NavigationMenu_O.MusicVM_O;
        }

        private void btnMonsters_Click(object sender, RoutedEventArgs e)
        {
            DataContext = NavigationMenu_O.MonstersVM_O;
        }
    }
}