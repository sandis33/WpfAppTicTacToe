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

namespace WpfAppTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string turn = string.Empty;
        private int moves = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
            
        }

        private void InitializeGame()
        {
            turn = "X";
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;


            if(tb.Text != "X" && tb.Text != "O")
            {
                moves++;
                tb.Text = turn;
                CheckForWin();
                SwitchTurn();
            }       
        }

        private void SwitchTurn()
        {
            if (turn == "X")
            {
                turn = "O";
            }
            else
            {
                turn = "X";
            }
        }

        private void CheckForWin()
        {
            var winColor = Brushes.Orange;
        ///
        ///      Changes color of winning pattern.
        ///         

            if (tb1.Text != "   " && tb1.Text == tb2.Text && tb2.Text == tb3.Text)
            {
                tb1.Foreground = tb2.Foreground = tb3.Foreground = winColor;
                Won();
            }
            else if (tb4.Text != "   " && tb4.Text == tb5.Text && tb5.Text == tb6.Text)
            {
                tb4.Foreground = tb5.Foreground = tb6.Foreground = winColor;
                Won();
            }
            else if (tb7.Text != "   " && tb7.Text == tb8.Text && tb8.Text == tb9.Text)
            {
                tb7.Foreground = tb8.Foreground = tb9.Foreground = winColor;
                Won();
            }
            else if (tb1.Text != "   " && tb1.Text == tb4.Text && tb4.Text == tb7.Text)
            {
                tb1.Foreground = tb4.Foreground = tb7.Foreground = winColor;
                Won();
            }
            else if (tb2.Text != "   " && tb2.Text == tb5.Text && tb5.Text == tb8.Text)
            {
                tb2.Foreground = tb5.Foreground = tb8.Foreground = winColor;
                Won();
            }
            else if (tb3.Text != "   " && tb3.Text == tb6.Text && tb6.Text == tb9.Text)
            {
                tb3.Foreground = tb6.Foreground = tb9.Foreground = winColor;
                Won();
            }
            else if (tb1.Text != "   " && tb1.Text == tb5.Text && tb5.Text == tb9.Text)
            {
                tb1.Foreground = tb5.Foreground = tb9.Foreground = winColor;
                Won();
            }
            else if (tb3.Text != "   " && tb3.Text == tb5.Text && tb5.Text == tb7.Text)
            {
                tb3.Foreground = tb5.Foreground = tb7.Foreground = winColor;
                Won();
            }
            else if (moves == 9)
            {
                Tie();
            }
        ///
        ///      Checks for winner or tie and changes color of the winning pattern.
        ///
        }

        private void Won()
        ///
        ///      If there is winnner, displeys who won the game and makes restart button and quit button to appear.
        ///         
        {
            MessageBox.Show($"Game Over, {turn} Wins!");
            RestartButton.Visibility = Visibility.Visible;
            QuitButton.Visibility = Visibility.Visible;
        }

        private void Tie()
        ///
        ///      If there is tie, displays that it was a tie and makes restart button and quit button to appear.
        ///         
        {
            MessageBox.Show("It's a tie!");
            RestartButton.Visibility = Visibility.Visible;
            QuitButton.Visibility = Visibility.Visible;

        }
        private void Restart()
        ///
        ///      Actions for restarting the game.
        /// 
        {
            var startColor = Brushes.Black;
        ///
        ///      Changes starting color.
        ///
            tb1.Text = "   ";
            tb2.Text = "   ";
            tb3.Text = "   ";
            tb4.Text = "   ";
            tb5.Text = "   ";
            tb6.Text = "   ";
            tb7.Text = "   ";
            tb8.Text = "   ";
            tb9.Text = "   ";
        ///
        ///      Removes "X" and "O" from the grid.
        ///
            tb1.Foreground = tb2.Foreground = tb3.Foreground = startColor;
            tb4.Foreground = tb5.Foreground = tb6.Foreground = startColor;
            tb7.Foreground = tb8.Foreground = tb9.Foreground = startColor;
        ///
        ///      Changes back color from winners color to starting color.
        ///
            moves = 0;
        ///
        ///      Resets move counter back to 0.

            RestartButton.Visibility = Visibility.Collapsed;
            QuitButton.Visibility = Visibility.Collapsed;
        ///
        ///      Changes Restart button and Quit button back to being invisible after starting game.
        ///         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }
        ///
        ///     Funcions of Restart button when it is clicked.
        ///     
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        ///
        ///     Funcions of Quit button when it is clicked.
        ///     
    }
}
