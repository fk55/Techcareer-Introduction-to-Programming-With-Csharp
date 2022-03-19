// See https://aka.ms/new-console-template for more information

// string ifadeler tam olarak olmasa da dizi gibi düşünülebilir. 


//string name = "furkan";

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]); // stringi sadece okurken böyle kullanabiliriz mesela name[1] = 'k'; gibi bir atama yapmamız söz konusu değil
//}

//char[] letters = name.ToCharArray();    

//static void arama()
//{
//    Console.WriteLine("Metni Girini");
//    string metin = Console.ReadLine();
//    Console.WriteLine("Metnin içinde aramak istediğiniz harfi giriniz");
//    char harf = ' ';
//    bool deneme;
//    do
//    {
//        deneme = true; // bunu yazmazsan aşağıda bi kere false olduğunda false kalıyor hiç değişmiyor bu yüzden sürekli döngü dönüyor 
//        try
//        {
//            harf = Convert.ToChar(Console.ReadLine());

//        }
//        catch
//        {
//            Console.WriteLine("Lütfen geçerli bir değer girin");
//            deneme = false;
//        } 
//    } while (!deneme);

//    Console.WriteLine(harf);
//    char[] charArr = metin.ToCharArray();
//    int counter = 0;

//    for (int i = 0; i < charArr.Length; i++)
//    {
//        if(charArr[i] == harf)
//        {
//            counter++;
//        }
//    }
//    Console.WriteLine($"Metinde {counter} adet '{harf}' harfi bulunmaktadır");
//}

//arama();

// ternary operatör --> bu operatörün sonunda bi çıktı olmalı. Şöyleyse şunu yap böyleyse bunu yap gibi kod yazıp işlem yaptıramazsın. Kral okunabilirlik açısından pek hoş değil dedi

//Console.WriteLine(5 < 6 ? "küçük" : "büyük");
//               koşul | soru işareti | doğruysa çalışacak | iki nokta | yanlışsa çalışacak

//********* kullanıcıdan gelen metindeki sesli harflerin sayısını yazdırma **********

//static void sesliHarfSayaci()
//{
//    Console.WriteLine("Metni giriniz");
//    string metin = Console.ReadLine();
//    int counter = 0;
//    string sesli = "aeıioöuü";
//    for (int i = 0; i < metin.Length; i++)
//    {   
//        for (int j = 0; j < sesli.Length; j++)
//        {
//            if (metin[i] == sesli[j])
//            {
//                counter++;
//                break;
//            } 
//        }
//    }
//    Console.WriteLine($"Girilen metinde {counter} adet sesli harf vardır");
//}
//sesliHarfSayaci();

// metindeki baştaki sesli harfleri sondaki sesli harflerle değiştirme 
//Console.WriteLine("Metin: ");
//string metin = Console.ReadLine();
//char[] textChars = metin.ToCharArray();
//string sesliHarfler = "aeıioöuü";
//int index = textChars.Length - 1;
//char temp = ' ';
//for (int i = 0; i < textChars.Length; i++)
//{
//    if (sesliHarfler.Contains(textChars[i]))
//    {
//        for (int j = index; j >= 0; j--)
//        {
//            if (sesliHarfler.Contains(textChars[j]))
//            {
//                temp = textChars[i];        // değerin kaybolmaması için geçici bir değişkene veriyoruz
//                textChars[i] = textChars[j];
//                textChars[j] = temp;
//                index = j - 1; // indexi kaldığımız yerden döngüye devam etmesi için kuruyoruz yoksa yeniden en sona gider en sondan dönmeye başlar
//                break;
//            }
//        }
//    }
//    if (i == index) // Döngüye devam edilip başa dönerse yine başladığımız sonucu verir. Bunu önlemek için döngüyü kesiyoruz.
//                    // Sondan gelenle baştan gelen döngü çakıştığında duruyoruz. Durmazsak ikisi de bitene kadar devam eder ve tekrar yerler değişmiş olur.
//    {
//        break;
//    }
//}
//metin = new string(textChars);
//Console.WriteLine(metin);

// metindeki fazla boşlukları atma

//Console.WriteLine("Metin: ");
//string text = Console.ReadLine();
//string newText = " ";
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == ' ')
//    {
//        newText += text[i];
//        do
//        {
//            i++; 
//        } while (text[i] == ' ');
//        i--;
//    }
//    else
//    {
//        newText += text[i];
//    }
//}

// foreach kullanımı

//string[] sehirler = { "istanbul", "izmir", "ankara" };

//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

// 1000 kere zar atıldığında hangi değerin kaç kere geldiğini bulma
Random rnd = new Random();
int[] counters = new int[6];
int generated = 0;
for (int i = 0; i < 1000; i++)
{
    generated = rnd.Next(1, 7);
    counters[generated - 1]++;
}
foreach (int counter in counters)
{
    Console.WriteLine(counter);
}