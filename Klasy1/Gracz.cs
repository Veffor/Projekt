using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy1
{
    public class Gracz
    {
        private int hp;
        private int mana;
        private string nazwa_gracza;
        private int atak_gracza; // atak gracza i atak przeciwnika jest właściwie nie potrzebny, ale nie chce mi się tego usuwać
        private bool czy_żyje = true;

        public Gracz(int hp, int mana, string nazwa_gracza, int atak_gracza, bool czy_żyje)
        {
            this.hp = hp;
            this.mana = mana;
            this.nazwa_gracza = nazwa_gracza;
            this.atak_gracza = atak_gracza;
            this.czy_żyje = czy_żyje;
        }

        public int Hp { get => hp; set => hp = value; }
        public int Mana { get => mana; set => mana = value; }
        public string Nazwa_gracza { get => nazwa_gracza; set => nazwa_gracza = value; }
        public int Atak_gracza { get => atak_gracza; set => atak_gracza = value; }
        public bool Czy_żyje { get => czy_żyje; set => czy_żyje = value; }
    }
}