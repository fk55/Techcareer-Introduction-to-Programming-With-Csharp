
using System.IO; // Input output işlemleri için
using System.Text; // encodingi falan çağırmak için. Encoding farklı karakter türlerinin dönüştürülmesiyle alakalı.

//StreamWriter yazici = new StreamWriter("deneme.txt"); // exenin olduğu yerde dosyayı oluşturur

//yazici.WriteLine("abc");

/* Data akışı bir stream olarak sağlanır. Uygulaman çalıştığında ramde olan bu yerle harddisk ile bağlantı kurulur.
 * Data yazma işlemi bittiğinde uygulama kapansa bile bu bağlantı hala açık kalır. İşlem bittikten sonra bu streami sonlandırmak için de Close(); kullanılır.
 */

/*yazici.Flush();*/ // büyük datalar yazılırken bazen veri tam yazılamayabilir askıda kalma gibi durumlar olabilir. Bunların önüne geçmek için kullanılır. 
// parça parça gelen verininin bir parçasının gelişinin tamamlandığını belirtmek için vs kullanılır metadata bilgileri oluşturuyormuş anladığım kadarıyla. 
//yazici.Close();

/* deneme.txt dosyasını kullanarak yeniden bu şekil bir şey yazdırırsak dosyanın üzerine yazılmış oluyor ve önceden tutulan veri siliniyor.
 * Mesela bu halde ardarda çalıştırırsan defalarca abc yazmıyor. Her defasında dosyanın üzerine yazdığı için dosyayı açtığımızda 
 * sadece 1 tane yazılı abc görüyoruz. */

//StreamWriter yazici = new StreamWriter("deneme.txt", true); // bunu true parametresiyle verirsen dosyanın üzerine yazmaz. Olan veriye devam olarak yazar.

//StreamWriter yazici = new StreamWriter("deneme.txt", true, Encoding.UTF32); // encoding vermek için system.texti kullandık en üstte

StreamReader okuyucu = new StreamReader("deneme.txt");
//Console.WriteLine(okuyucu.ReadToEnd()); // dosyayı okuyup konsola yazdırdık.

//string data = okuyucu.ReadToEnd();
//okuyucu.Close();
// data streamler çok kaynak yer bu yüzden kullanıldıktan sonra kapatılmalıdır. Yoksa işletim sistemi çok kaynak yediğin için uygulamanı çalıştırmayı durdurabilir.

#region ReadLine
//string line = string.Empty;

//do
//{
//    line = okuyucu.ReadLine();

//    if (line != null)
//    {
//        Console.WriteLine(line);
//    }
//} while (line != null);

//okuyucu.Close(); 
#endregion // Satır satır okur

/*okuyucu.Read();*/ // karakter karakter okur.

while (okuyucu.Peek() > -1) // imlecin konumudur peek. İmlecin hareket edemeyeceği yerde -1 gelir. İndex mantığıyla gider 0 da dahildir.
{
    Console.WriteLine(okuyucu.ReadLine());
}
okuyucu.Close();