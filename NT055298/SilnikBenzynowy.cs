﻿using System;
using Dziedziczenie;

namespace NT055298
{
    public class SilnikBenzynowy
    {
        public int MaxObroty { get; private set; }
        public int MinObroty { get; private set; }

        public int AktualneObroty = 1500;
        public int AktualnyBieg = 1;
        public int LiczbaBiegow { get; private set; }

        public void Obroty()
        {
            Console.WriteLine($"Aktualne obroty silnika: {AktualneObroty}"); 
        }
        
        public SilnikBenzynowy(int aktualneObroty, int liczbaBiegow):this()
        {
            AktualneObroty = aktualneObroty;
            LiczbaBiegow = liczbaBiegow;
        }

        protected SilnikBenzynowy()
        {
            MaxObroty = 6000;
            MinObroty = 800;
        }
    }
}