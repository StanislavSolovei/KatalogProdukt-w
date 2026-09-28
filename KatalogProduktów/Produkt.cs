using System;
using System.Collections.Generic;
using System.Text;

namespace KatalogProduktów
{
    internal class Produkt
    {
        private string _nazwa;
        public string Nazwa
        {
            get { return _nazwa; }
            set
            {
                if (value == String.Empty)
                {
                    _nazwa = "Brak nazwy";
                    throw new ArgumentException("Nazwa nie moży być pusta.");
                }
                else
                {
                    _nazwa = value;
                }
            }
        }
        private double _cena;
        public double Cena
        {
            get { return _cena; }
            set
            {
                if (value < 0)
                {
                    _cena = 0;
                    throw new ArgumentException("Cena nie może być ujemna.");
                } 
                else
                {
                    _cena = value;
                }
            }
        }
        public string Kategoria;
        public int Ilosc;

        public double WartoscMagazynu
        {
            get { return _cena * Ilosc; }
        }
    }
}
