// See https://aka.ms/new-console-template for more information

// Cast işlemleri 

int sayi = 5;
byte number = (byte)sayi; // parantez içinde özellikle byte olduğunu belirtiyoruz çünkü int için ramde ayrılan yer > byte için ayrılan yerden.
// Dolayısıyla büyük bir int atarsak byte veri kaybı olabilir. Byte max 255 tutuyor.

int numara = number; // bunda sorun olmaz

number.GetType(); // değişkenin tipini söyler

// Implicit ve explicit conversion: byttan inte gibi kapsayabileceği aralıkta bir atama yaptığımızda örtük (implicit),
// intten byta gibi kapsayamayacağı bir aralıkta atama yaptığımızda açık (explicit) conversion olur.
// referans ve değer tiplileri cast kullanarak birbirine atayamayız.
// normalde ref ve değer tipliler birbirine atanmaz demiştik ama objectte istisna söz konusu

object sayi2 = 2; // boxing
int number2 = (int)sayi; // unboxing

// boxing unboxing süreçleri ekstra maliyettir performans olarak olumsuz etkiler

// convert metotlarının castten farkı eğer uymuyorsa hata vermemesi yapmamasıdır. int 30 u byte atarken int 300ü atarken hata verir

Convert.ToByte(sayi);

checked // içeriyi kontrol et oluyosa yap olmuyosa hata ver. Mesela burada hata verecek çünkü byte 444 değerini tutamaz. checkedsız yazsak çalışacaktı ama 444 yerine başka bir değer verecekti
{
    int yeni = 444;
    byte yenibyte = (byte)yeni;
}

double fiyat = 34.8;
int cevir = (int)fiyat; // sadece tam kısmı alır 34 gelir
int boylecevir = Convert.ToInt32(fiyat); // yuvarlayarak çevirir 35 gelir

// stringe dönüştürürken Convert.ToString(değişken) yerine direk  değişken.ToString(); olarak da kullanılıyor diğer convertlerde var mı emin değilim.

string saysay = "123";
int maymay = int.Parse(saysay);

// string bazı yerlerde değer tipli gibi davranır
// immutable typetır. String bir değişkene bir atama yaptığında ramde yeni bir değişken oluşturulup onun adı değişkenin adı olur. Yani eski değerin üzerine yazmıyor yeniden bir değişken oluşturuyor.
// Garbage collector sayesinde ismini kaybeden eski değer silinir.

string isim = "george";
isim += isim + " boole";  // stringe bu şekilde ekleme yapılabilir.

isim = $"{isim} + boole"; // interpolation

Console.WriteLine("Doğum Tarihinizi Giriniz");
Console.Write("Gün");
int gun = int.Parse(Console.ReadLine());
Console.Write("Ay");
int ay = int.Parse(Console.ReadLine());
Console.Write("Yıl");
int yil = int.Parse(Console.ReadLine());

DateTime birthDate = new DateTime(gun, ay, yil); // datetimenin aldığı parametreler int olmak zorunda o yüzden önce parse yapıyoruz
Console.WriteLine(birthDate);

string str = "str";
int numb;
bool result = int.TryParse(str, out numb); // bu tryparse boolean döndürür çevirebilirse true yoksa false. outun yanına verdiğimiz değişken de çevirebilirse atanacak değişken


