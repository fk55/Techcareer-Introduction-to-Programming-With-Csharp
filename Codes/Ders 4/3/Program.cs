// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


float floatsayi = 10.1F;
double doublesayi = 10.2;
decimal decimalsayi = 10.3M;

// Küsüratlı bir sayı girdiğinde onu otomatik double algılar. Burada diğerlerinde hata vermesinin sebebi de double bir veriyi
// başka değişkenlere atama çalışıyormuşsun gibi algılaması. Çözüm olarak sonlarına float için F (double için de gizli bir D var) decimal için M
// Decimal için M olmasının sebebi eskiden o tipin Money olarak kullanılması.

Console.WriteLine("float min değeri : {0} - max değeri : {1} - boyutu : {2}", float.MinValue, float.MaxValue, sizeof(float));   // küsürat sonrasi hassasiyet olarak en az - 1 byte tam sayı kısmı için 3 byte ondalık için
Console.WriteLine("double min değeri : {0} - max değeri : {1} - boyutu : {2}", double.MinValue, double.MaxValue, sizeof(double)); // küsürat sonrasi hassasiyet olarak orta - 
Console.WriteLine("decimal min değeri : {0} - max değeri : {1} - boyutu : {2}", decimal.MinValue, decimal.MaxValue, sizeof(decimal)); // küsürat sonrasi hassasiyet olarak en çok - decimal tam-küsürat ayrımı yapmıyor otomatik ayarlıyor

object deger = 5; // object tipi tüm veri tiplerinin atasıdır. Diğer veri tiplerinin var olmasını sağlar. "
deger = "yazi";

// object ve string değişken tiplerinin max boyutu uygulamanın kullanabileceği ram'in tamamıdır yani ön tanımlı bir limiti yok.  
// O yüzden her değişkene object diyelim yapamıyoruz performans kaybına yol açar. Tabi uygulamaya ayrılan ram kısıtlı onun bir limiti var.

//  _______________________________________
// |                                       |
// |                 STACK                 |   --> Stack kısmına ramde ayrılan yer daha azdır ve bu kısımdatutulan veri tiplerinin boyuları ön tanımlıdır. String ve object dışındaki primitif tipler burada tutulur.
// |_______________________________________|    burada veriler yığın halinde bitişik olarak tutulur daha hızlı çağrılmasının sebebi budur.
// |                                       |
// |                                       |
// |                 HEAP                  |
// |                                       |
// |                                       |   ---> Heap string ve object bu kısımdadır. Heap kısmında veriler sonradan boyutlarının değişebilmesi için dağınık şekilde tutulur daha yavaş çağrılmasının sebebi budur.
// |                                       |    String ve object referans tipken diğer primitif tipler değer tiptir.
// |                                       |
// |                                       |
// |_______________________________________|


// reserverd keywordler değişken adı olarak kullanılamaz illa kullanılmak istendiği zaman başına @ koyarak kullanılır
string @int = "10";

// veri tiplerinin default değerleri;

string @string = "";
char @char = '\0';
int sayi = 0;
decimal @decimal = 0;
bool @bool = false;
object @object = null;

Console.WriteLine(default(decimal)); // default() fonksiyonu veri tiplerinin default değerlerini görmemizi sağlar

int sayi1 = 20, sayi2 = 30; // şeklinde tek satırda birden fazla değişken atayabiliriz.

// tip güvenliği konusu derlerken ve runtimeda belirlenmek üzere ikiye ayrılabilir. C# tip güvenliğini normalde derlerken sağlar. Çalışma zamanında tipin değişmesine müsaade edilmez
// fakat bunu esnetebilmek için C#ta dynamic veri tipi tanımlanmıştır bu tip runtime esnasında çalışır. 

dynamic sayi5 = 5;
sayi5 = "izin var";

// var ise bir veri tipi DEĞİLDİR. Sadece atanan değeri derlerken var olan veri tipiyle eşleştirir. Küsüratlı bir şeyi double olarak algılar.

// var sayi3 = 5;     
// sayi3 = "çalışmaz"  var ile atama yaptığımızda sonradan o değişkene başka bir tip veri veremeyiz.


// 2.14te kaldım

DateTime dogumtarih = new DateTime(2022, 1, 30);  // Datetime değer tipli bir veri tipidir 
Console.WriteLine(dogumtarih.ToString("d")); // d yerine çeşitli parametreler alıp tarihi ona göre verebiliyor 
Console.WriteLine(DateTime.Now); // saat dk ve saniye dahil şu an ki tarihi yazdırır.

Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day); // milisaniyeye kadar ayrı ayrı da yazdırılabiliyor bu şekilde

Random rnd = new Random();
int number1 = rnd.Next(0, 100); // 0dan 99a kadar random üretiyor 100ü almıyor
double duble = rnd.NextDouble(); // random double de üretilebiliyo.

Console.WriteLine(++sayi); // önce artırır sonra yazar
Console.WriteLine(sayi++); // önce yazar sonra artırır.
