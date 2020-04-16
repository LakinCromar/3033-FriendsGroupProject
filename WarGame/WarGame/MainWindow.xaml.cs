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

namespace WarGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<string, int> Deck = new Dictionary<string, int>();

            //Spades
            Deck.Add("A♠", 14);
            Deck.Add("K♠", 13);
            Deck.Add("Q♠", 12);
            Deck.Add("J♠", 11);
            Deck.Add("10♠", 10);
            Deck.Add("9♠", 9);
            Deck.Add("8♠", 8);
            Deck.Add("7♠", 7);
            Deck.Add("6♠", 6);
            Deck.Add("5♠", 5);
            Deck.Add("4♠", 4);
            Deck.Add("3♠", 3); 
            Deck.Add("2♠", 2);

            //Clubs
            Deck.Add("A♣", 14);
            Deck.Add("K♣", 13);
            Deck.Add("Q♣", 12);
            Deck.Add("J♣", 11);
            Deck.Add("10♣", 10);
            Deck.Add("9♣", 9);
            Deck.Add("8♣", 8);
            Deck.Add("7♣", 7);
            Deck.Add("6♣", 6);
            Deck.Add("5♣", 5);
            Deck.Add("4♣", 4);
            Deck.Add("3♣", 3);
            Deck.Add("2♣", 2);


            //Hearts
            Deck.Add("A♥", 14);
            Deck.Add("K♥", 13);
            Deck.Add("Q♥", 12);
            Deck.Add("J♥", 11);
            Deck.Add("10♥", 10);
            Deck.Add("9♥", 9);
            Deck.Add("8♥", 8);
            Deck.Add("7♥", 7);
            Deck.Add("6♥", 6);
            Deck.Add("5♥", 5);
            Deck.Add("4♥", 4);
            Deck.Add("3♥", 3);
            Deck.Add("2♥", 2);

            //Diamonds
            Deck.Add("A♦", 14);
            Deck.Add("K♦", 13);
            Deck.Add("Q♦", 12);
            Deck.Add("J♦", 11);
            Deck.Add("10♦", 10);
            Deck.Add("9♦", 9);
            Deck.Add("8♦", 8);
            Deck.Add("7♦", 7);
            Deck.Add("6♦", 6);
            Deck.Add("5♦", 5);
            Deck.Add("4♦", 4);
            Deck.Add("3♦", 3);
            Deck.Add("2♦", 2);




        }
        private void NewGameBTN_Click(object sender, RoutedEventArgs e)
        {
            








        }
    }
}