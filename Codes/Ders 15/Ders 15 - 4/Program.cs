using System;

namespace Ders_15___4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            /* metotlarda erişim belirleyicisi yazdığımızda default olarak private olur fakat local fonksiyonlar içinde tanımladığımız metotlara erişim belirleyicisi atayamayız.
             * niteleyici olarak da sadece static kullanılır. */
        }

        static void test(in int sayi) //gelen parametrenin değiştirilmesini önlemek için "in" keyword kullanılır
        {
            
        }
    }
}
