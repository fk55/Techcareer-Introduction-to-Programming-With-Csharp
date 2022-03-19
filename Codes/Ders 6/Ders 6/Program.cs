// See https://aka.ms/new-console-template for more information

Console.WriteLine("Harf giriniz");




char harf = char.Parse(Console.ReadLine());
int ascii = (int)harf; // harfin ascii kodunu verir. Burada explicit conversion yaptık ama bu örtük de kabul ediyor yani (int) diye parantez içinde belirtmesek de olur.



//int ascii;
//ascii = (int)char.Parse(Console.ReadLine()); // bu şekilde de olabilir biraz daha kısası işte aynı şey aslında. Direk stringden harfi inte atamıyoruz önce char yapmamız lazım

if (ascii >= 65 && ascii <= 90)
{
    Console.WriteLine("Girilen harf büyüktür");
}
else if (ascii >= 97 && ascii <= 122)
{
    Console.WriteLine("Girilen harf küçüktür");
}
else
{
    Console.WriteLine("Geçersiz işlem");
}

// ********************************************************************************************************************************************

if (harf >= 65 && harf <= 90)    // ilginç bir şekilde böyle de çalıştı demek direk ascii olarak tutuyor.
{
    Console.WriteLine("Girilen harf büyüktür");
}
else if (harf >= 97 && harf <= 122)
{
    Console.WriteLine("Girilen harf küçüktür");
}
else
{
    Console.WriteLine("Geçersiz işlem");
}

// ********************************************************************************************************************************************

if (harf >= 'A' && harf <= 'Z') // hatta böyle de çalıştı hem ascii hem karakter olarak yiyo sanırım bunun sebebi bilgisayara göre F harfi ve onun ascii kodunun aynı şey olmasından kaynaklı
{
    Console.WriteLine("Girilen harf büyüktür");
}
else if (harf >= 'a' && harf <= 'z')
{
    Console.WriteLine("Girilen harf küçüktür");
}
else
{
    Console.WriteLine("Geçersiz işlem");
}

//char car = char.Parse(Console.ReadLine()); bu şekilde yazdırınca ascii kodunu değil harfi veriyor ama
//Console.WriteLine(car);

