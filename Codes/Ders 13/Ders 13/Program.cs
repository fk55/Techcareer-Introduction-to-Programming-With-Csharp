// See https://aka.ms/new-console-template for more information

/* Kullanıcıdan iki metin alıp ilkindeki tüm harfleri küçüğe çeviren, ikincisindeki harfleri büyük yapan; aynı zamanda bu iki metni araya _ koyarak birleştiren,
 * hatta metinler birden fazla kelimeden oluşuyorsa onlardaki boşlukları da _ yapan ve birleştirdikten sonra A harflerini E harfiyle değiştiren metotlar
 */

//*************************************** BENİM ÇÖZÜMÜM **************************************//
//Console.WriteLine("İlk metin: ");
//string metin1 = Console.ReadLine();
//Console.WriteLine("İkinci metin: ");
//string metin2 = Console.ReadLine();
//Console.WriteLine(islemleriYap(metin1,metin2));

//static string islemleriYap(string metin1, string metin2)
//{
//    metin1 = kucukYap(metin1);
//    metin2 = buyukYap(metin2);
//    string yeniMetin = birlestir(metin1, metin2);
//    yeniMetin = bosluklariTireYap(yeniMetin);
//    yeniMetin = aeDegistir(yeniMetin);
//    return yeniMetin;
//}

//static string kucukYap(string metin)
//{
//    return metin.ToLower();
//}
//static string buyukYap(string metin)
//{
//    return metin.ToUpper();
//}
//static string birlestir(string metin, string metin2)
//{  
//    string yeniMetin = metin + "_" + metin2;
//    aeDegistir(yeniMetin);
//    return yeniMetin;
//}
//static string bosluklariTireYap(string metin)
//{
//    char[] metinChar = metin.ToCharArray();
//    for (int i = 0; i < metinChar.Length; i++)
//    {
//        if (metinChar[i] == ' ')
//        {
//            metinChar[i] = '_';
//        }
//    }
//    metin = new string(metinChar);
//    return metin;
//}
//static string aeDegistir(string metin)
//{
//    char[] metinChar = metin.ToCharArray();

//    for (int k = 0; k < metinChar.Length; k++)
//    {
//        if (metinChar[k] == 'a')
//        {
//            metinChar[k] = 'e';
//        }
//        else if (metinChar[k] == 'A')
//        {
//            metinChar[k] = 'E';
//        }
//    }

//    metin = new string(metinChar);
//    return metin;
//}

//*************************************** HOCANIN ÇÖZÜMÜ **************************************//
Console.WriteLine("Birinci Metin: ");
string ilkMetin = Console.ReadLine();
Console.WriteLine("İkinci Metin: ");
string ikinciMetin = Console.ReadLine();
IslemleriYap(ilkMetin, ikinciMetin);

static void IslemleriYap(string ilkMetin, string ikinciMetin)
{
    string yeniMetin = string.Empty;
    ilkMetin = kucugeCevir(ilkMetin);
    ikinciMetin = buyugeCevir(ikinciMetin);
    ilkMetin = bosluklariTireyeCevir(ilkMetin);
    ikinciMetin = bosluklariTireyeCevir(ikinciMetin);
    yeniMetin = tireyleBirlestir(ilkMetin, ikinciMetin);
    yeniMetin = harfleriDegistir(yeniMetin, 'A', 'E');
    yeniMetin = harfleriDegistir(yeniMetin, 'a', 'e');

    Console.WriteLine($"Metnin son hali: {yeniMetin}");
}

static string buyugeCevir(string metin)
{
    string yeniMetin = string.Empty;
    for (int i = 0; i < metin.Length; i++)
    {
        if (metin[i] >= 'a' && metin[i] <= 'z')
        {
            yeniMetin += (char)metin[i] - 32; /* büyük ve küçük ascii kodları arasında 32 fark var.
                                               * Char olarak aldığımız zaman ascii kodlarıyla işlem yapabiliyorduk burada bunu kullandık.
                                               * -32 yaptığımızda implicit conversion yapmış olduk.
                                               * Direk -32 yapıp bıraksaydık conversiondan ötürü integer değer dönecekti o yüzden () içinde char olduğunu belirtik.*/
        }
        else
        {
            yeniMetin += metin[i];
        }
    }
    return yeniMetin;
}

static string kucugeCevir(string metin)
{
    string yeniMetin = string.Empty;
    for (int i = 0; i < metin.Length; i++)
    {
        if (metin[i] >= 'A' && metin[i] <= 'Z')
        {
            yeniMetin += (char)metin[i] + 32; 
        }
        else
        {
            yeniMetin += metin[i];
        }
    }
    return yeniMetin;
}

static string bosluklariTireyeCevir(string metin)
{
    string yeniMetin = string.Empty;
    foreach (char item in metin)
    { 
        if (item == ' ')
        {
            yeniMetin += '_';
        }
        else
        {
            yeniMetin += item;
        }
    }
    return yeniMetin;
}

static string tireyleBirlestir(string ilkMetin, string ikinciMetin)
{
    return $"{ilkMetin}_{ikinciMetin}";
}

static string harfleriDegistir(string metin, char eskiHarf, char yeniHarf)
{
    string yeniMetin = string.Empty;
    foreach (char item in metin)
    {
        if (item == eskiHarf)
        {
            yeniMetin += yeniHarf;
        }
        else
        {
            yeniMetin += item;
        }
    }
    return yeniMetin;
}