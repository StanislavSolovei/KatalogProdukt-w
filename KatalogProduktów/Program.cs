using KatalogProduktów;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz" };
double[] ceny = { 899.00, 249.50, 379.00, 189.99 };

Produkt procesor = new Produkt();
procesor.Nazwa = "AMD Ryzen";
procesor.Cena = 899.99;
procesor.Kategoria = "Podzespoły";
procesor.Ilosc = 10;

Produkt ram = new Produkt
{
    Nazwa = "Pamięć RAM",
    Cena = 249.50,
    Kategoria = "Podzespoły",
    Ilosc = 20
};

Produkt ssd = new Produkt
{
    Nazwa = "Dysk SSD",
    Cena = 397.00,
    Kategoria = "Podzespoły",
    Ilosc = 15
};

Produkt zasilacz = new Produkt
{
    Nazwa = "Zasilacz",
    Cena = 189.99,
    Kategoria = "Podzespoły",
    Ilosc = 5
};

Produkt[] produkty = {procesor, ram, ssd, zasilacz};

double minimalnaCena = produkty[0].Cena;
double maksymalnaCena = produkty[0].Cena;
double srednia = 0;
int licznik = 0;
double suma = 0;

foreach (Produkt produkt in produkty)
{
    Console.WriteLine($"Nazwa: {produkt.Nazwa,-25}| Cena: {produkt.Cena,10:f2} zł | " +
        $"Kategoria: {produkt.Kategoria} | Ilość: {produkt.Ilosc,5}");

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

}
Console.WriteLine($"Najniższa cena: {minimalnaCena}");
Console.WriteLine($"Największa cena: {maksymalnaCena}");
Console.WriteLine($"Średnia cena: {srednia:f2} zł");




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