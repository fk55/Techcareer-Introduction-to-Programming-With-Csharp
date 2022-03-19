using System;

namespace Ders_15___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni Giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("Aramak istediğiniz harfi giriniz");
            char harf = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(search(metin, harf, out int sayi));
            Console.WriteLine(sayi);
            Console.ReadKey();


        }
        /// <summary>
        /// Metinde harf arama.
        /// </summary>
        /// <param name="text">İçinde aranılacak metin</param>
        /// <param name="letter">Arama yapılacak harf</param>
        /// <returns></returns>
        static bool search(string text, char letter, out int count) // metotun üst satırında üç kere /// yaparsan metoda dair açıklama metni açılıyor. 
        {
            bool isExist = false;
            count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    count++;
                    isExist = true;
                }
            }
            return isExist;
        }
    }
}
