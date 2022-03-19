using System;

namespace Ders_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir metotun içine parametre ile bir referanslı dizi attın, o dizinin referansı değiştikten sonra
            // ilk girerken tuttuğu içeriğin kaybolmaması için onun referansını return edebilirsin
            // Yani referansla soktuğun bir parametrenin kaybolmaması için referansını return edebiliyorsun:

            int sonuc = 0;
            int refSonuc = GetSum(ref sonuc);

            Console.ReadKey();
        }

        static ref int GetSum(ref int sum)
        {
            int toplam = 10;
            ref int refToplam = ref toplam; // metot çalıştıktan sonra yok olacağı için metodun içinde tanımladığın şeylerin referansını return edemiyorsun.

            return ref sum;
        }
    }
}
