// See https://aka.ms/new-console-template for more information



ConsoleKeyInfo keyInfo = Console.ReadKey(); // tuş değişkeni yarattık farklı bir veri tipi olarak düşünebilirsin. 
Console.WriteLine(keyInfo.Key);
/* bir şey yazdığında onun hangi tuş olduğunu veriyor. Mesela alt f4 basınca kapanır bunun gibi şeyler tuşlarla çalışır.
 * Dolayısıyla bir uygulama yazarken tuşlara işlevler atayabilirsin. ReadKey girilen değeri değil tuşu okur. */

//if (keyInfo.Key == ConsoleKey.K)  // a tuşuna basılınca aşağısı çalışır
//{
//    Console.WriteLine("K tuşuna basıldı");
//}

switch (keyInfo.Key) // burada hocanın intellisensi otomatik tüm tuşları getirdi ama ben de olmadı niyeyse
{
    case ConsoleKey.A:
        Console.WriteLine("Sola");
        break;
    case ConsoleKey.S:
        Console.WriteLine("Aşağı");
        break;
    case ConsoleKey.D:
        Console.WriteLine("Sağa");
        break;
    case ConsoleKey.W:
        Console.WriteLine("Yukarı");
        break;
} 