using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy1
{
    public class Przeciwnik
    {
        private int hp_przeciwnika;
        private int atak_przciwnika;
        private string nazwa_przeciwnika;

        public Przeciwnik(int hp_przeciwnika, int atak_przciwnika, string nazwa_przeciwnika)
        {
            this.hp_przeciwnika = hp_przeciwnika;
            this.atak_przciwnika = atak_przciwnika;
            this.nazwa_przeciwnika = nazwa_przeciwnika;
        }

        public int Hp_przeciwnika { get => hp_przeciwnika; set => hp_przeciwnika = value; }
        public int Atak_przciwnika { get => atak_przciwnika; set => atak_przciwnika = value; }
        public string Nazwa_przeciwnika { get => nazwa_przeciwnika; set => nazwa_przeciwnika = value; }
    }
}
