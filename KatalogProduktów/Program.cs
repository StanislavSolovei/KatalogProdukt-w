using KatalogProduktów;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz" };
double[] ceny = { 899.00, 249.50, 379.00, 189.99 };

Produkt procesor = new Produkt("AMD Ryzen", 899.99, "Podzespoły", 10);

Produkt ram = new Produkt("Pamięć RAM", 249.50, "Podzespoły", 20);

Produkt ssd = new Produkt("Dysk SSD", 397.00, "Podzespoły", 15);

Produkt zasilacz = new Produkt("Zasilacz", 189.99, "Podzespoły", 5);

Produkt[] produkty = {procesor, ram, ssd, zasilacz};

double minimalnaCena = produkty[0].Cena;
double maksymalnaCena = produkty[0].Cena;
double srednia = 0;
int licznik = 0;
double suma = 0;

foreach (Produkt produkt in produkty)
{
    produkt.WypiszProdukt();

    if (minimalnaCena > produkt.Cena)
    {
        minimalnaCena = produkt.Cena;
    }
    else if (maksymalnaCena < produkt.Cena)
    {
        maksymalnaCena = produkt.Cena;
    }
        
    suma = suma + produkt.Cena;
    licznik++;
    if(licznik > 0)
    {
        srednia = suma / licznik;
    }
    for (int i = produkt.Ilosc; i > 0; i--)
    {
        produkt.Sprzedaj();
    }

}
double wartoscMagazynu = Produkt.ObliczWartoscMagazynu(produkty);

Console.WriteLine($"Najniższa cena: {minimalnaCena}");
Console.WriteLine($"Największa cena: {maksymalnaCena}");
Console.WriteLine($"Średnia cena: {srednia:f2} zł");
Console.WriteLine($"Suma wartości magazynu dla wszystkich produktów: {wartoscMagazynu:f2} zł");




//int licznik = 0;
//double suma = 0;

//for (int i = 0; i < nazwy.Length; i++)
//{
//    // Do sumy trafiają tylko produkty droższe niż 200 zł
//    if (ceny[i] > 200)
//    {
//        suma = suma + ceny[i];
//        // po drugim obiegu suma wynosi 1148.5
//        licznik++;
//    }
//}

//// Uwaga: przy pustym liczniku byłoby dzielenie przez zero
//double srednia = suma / licznik;
//Console.WriteLine($"Ilość produktów w bazie: {nazwy.Length}");
//Console.WriteLine($"Średnia cena: {srednia:C} zł z {licznik} produktów"); 