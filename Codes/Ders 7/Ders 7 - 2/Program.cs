// See https://aka.ms/new-console-template for more information


// asal sayı bulma

//bool bolenVarmi = false;
//for (int i = 2; i < 100; i++)
//{
//    bolenVarmi = false;
//    for (int j = 2; j <= i/2 ; j++)
//    {
//        if(i % j == 0)
//        {
//            bolenVarmi=true;
//            break;
//        }
//    }
//    if (!bolenVarmi || i == 2)
//    {
//        Console.WriteLine($"{i} bir asal sayıdır");
//    }
//}

//************************************************************************************************

//int sayi;
//int toplam = 0;
//bool check = false;
//do // kullanıcıdan veri alınacak durumlarda do while kullanılması daha mantıklı bir seçim
//{
//    Console.WriteLine("Sayi: ");
//    check = int.TryParse(Console.ReadLine(), out sayi); // tryparse ile dönüştürdüğünde eğer çeviri yapamazsa outtaki değişkene default olarak 0 verir
//    toplam += sayi;
//    Console.WriteLine($"Toplam = {toplam}");
//} while (!check || sayi != 0);

/* check false ise veya kullanıcı 0 girmediyse toplam devam edecek. Kullanıcı sayi girmezse check false olacak sayi 0 olacak döngü devam edecek yeniden sayı istenecek
 * ama kullanıcı sıfır girerse hem check true olacak hem de sayi 0 olacak dolayısıyla döngü bitecek. Yani burada kullanıcı bilinçli olarak 0 girmediği sürece
 * döngü devam ettirilecek */

//************************************************************************************************

//int number;
//int sum = 0;
//bool check = false;
//string value = "";
//do 
//{
//    Console.WriteLine("Sayi: ");
//    value = Console.ReadLine();
//    check = int.TryParse(value, out number);
//    sum += number;
//    Console.WriteLine($"Toplam = {sum}");
//} while (value != "ok"); // kullanıcı ok yazmadığı sürece toplama devam edecek

//************************************************************************************************

// kullanıcı kaçıncı fibonacci sayısını istiyorsa yazdırma. Fib sayıları 1 1 2 3 5 8 13...

//Console.WriteLine("Kaçıncı fibonacci sayısını istiyorsunuz?");
//bool negirdi = int.TryParse(Console.ReadLine(), out int kacinci);
//int ilkSayi = 1, ikinciSayi = 1, fibo = 0;
//if (negirdi && kacinci != 0)
//{
//    if (kacinci == 1 || kacinci == 2)
//    {
//        Console.WriteLine($"{kacinci}.fibonacci sayisi = {ilkSayi}");
//    }
//    else
//    {
//        for (int j = 2; j < kacinci; j++)
//        {
//            fibo = ilkSayi + ikinciSayi;
//            ilkSayi = ikinciSayi;
//            ikinciSayi = fibo;
//        }
//    }
//    Console.WriteLine($"{kacinci}.fibonacci sayisi = {fibo}");
//}


