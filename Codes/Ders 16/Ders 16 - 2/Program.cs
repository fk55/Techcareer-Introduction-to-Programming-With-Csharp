

/*********** Build-in (Hazır) Metotlar ***********/



// ------------ Math Metotları -------------

Console.WriteLine(Math.E); // Euler sayısı
Console.WriteLine(Math.PI); // Pi sayısı
Console.WriteLine(Math.Abs(-123)); // Mutlak değer
Console.WriteLine(Math.Log10(100)); 
Console.WriteLine(Math.Ceiling(25.2)); // Yukarı yuvarlama
Console.WriteLine(Math.Floor(25.2)); // Aşağı yuvarlama
Console.WriteLine(Math.Round(25.2)); // Normal yuvarlama
Console.WriteLine(Math.Pow(3,5)); // Üs alma (3 üzeri 5)
Console.WriteLine(Math.Sqrt(100)); // Kök alma
Console.WriteLine(Math.Pow(27, (double)1 / 3)); // Bu şekilde n. dereceden kökünü almamız mümkün. Burada 27nin küp kökünü aldık.
Console.WriteLine(Math.Max(13,2424));
Console.WriteLine(Math.Max(13,2424));
Console.WriteLine(Math.Round(23.12345678, 2)); // 2 virgülden sonra kaç basamağa yuvarlayacağını belirtir yani burada 23.13 dönecek

// ----------- String Metotları -----------

string value = "boole";
int result = value.CompareTo("george"); // alfabetik olarak kıyas yapıyor. George booledan önce mi gelir diye bakıyor.
// -1 değişkendeki değer öncedir. 1 parametre daha öncedir 0 aynıdır.

value.Contains('a'); // var mı yok mu true false döner
value.EndsWith('e'); // bununla bitiyor mu?
value.StartsWith('b'); // bununla başlıyor mu?
value.IndexOf('o'); // ilk gördüğü yerde index numarasını verir.
value.Insert(2, "xxx"); // ilk parametredeki indexten itibaren 2.parametredeki değeri atar. boxxxole çıktısı
value.PadLeft(15, 'x'); // değişkeni 15 değere tamamlamak için soldan x ekler. İlk parametre kaç karaktere tamamlamak istediğin 2. parametre hangi karakterle doldurmak istediğin. 2.Parametrenin default değeri boşluktur.
value.PadRight(15, 'x');
value.Remove(2,2); // verilen indexten itibarını siler. İkinci parametre kaç adet sileceği. İkinci parametreyi vermezsen geri kalan hepsini siler.
value.Replace("xx", "yy"); // xxleri yy ile değiştirir. Tek harf olarak falan da verebiliyorsun tabi.
value.Substring(2, 3); // 2. indisten itibaren 3 tane getir.

string[] valueParts = value.Split(' ','a'); // params var burada yani istediğin kadar parametre verebiliyosun. Hangi karakterlere göre parçalamak istiyorsan. Parçalayıp string dizisine atar.

value.Trim(); // Sondaki ve baştaki boşlukları siler. Trimlerin içine parametre verip belli karakterleri silmesini de sağlayabilirsin.
value.TrimEnd(); // sonundaki boşlukları siler
value.TrimStart(); // başındaki boşlukları siler

string cikti = string.Concat("ali ", "ata ", "bak"); // verilen parametreleri birleştirip yeni bir string yapar.
string[] cities = { "istanbul", "izmir", "ankara" };
string.Join(" - ", cities); // concatin araya bir karakter koyarak birleştirmeli hali // şehirler dizisini araya  - koyarak birleştirdik.

string.IsNullOrEmpty(value); // null --> stackte bir değişken adı var fakat heapte tuttuğu herhangi bir şey yok. Empty ise stackte bir değişken var ve heapte boş bir alanı tutuyor.
string.IsNullOrWhiteSpace(value);

// ----------- Datetime Metotları -----------

// yazmadım bunları 

