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

namespace OOP_Exercise_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()

        {
            InitializeComponent();
        }


        private void button_enter_Click(object sender, RoutedEventArgs e)
        {
            textBox_greeting.Content = "Hello, Gamer!";
        }

        private void button_play_Click(object sender, RoutedEventArgs e)
        {
            GamesApp gamesApp = new GamesApp();
            gamesApp.beginGamesApp();

            listBox_list_games.Items.Add("Крестики-нолики");
            listBox_list_games.Items.Add("Виселица");
            listBox_list_games.Items.Add("Пасьянс");
            listBox_list_games.Items.Add("Змейка");
            listBox_list_games.Items.Add("Морской бой");
            listBox_list_games.Items.Add("Сапёр");

            listBox_queue_games.Items.Add("Морской бой");
            listBox_queue_games.Items.Add("Сапёр");
            listBox_queue_games.Items.Add("Крестики-нолики");
            listBox_queue_games.Items.Add("Змейка");
            listBox_queue_games.Items.Add("Виселица");
            listBox_queue_games.Items.Add("Пасьянс");

            listBox_rating.Items.Add("Biba");
            listBox_rating.Items.Add("Boba");
            listBox_rating.Items.Add("Igor");
            listBox_rating.Items.Add("Simon");
            listBox_rating.Items.Add("Nikita");
        }
    }

}

