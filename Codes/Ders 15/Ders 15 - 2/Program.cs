using System;

namespace Ders_15___2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Metot sonucu birden fazla çıktı almak için out kullanılır. 
             * İş yapıldığında ana çıktının yanında yan çıktıları da yakalamak için out kullanıyoruz*/

            //string sehir = "İstanbul";
            //Test(out sehir);
            //string kelime = kelimeveilkharf(out char harf, out int x);  // hem kelimeyi return ediyor aynı zamanda içerde yakaladığın diğer çıktıları da kaybetmiyorsun //
            //Console.WriteLine(kelime + "****" + harf + "****"+ x);

            // TryParse'da da out var mesela

            /*************************************************************************************/

            //Console.WriteLine(getDecimalParts(123.4567M, out decimal kusurat));
            //Console.WriteLine("Küsürat:" + kusurat);

            /*************************************************************************************/



            //Console.ReadKey();
        }

        static void Test(out string city)
        {
            city = ""; // out giren parametre içerde bir değer almak zorunda
            
        }

        static string kelimeveilkharf(out char ilkHarf, out int n)// outları metotu çalıştırırken verdiğin sıralamaya göre döner
        {
            string kelime = "boole";
            ilkHarf = kelime[0];
            n = 5;
            return kelime;            
        }

        static int getDecimalParts(decimal sayi, out decimal ondalik)
        {
            int tamKisim = (int)sayi;
            ondalik = sayi - tamKisim;
            return tamKisim;
        }

        static bool myTryParse(string value, out int number)
        {
            bool result = false;
            try
            {
                number = int.Parse(value);
                result = true;
            }
            catch
            {
                number = default(int);
                result = false;
            }
            return result;
        }
    }   
           
}
