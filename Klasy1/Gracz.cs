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
        private int atak_gracza;

        public Gracz(int hp, int mana, string nazwa_gracza, int atak_gracza)
        {
            this.hp = hp;
            this.mana = mana;
            this.nazwa_gracza = nazwa_gracza;
            this.atak_gracza = atak_gracza;
        }

        public int Hp { get => hp; set => hp = value; }
        public int Mana { get => mana; set => mana = value; }
        public string Nazwa_gracza { get => nazwa_gracza; set => nazwa_gracza = value; }
        public int Atak_gracza { get => atak_gracza; set => atak_gracza = value; }
    }
}