// See https://aka.ms/new-console-template for more information

loto();

//*********************************************************************************************
static int[] kolonOlustur() // kolon oluşturuluyor
{
    Console.WriteLine("6 Adet Sayı Giriniz");

    int[] kolon = new int[6];
    int sayi;
    bool kontrol;
    bool ayniSayiMi;

    for (int i = 0; i < 6;)
    {
        Console.WriteLine("Sayi: ");
       
            ayniSayiMi = false;
            kontrol = int.TryParse(Console.ReadLine(), out sayi);
        if (!kontrol || sayi < 1 || sayi > 49)
        {
            Console.WriteLine("Hatalı değer girdiniz, 1-49 arasında bir sayı giriniz");
            
        }
        else
        {
            for (int j = 0; j < kolon.Length; j++)
            {
                if (sayi == kolon[j])
                {
                    Console.WriteLine("Bu sayıyı daha önce girdiniz");
                    i--;
                    ayniSayiMi = true;
                    break;
                }
            }
            if (!ayniSayiMi)
            {
                kolon[i] = sayi;
            }
            i++; // i'yi burada artırdım çünkü i = 0 olduğu durumda geçersiz değer girilirse i-- yaptığımda i = -1 oluyor ve hata veriyor.
        }  
    }
    Console.WriteLine("*****Kolon*****");
    foreach (int item in kolon)
    {
        Console.Write($"{item} | ");
    }
    Console.WriteLine("");
    Console.WriteLine("***************");
    return kolon;
}

//*********************************************************************************************

static void loto()
{
    int kolonSayisi;
    bool kolonKontrol;
    
    do
    {
        Console.WriteLine("En az 1 en fazla 6 olmak üzere kaç kolon oynayacağınızı giriniz: ");
        kolonKontrol = int.TryParse(Console.ReadLine(), out kolonSayisi);
        if (!kolonKontrol || kolonSayisi < 1 || kolonSayisi > 6)
        {
            Console.WriteLine("Hatalı değer girdiniz, 1-6 arasında oynamak istediğiniz kolon sayısını belirtiniz");
        }
        else if(kolonSayisi > 0 && kolonSayisi < 7)
        {
            break;
        }
    } while (!kolonKontrol || kolonSayisi < 1 || kolonSayisi > 6); // kolon sayısı alınıyor ve kontrol ediliyor

    int[,] kolonlar = new int[kolonSayisi,6];

    for (int i = 0; i < kolonSayisi; i++)   // oynanacak kolon sayısı kadar kolon oluşturuluyor
    {
        foreach (int item in kolonOlustur())
        {
            for (int j = 0; j < 6; j++)
            {
                kolonlar[i, j] = item;
            }         
        }
    }

    int[] cekilisSonucu = cekilis();

    Console.WriteLine("*****Şanslı Sayılarımız*****");
    foreach (int item in cekilisSonucu)
    {
        Console.Write($"{item} | ");
    }
    Console.WriteLine();
    int tutanSayisi;
    for (int k = 0; k < kolonSayisi; k++)
    {
        tutanSayisi = 0;
        for (int p = 0; p < 6; p++)
        {
            if (kolonlar[k,p] == cekilisSonucu[p])
            {
                tutanSayisi++;
            }
        }
        Console.WriteLine($"{k+1}. Kolonda {tutanSayisi} sayı tutturdunuz");
    }

}

//*********************************************************************************************

static int[] cekilis()
{
    int[] sansliSayilar = new int[6];
    int sayi;
    bool aynıSayiMi;
    Random rnd = new Random();
    for (int i = 0; i < 6; i++)
    {
        aynıSayiMi = false;
        sayi = rnd.Next(1, 50);

        for (int j = 0; j < sansliSayilar.Length; j++)
        {
            if (sayi == sansliSayilar[j])
            {
                i--;
                aynıSayiMi = true;
                break;
            }
        }
        if (!aynıSayiMi)
        {
            sansliSayilar[i] = sayi;
        }
    }
    return sansliSayilar;
}

