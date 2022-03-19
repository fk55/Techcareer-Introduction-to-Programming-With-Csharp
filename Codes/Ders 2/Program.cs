// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//Console.Write("aynı satıra yazma"); // Aynı satırdan devam eder. Writeline ise yazıp yeni satıra atar.

//Console.ReadLine(); // input almak için (entera bastığında okur)

//Console.Read(); // tek karakter input alır (entera bastığında sadece ilk karakteri alır)

//Console.ReadKey(); // tuşa basıldığı zaman direk alır

//Console.WriteLine(Console.Read()); //read ile okuduğumuz değeri bilgisayar ascii olarak tuttuğu için bunu yazdırdığımızda ascii kodunu yazar.

//Console.WriteLine(Console.ReadLine()); //aldığını yazar

//Console.Write(Console.ReadKey()); // Bu sana bir değer değil de system.ConsoleKeyInfo döndürüyor. O karakter hakkında daha fazla bilgi alabileceğin bir formatmış.

//Console.WriteLine(Console.ReadKey().KeyChar); // böyle yazınca karakteri döndürüyor

//Console.ReadKey();  //Bu kodu yazmadığımız zaman dosya konsolda hemen çalışır ve konsol kapanır. Konsolun açık kalması için bunu kullanıyoruz. Şu an bunsuz da kapanmıyor gerçi.

//Console.WriteLine("{0} {1}", "sıfırıncı", "birinci"); // Placeholder kavramı. Tek string olarak başta indisleri veriyorsun sonra da o indislere denk gelecek şeyleri giriyorsun.

//Console.WriteLine("{0}   {1}   {1}    {0}", "kartal", "martal"); // Bu şekilde çoğul olarak da kullanılabiliyor.

//Console.WriteLine("Alt\nsatıra"); // escape karakter \n dosya yolu yazarken falan normal karakter olarak ters slash kullanmak içinse iki kere basacan \\ yoksa hata veriyor

//Console.WriteLine("tab\ttab"); // \t ile bir tab boşluk bırakırsın \a alarm sesi 

//char harf = 'g'; // char tek karakter tutar tanımlarken tek tırnak içinde tanımlamalısın karakterin ascii kodunu tutar. writeline ile yazdırırsan normal karakteri yazdırır.

//int tamsayi = 10; // 4 byte

//byte byteSayi = 20; // 1 byte -- byte veri tipi normalde negatif değer alamaz. Negatif değer alabilmesi için sbyte (signed byte) kullanılır.

//short shortSayi = 30; // 2 byte

//long longSayi = 40; // 8 byte ramde yer kaplar.

//Console.WriteLine("integerın max değeri : {0} - min değeri : {1} - boyutu {2}", int.MaxValue, int.MinValue, sizeof(int));

//uint sayi = 3; // unsigned negatif değer alamaz normal integerın alabileceği ranjdaki negatif değerler pozitif değerlere eklenir dolayısıyla 4 bytelık pozitif değer alabilir

//unsigned int gibi ushort ve ulong da vardır.


