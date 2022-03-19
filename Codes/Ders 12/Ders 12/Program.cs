// See https://aka.ms/new-console-template for more information

/***************************************** METOTLAR *******************************************
 * 
 * erişim belirleyicisi + niteleyici + geri dönüş tipi + isim + parametre listesi
 * 
 * Niteleyici ve parametre listesinin yazılması zorunlu değildir.Erişim belirleyicisi yazılmasa bile default olarak bulunur. 
 * 
 * Erişim belirleyicisi: Public, private, internal, protected, internal protected, protected private
 * Public --> Her yerden erişilebilir
 * Private --> Sadece yazıldığı yerde erişilebilir
 * İnternal --> Yazıldığı projenin içinde her yerde erişilebilir.
 * Protected --> Kalıtım hiyerarşisi içinde çocuk sınıflar tarafından erişilebilir.
 * İnternal Protected --> Durum hangisine uyuyorsa, yani internal veya protected 
 * Protected Private --> Protected veya private
 * 
 * Eğer erişim belirleyicisi yazılmamışsa defaultu privatedir.
 *
 *Niteleyici: static, virtual, abstract, sealed. || Bunlar hakkında detaylı bilgi vermedi OOP ile alakalıymış.
 *Static --> 
 *Virtual -->
 *Abstract -->
 *Sealed --> Kalıtımın önünü kesmekte kullanılır. Çocuğa aktarılsın ama toruna aktarılsın istemediğinde bunu sealed ile işaretleyerek yapıyorsun.
 *
 *Geri dönüş tipi: Primitif veri tipleri, diğer kullandıklarımız ve OOP söz konusu olduğunda kendi yazdığımız tipler. Void --> Dışa bir şey dönmeyeceğimiz zaman.
 *
 *İsimlendirme emir kipiyle olmalı pascalCase olmalı.
 *
 *Bir metot çağrılmadığı sürece belleğe çıkmaz. Static metotlar istisna olarak çağrılmadan da bellekte bulunur. Yukarıdan aşağı giden akış metot çağrıldığında metoda atlar.
 *Metot bittikten sonra akış kaldığı yerden devam eder.
 *
 ***********************************************************************************************/

//static void SayHello()
//{
//    Console.WriteLine("Hi sweedy");
//}


//static void gag()
//{
//    int x = 5;
//    vag();
//    static int vag()
//    {
//        int x = 8;
//        return x;
//    }
//    Console.WriteLine(x);
//} // her türlü 5 dönüyor gagdaki x ile vagdaki x alakasız olarak processleniyor.

//gag();

//***********************************************************************************************

//giris();

//static void giris()
//{
//    Console.WriteLine("Kullanıcı adı: ");
//    string kullaniciAdi = Console.ReadLine();
//    Console.WriteLine("Parola: ");
//    string parola = Console.ReadLine();

//    if (kullaniciAdi == "furkan" && parola == "1234")
//    {
//        Console.WriteLine("Hoşgeldin Admin");
//    }
//    else
//    {
//        Console.WriteLine("Hatalı Giriş!");
//    }
//}

//***********************************************************************************************

/* Geriye değer dönen metotlarda metotun geri dönüş tipi dönüş vereceği tip neyse o olur. */
// return ile döndürülen değer metot nerede çağrılmışsa oraya gider.
// return sadece geriye bir şey dönen metotlarda değil void metotlarda da kullanılır. Return görüldüğü an metotun çalışması sonlandırılır. 
// Geriye değer dönenlerde return zorunludur ve yanına döndüreceği şey yazılmalıdır fakat void metotlarda zorunlu değildir.

//***********************************************************************************************

//Console.WriteLine("Sayı: ");
//int girdi = int.Parse(Console.ReadLine());
//Console.WriteLine(mutlak(girdi));

//static int mutlak(int sayi)
//{
//    int sonuc;
//    if (sayi < 0)
//    {
//        sonuc = sayi * -1;
//    }
//    else
//    {
//        sonuc = sayi;
//    }
//    return sonuc;
//}

//***********************************************************************************************

//static int sayiAl(string mesaj)
//{
//    int number;
//    bool check = false;
//    do
//    {
//        Console.WriteLine($"{mesaj}: ");
//        check = int.TryParse(Console.ReadLine(), out number);

//    } while (!check);

//    return number;
//}

//static int usal(int taban, int us)
//{
//    int sonuc = 1;
//    if (taban != 0 && us != 0)
//    {
//        for (int i = 0; i < us; i++)
//        {
//            sonuc *= taban;
//        }
//    }
//    else if (taban == 0 && us != 0)
//    {
//        sonuc = 0;
//    }
//    // else kalan koşullar --> 0^0 = 1 ve x^0 = 1 o yüzden yazmadım sonuc zaten 1 tanımlı dolayısıyla direk 1 dönecek

//    return sonuc;
//}

//Console.WriteLine(usal(sayiAl("Taban"), sayiAl("Üs")));

//***********************************************************************************************