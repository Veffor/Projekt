using Klasy1;
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

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Random r1 = new Random();
            int atak_gracza1 = r1.Next(10, 50);
            int atak_przeciwnika = r1.Next(5, 40);

            InitializeComponent();
            int hp_gracza = 100;
            int hp_przeciwnika = 100;

            string nazwa_gracza = "gracz numer 1";
            string nazwa_przeciwnika = "przeciwnik numer 1";

            Gracz gracz1 = new(hp_gracza,20,nazwa_gracza, atak_gracza1);
            Przeciwnik przeciwnik1 = new(hp_przeciwnika, atak_przeciwnika, nazwa_przeciwnika);
           
            hp_twoje_zmienne.Content = hp_gracza;
            hp_przeciwnika_zmienne.Content = hp_przeciwnika;
            nazwa_twoja.Text = nazwa_gracza;
            nazwa_przeciwnika_okienko.Text = nazwa_przeciwnika;


            BitmapImage obrazek = new BitmapImage();
            obrazek.BeginInit();
            
            


                int przeciwnik_wyświetlany = r1.Next(1, 3); // ten switch tak działa w jednej czwartej

                switch (przeciwnik_wyświetlany)
                {
                    case 1:
                    obrazek.UriSource = new Uri("/enemy1.png", UriKind.Relative);
                        break;
                    case 2:
                    obrazek.UriSource = new Uri("/enemy2.png", UriKind.Relative);
                    break;
                    
                   
                }
            obrazek.EndInit();
            zdj_przeciwnika.Source = obrazek;


        }

        private void button_atak_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
