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
            Dictionary<string, string> Deck = new Dictionary<string, string>();
            
            //Spades
            Deck.Add("Ace", "Spades");
            Deck.Add("King", "Spades");
            Deck.Add("Queen", "Spades");
            Deck.Add("Jack", "Spades");
            Deck.Add("Ten", "Spades");
            Deck.Add("Nine", "Spades");
            Deck.Add("Eight", "Spades");
            Deck.Add("Seven", "Spades");
            Deck.Add("Six", "Spades");
            Deck.Add("Five", "Spades");
            Deck.Add("Four", "Spades");
            Deck.Add("Three", "Spades");
            Deck.Add("Two", "Spades");
            
            //Clubs
            Deck.Add("Ace", "Clubs");
            Deck.Add("King", "Clubs");
            Deck.Add("Queen", "Clubss");
            Deck.Add("Jack", "Clubs");
            Deck.Add("Ten", "Clubs");
            Deck.Add("Nine", "Clubs");
            Deck.Add("Eight", "Clubs");
            Deck.Add("Seven", "Clubs");
            Deck.Add("Six", "Clubs");
            Deck.Add("Five", "Clubs");
            Deck.Add("Four", "Clubs");
            Deck.Add("Three", "Clubs");
            Deck.Add("Two", "Clubs");


            //Hearts
            Deck.Add("Ace", "Hearts");
            Deck.Add("King", "Hearts");
            Deck.Add("Queen", "Hearts");
            Deck.Add("Jack", "Hearts");
            Deck.Add("Ten", "Hearts");
            Deck.Add("Nine", "Hearts");
            Deck.Add("Eight", "Hearts");
            Deck.Add("Seven", "Hearts");
            Deck.Add("Six", "Hearts");
            Deck.Add("Five", "Hearts");
            Deck.Add("Four", "Hearts");
            Deck.Add("Three", "Hearts");
            Deck.Add("Two", "Hearts");

            //Diamonds
            Deck.Add("Ace", "Diamonds");
            Deck.Add("King", "Diamonds");
            Deck.Add("Queen", "Diamonds");
            Deck.Add("Jack", "Diamonds");
            Deck.Add("Ten", "Diamonds");
            Deck.Add("Nine", "Diamonds");
            Deck.Add("Eight", "Diamonds");
            Deck.Add("Seven", "Diamonds");
            Deck.Add("Six", "Diamonds");
            Deck.Add("Five", "Diamonds");
            Deck.Add("Four", "Diamonds");
            Deck.Add("Three", "Diamonds");
            Deck.Add("Two", "Diamonds");

            Dictionary<string, string> Deck = new Dictionary<string, string>();

            //Spades
            Deck.Add("Ace", "Spades");
            Deck.Add("King", "Spades");
            Deck.Add("Queen", "Spades");
            Deck.Add("Jack", "Spades");
            Deck.Add("Ten", "Spades");
            Deck.Add("Nine", "Spades");
            Deck.Add("Eight", "Spades");
            Deck.Add("Seven", "Spades");
            Deck.Add("Six", "Spades");
            Deck.Add("Five", "Spades");
            Deck.Add("Four", "Spades");
            Deck.Add("Three", "Spades");
            Deck.Add("Two", "Spades");

            //Clubs
            Deck.Add("Ace", "Clubs");
            Deck.Add("King", "Clubs");
            Deck.Add("Queen", "Clubss");
            Deck.Add("Jack", "Clubs");
            Deck.Add("Ten", "Clubs");
            Deck.Add("Nine", "Clubs");
            Deck.Add("Eight", "Clubs");
            Deck.Add("Seven", "Clubs");
            Deck.Add("Six", "Clubs");
            Deck.Add("Five", "Clubs");
            Deck.Add("Four", "Clubs");
            Deck.Add("Three", "Clubs");
            Deck.Add("Two", "Clubs");


            //Hearts
            Deck.Add("Ace", "Hearts");
            Deck.Add("King", "Hearts");
            Deck.Add("Queen", "Hearts");
            Deck.Add("Jack", "Hearts");
            Deck.Add("Ten", "Hearts");
            Deck.Add("Nine", "Hearts");
            Deck.Add("Eight", "Hearts");
            Deck.Add("Seven", "Hearts");
            Deck.Add("Six", "Hearts");
            Deck.Add("Five", "Hearts");
            Deck.Add("Four", "Hearts");
            Deck.Add("Three", "Hearts");
            Deck.Add("Two", "Hearts");

            //Diamonds
            Deck.Add("Ace", "Diamonds");
            Deck.Add("King", "Diamonds");
            Deck.Add("Queen", "Diamonds");
            Deck.Add("Jack", "Diamonds");
            Deck.Add("Ten", "Diamonds");
            Deck.Add("Nine", "Diamonds");
            Deck.Add("Eight", "Diamonds");
            Deck.Add("Seven", "Diamonds");
            Deck.Add("Six", "Diamonds");
            Deck.Add("Five", "Diamonds");
            Deck.Add("Four", "Diamonds");
            Deck.Add("Three", "Diamonds");
            Deck.Add("Two", "Diamonds");

            //public const string imgPath = @"Cards/"
        }

        private void NewGameBTN_Click(object sender, RoutedEventArgs e)
        {
            








        }
    }
}
