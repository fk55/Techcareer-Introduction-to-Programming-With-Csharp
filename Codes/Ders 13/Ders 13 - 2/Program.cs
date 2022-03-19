// See https://aka.ms/new-console-template for more information

//*********** PARAMS ******************//

/* Metot tanımlarken değişken sayıda parametre oluşturulmasını sağlar. Gelen girdileri alıp bir dizi oluşturarak metota girmesini sağlar.
 * Dolayısıyla paramsı bir DİZİ ile kullanmak ZORUNDASIN
 * params parametrelerin en sonunda kullanılmalıdır çünkü kaç tane girdi gelecek belli değildir. Diğer tek girdili parametreler paramstan önce gelmelidir. 
 * Params bir metotta yalnızca bir kere kullanılır. 
*/


static int getSum(params int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

/************ Opsiyonel ve İsimli Parametreler **********/

/* Not: Metotlar ve içlerindeki değişkenler çağrıldıkları zaman RAM'e çıkar.
 * Parametre girilmezse default değeri alarak işlemden geçer. Opsiyonel parametreler zorunlu parametrelerden sonra olmalı.
 * Metodun üstüne geldiğimizde aldığı parametreler gözükür. Opsiyonel olan parametre ve onun default değeri [] içinde veriliyor. Aşağıdaki metoda gel göreceksin.
 */

static double daireAlanHesapla (int yaricap, double pi = 3.14) // eşitlik vererek default değer tanımladık.
{
    return yaricap * yaricap * pi;
}

static decimal KDVHesapla(decimal fiyat, decimal oran = 0.18M)
{
    return fiyat * oran;
}

KDVHesapla(oran: 0.08M, fiyat: 100); //  Bu şekilde parametreleri isimli olarak yerleri farklı olarak verebiliyoruz.

Console.WriteLine("İlk sayi: ");
int ilkSayi = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayi: ");
int ikinciSayi = int.Parse(Console.ReadLine());

change(ilkSayi, ikinciSayi);

Console.WriteLine($"ilk sayı: {ilkSayi} -- ikinci sayi: {ikinciSayi}"); /* burada yaptığımız değiştirme işlemi çalışmadı sayılar aynı kaldı
                                                                         * Çünkü metoda giren aslında değişkenin kendisi değildir onun "DEĞERİDİR"
                                                                         * Change metodundaki sayi1 ve sayi2nin değerleri yer değiştiriyor fakat metot sonlandığında
                                                                         * bu değerler de değişkenleriyle birlikte kaybolmuş oluyor.
                                                                         * Değer tipli parametrelerde ve referans tipli olmasına rağmen istisna olarak stringlerde
                                                                         * durum böyledir.  */

static void change (int sayi1, int sayi2)
{
    int temp = sayi1;
    sayi1 = sayi2;
    sayi2 = temp;
}
