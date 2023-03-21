using Klasy1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    
    public partial class MainWindow : Window

    {
        private Gracz gracz1 = new(100, 15, "", 10, true);
        private Przeciwnik przeciwnik1 = new (100,10,"przeciwnik potężny",true);
        public int iloscPrzeciwnikow = 1;

        

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
            var a = gracz1.Mana + "/15";

            
           
            hp_twoje_zmienne.Content = hp_gracza;
            hp_przeciwnika_zmienne.Content = hp_przeciwnika;
            nazwa_twoja.Text = nazwa_gracza;
            nazwa_przeciwnika_okienko.Text = nazwa_przeciwnika;
            mana_zmienna.Content = a;

         



            BitmapImage obrazek = new BitmapImage(); // odczytywanie plików można uznać jako odczytywanie obrazków 😎
            obrazek.BeginInit();
            
            


                int przeciwnik_wyświetlany = r1.Next(1, 3); // ten switch tak działa w dwóch piątych

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
            Random r1 = new Random();

            int c = r1.Next(5, 16);
            int d = r1.Next(5, 16);
            var a = przeciwnik1.Hp_przeciwnika - c ;
            hp_przeciwnika_zmienne.Content = a;
            przeciwnik1.Hp_przeciwnika = a;



            var b = gracz1.Hp - d;
            hp_twoje_zmienne.Content = b;
            gracz1.Hp = b;
            if(gracz1.Mana < 15) {
                gracz1.Mana += 1;
                mana_zmienna.Content = gracz1.Mana + "/15";
            }


            if (przeciwnik1.Hp_przeciwnika > 0)
            {
                log_bitwy.Text = "Uderzasz przeciwnikowi za" + " " + c + "" + "punktów obrażeń, lecz ten oddaje za" + " " + d + " " + "punktów obrażeń";
            }
            else if (przeciwnik1.Hp_przeciwnika <= 0)
            {
                przeciwnik1.Czy_żyje = false;
            }
            else if (gracz1.Hp <= 0)
            {
                gracz1.Czy_żyje = false; 
                
            }




            if (przeciwnik1.Hp_przeciwnika <= 0)
            {
                przeciwnik1.Czy_żyje = false;
                log_bitwy.Text = "Pokonałeś przeciwnika!";
                iloscPrzeciwnikow++;
                przeciwnik1.Nazwa_przeciwnika = "przeciwnik numer" + " " + iloscPrzeciwnikow;
                nazwa_przeciwnika_okienko.Text = przeciwnik1.Nazwa_przeciwnika;
            }
            else if (gracz1.Hp <= 0)
            {
                gracz1.Czy_żyje = false;
                log_bitwy.Text = "Zostałeś pokonany...";
            }
            if (!przeciwnik1.Czy_żyje)
            {
                przeciwnik1.Hp_przeciwnika = 100;
                przeciwnik1.Atak_przciwnika = 10;
                przeciwnik1.Nazwa_przeciwnika = "przeciwnik jakiś";
                przeciwnik1.Czy_żyje = true;
                log_bitwy.Text = "Przeciwnik się odradza...";

                BitmapImage obrazek = new BitmapImage();
                obrazek.BeginInit();




                int przeciwnik_wyświetlany = r1.Next(1, 3); // ten switch tak działa w dwóch piątych

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
            else if (!gracz1.Czy_żyje)
            {
                log_bitwy.Text = "Koniec gry!";
                System.Windows.Application.Current.Shutdown();
            }


        }

        private void button_def_Click(object sender, RoutedEventArgs e)
        {
            Random r1 = new Random();
            var c = r1.Next(1, 11);
            var r = r1.Next(5, 11);
            var a = przeciwnik1.Hp_przeciwnika - r;
            hp_przeciwnika_zmienne.Content = a;
            przeciwnik1.Hp_przeciwnika = a;
            var d = r1.Next(5, 16) - c;
            var b = gracz1.Hp - d;
            hp_twoje_zmienne.Content = b;
            gracz1.Hp = b;

            if (gracz1.Mana < 15)
            {
                gracz1.Mana += 1;
                mana_zmienna.Content = gracz1.Mana + "/15";
            }

            if (przeciwnik1.Hp_przeciwnika > 0)
            {
                log_bitwy.Text = "Uderzasz przeciwnikowi za" + " " + r + "" + "punktów obrażeń, i wznosisz tarczę broniąc"+" " + c + " " + "obrażeń, przez co przeciwnik zadaję ci tylko" + " "+ d + " " + "punktów obrażeń" ;
            }
            else if (przeciwnik1.Hp_przeciwnika <= 0)
            {
                przeciwnik1.Czy_żyje = false;
            }
            else if (gracz1.Hp <= 0)
            {
                gracz1.Czy_żyje = false;

            }


            if (przeciwnik1.Hp_przeciwnika <= 0)
            {
                przeciwnik1.Czy_żyje = false;
                log_bitwy.Text = "Pokonałeś przeciwnika!";
                iloscPrzeciwnikow++;
                przeciwnik1.Nazwa_przeciwnika = "przeciwnik numer" + " " + iloscPrzeciwnikow;
                nazwa_przeciwnika_okienko.Text = przeciwnik1.Nazwa_przeciwnika;
            }
            else if (gracz1.Hp <= 0)
            {
                gracz1.Czy_żyje = false;
                log_bitwy.Text = "Zostałeś pokonany...";
            }
            if (!przeciwnik1.Czy_żyje)
            {
                przeciwnik1.Hp_przeciwnika = 100;
                przeciwnik1.Atak_przciwnika = 10;
                przeciwnik1.Nazwa_przeciwnika = "przeciwnik jakiś";
                przeciwnik1.Czy_żyje = true;
                log_bitwy.Text = "Przeciwnik się odradza...";

                BitmapImage obrazek = new BitmapImage();
                obrazek.BeginInit();




                int przeciwnik_wyświetlany = r1.Next(1, 3); // ten switch tak działa w dwóch piątych

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
            else if (!gracz1.Czy_żyje)
            {
                log_bitwy.Text = "Koniec gry!";
                System.Windows.Application.Current.Shutdown();
            }

        }

        private void button_heal_Click(object sender, RoutedEventArgs e)
        {
            if (gracz1.Mana >= 5 && gracz1.Hp <= 90)
            {
                var a = gracz1.Mana -= 5;
                var b = gracz1.Hp += 20;

                gracz1.Hp = b;
                gracz1.Mana = a;

                hp_twoje_zmienne.Content = gracz1.Hp;
                mana_zmienna.Content = gracz1.Mana + "/15";
                



                if (przeciwnik1.Hp_przeciwnika > 0)
                {
                    log_bitwy.Text = "Przy użyciu magii uleczyłeś się 20 punktw zdrowia";
                }
                else if (przeciwnik1.Hp_przeciwnika <= 0)
                {
                    przeciwnik1.Czy_żyje = false;
                }
                else if (gracz1.Hp <= 0)
                {
                    gracz1.Czy_żyje = false;

                }


                if (przeciwnik1.Hp_przeciwnika <= 0)
                {
                    przeciwnik1.Czy_żyje = false;
                    log_bitwy.Text = "Pokonałeś przeciwnika!";
                    iloscPrzeciwnikow++;
                    przeciwnik1.Nazwa_przeciwnika = "przeciwnik numer" + " " + iloscPrzeciwnikow;
                    nazwa_przeciwnika_okienko.Text = przeciwnik1.Nazwa_przeciwnika;
                }
                else if (gracz1.Hp <= 0)
                {
                    gracz1.Czy_żyje = false;
                    log_bitwy.Text = "Zostałeś pokonany...";
                }
                if (!przeciwnik1.Czy_żyje)
                {
                    przeciwnik1.Hp_przeciwnika = 100;
                    przeciwnik1.Atak_przciwnika = 10;
                    przeciwnik1.Nazwa_przeciwnika = "przeciwnik jakiś";
                    przeciwnik1.Czy_żyje = true;
                    log_bitwy.Text = "Przeciwnik się odradza...";

                    BitmapImage obrazek = new BitmapImage();
                    obrazek.BeginInit();


                    Random r1 = new Random();

                    int przeciwnik_wyświetlany = r1.Next(1, 3);

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
                else if (!gracz1.Czy_żyje)
                {
                    log_bitwy.Text = "Koniec gry!";
                    System.Windows.Application.Current.Shutdown();
                }



            }
            else if (gracz1.Mana < 5)
            {
                log_bitwy.Text = "Masz zbyt mało many by się uleczyć";
            }
            else 
            {
                log_bitwy.Text = "Masz dużo punktów zdrowia nie potrzebujesz leczenia";
            }
           
        }

        private void button_run_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
