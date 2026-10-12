using KatalogProduktów;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz" };
double[] ceny = { 899.00, 249.50, 379.00, 189.99 };

Produkt procesor = new Produkt("AMD Ryzen", 899.99, "Podzespoły", 10);

Produkt ram = new Produkt("Pamięć RAM", 249.50, "Podzespoły", 20);

Produkt ssd = new Produkt("Dysk SSD", 397.00, "Podzespoły", 15);

Produkt zasilacz = new Produkt("Zasilacz", 189.99, "Podzespoły", 5);

Produkt[] produkty = {procesor, ram, ssd, zasilacz};
//pusta tablica na 10 produktów
Produkt[] produkty2 = new Produkt[10];
//jeśli chcemy listę to:
List<Produkt> listaProduktow = new List<Produkt>();
//mając liste dodajemy do niej produkty metodą Add
listaProduktow.Add(procesor);
listaProduktow.Add(ram);
listaProduktow.Add(ssd);
listaProduktow.Add(zasilacz);

double minimalnaCena = produkty[0].Cena;
double maksymalnaCena = produkty[0].Cena;
double srednia = 0;
int licznik = 0;
double suma = 0;

foreach (Produkt produkt in listaProduktow)
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

double sumaListy = listaProduktow.Sum(p => p.Cena);

double sredniaListy = listaProduktow.Average(p => p.Cena);

List<Produkt> drogieProdukty = listaProduktow.Where(p => p.Cena > 200).ToList();

double sumaDrogichProduktow = listaProduktow.Where(p => p.Cena > 200).Sum(p => p.Cena);

double wartoscMagazynu = Produkt.ObliczWartoscMagazynu(produkty);

Console.WriteLine($"Najniższa cena: {minimalnaCena}");
Console.WriteLine($"Największa cena: {maksymalnaCena}");
Console.WriteLine($"Średnia cena: {srednia:f2} zł");
Console.WriteLine($"Suma wartości magazynu dla wszystkich produktów: {wartoscMagazynu:f2} zł");

double wartoscListy = Produkt.ObliczWartoscMagazynu(listaProduktow);

Console.WriteLine(procesor.ToString());

Produkt p = Produkt.ZnajdzPoNazwie(produkty, "Dysk SSD");
Console.WriteLine($"Znaleziono produkt: {p.Nazwa}, cena: {p.Cena} zł, ilość: {p.Ilosc}");

Produkt p2 = Produkt.ZnajdzPoNazwie(listaProduktow, "sila");
Console.WriteLine($"Znaleziono produkt: {p2.Nazwa}, cena: {p2.Cena} zł, ilość: {p2.Ilosc}");

listaProduktow.Add(new Produkt("Karta graficzna", 1999.99, "Podzespoły", 3));
Produkt p3 = listaProduktow[0];
listaProduktow.Remove(p3);
bool czyJest = listaProduktow.Contains(p3);
listaProduktow.Clear();




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