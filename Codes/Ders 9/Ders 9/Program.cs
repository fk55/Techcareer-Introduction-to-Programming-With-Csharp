// See https://aka.ms/new-console-template for more information

/* 
 * jumping keywords;
 * break
 * continue // döngüde o turu bırakıp sıradaki tura geçer.
 * return // methodun akışını sonlandırır.
 * go to // günümüzde kullanılmaktan kaçınılır.  
 */

//baslangic:   // bu şekilde etiketleme yapılabilir 
//try
//{
//    Console.WriteLine("sayi girin");
//    int sayi = int.Parse(Console.ReadLine());
//}
//catch
//{
//    Console.WriteLine("yanlış değer");
//    goto baslangic;
//}

// hataya düşerse başlangıca dönüyor.

//****************** DİZİ TANIMLAMA ***********************//

// tüm diziler referans tiptir. Diziye yeni eleman ekleyip çıkardığında yeni bir dizi oluşturulmuş gibi olur

//string[] students = new string[3]; // içinde kaç elemanlı bir dizi olduğunu belirtmemiz gerekiyor.
//students[0] = "ali";
//students[1] = "veli";
//students[2] = "deli";

//students[5] = "hatali"; // bunu çağırmaya çalışırsak syntax olarak bir hata yok fakat atanan dizi sınırlarının dışında bir veriye ulaşılmaya çalışıldığı için hata verir.

//string[] sehirler = { "istanbul", "izmir", "zonguldak", "rize" };

//int uzunluk = int.Parse(Console.ReadLine());
//string[] dizim = new string[uzunluk]; // bu şekilde kullanıcıdan sayı alıp kaç elemanlı dizi oluşturacağımızı belirleyebiliriz.

//Console.WriteLine(students[students.Length - 1]); // dizinin son elemanına ulaşma

Random rnd = new Random();
int[] loto = new int[6];
int yaratilan = 0;
bool flag = false;
for (int i = 0; i < loto.Length; i++)
{
    flag = false;
    yaratilan = rnd.Next(1, 50);
    for (int j = 0; j < loto.Length; j++)
    {
        if (loto[j] == yaratilan)
        {
            i--;            // i-- diyoruz çünkü eğer aynı gördüğünde atama yapmayacak ve bir sonraki indexe geçecek dolayısıyla bu index boş kalacak.
                            // Bu indexin yeniden dönüp atama yapılması için i'yi azaltıyoruz
            flag = true;
            break;
        }
    }
    if (!flag)
    {
        loto[i] = yaratilan;
        Console.WriteLine(loto[i]);
    }
}