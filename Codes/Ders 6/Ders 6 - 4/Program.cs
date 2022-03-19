// See https://aka.ms/new-console-template for more information

// pattern matching

//string isim;

//if (isim is "furkan")         bu şekilde kullanımlar olabiliyor.
//{

//}
//if (isim is not "furkan")
//{

//}

// switch ile kullanımı ise biraz farklı

int number = 5;

string text = number switch
{
    1 => "bir",     // => lambda operatörü
    2 => "iki",
    3 => "üç",
    _ => "geçersiz değer",      // _ default işlevi görür _ discard operatörü denir
}; // bu şekilde text değişkenine duruma göre değerler atanabilmesini sağladık

int sayi = 2;
switch (sayi)
{
    case 0:    // sıfırı önceden verdiğimizde çakışmadan kurtuluyor. Yani <5 e bakınca 0 olmayan ve 5ten küçük olan değerler için işlem yapılıyor
        break; // çakışma durumlarında yukarıdan aşağı bakılır.

    case < 5:
        Console.WriteLine("5ten küçük");
        break;
    default:
        break;
}

//int kayi = 10;
//switch (kayi)
//{
//    1 => Console.WriteLine(3);
//    !!!!!! BU ŞEKİLDE BİR KULLANIM OLMAZ YUKARIDAKİ GİBİ LAMBDA VE DİSCARD OPERATÖRÜ İLE SADECE BİR DEĞİŞKENE GÖRE DEĞİŞKEN ATARKEN KULLANILIR
//}

Console.WriteLine(number switch { 1 => "bir", _ => "yok"}); // böyle bir şeyin içinde falan kullanılıyor yani anca başka bir şeyin içine atama yapacağında kullanılıyor

int mayi = 31;
string sonuc = mayi switch
{
    1 or 2 => "1 veya 2",   // bunun içinde || ve && kullanılmıyor or ve and kullanabiliyosun
};

