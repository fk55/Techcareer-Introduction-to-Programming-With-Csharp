

/****************** METOT OVERLOADING *******************/
// Metot imzası == metotAdı + Parametreler
// Aynı tip içerisinde aynı metot imzasına sahip birden fazla metot tanımlanamaz
// Metot imzasına geri dönüş tipi dahil değildir

static int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

static double Topla(double sayi1, double sayi2)
{
    return sayi1 + sayi2;
}

// Double değişkenler vererek çağrırsan double döndüren Toplayı çalıştırır, int değişkenlerle çağırırsan int döndüren Toplayı çalıştırır.

static int Test(ref int sayi1)
{
    return sayi1;
}

static int Test(out int sayi1)
{
    return sayi1;
}

static int Test(in int sayi1)
{
    return sayi1;
}

// in-out-ref ile metot imzası değişmez çünkü üçü de referans kontrolü üzerinden işleyen mekanizmalardır.