// See https://aka.ms/new-console-template for more information
Console.WriteLine("4 basamaklı bir sayı giriniz");
int sayi;
bool check = int.TryParse(Console.ReadLine(),out sayi);



if (check)
{
    if (sayi >= 1000 && sayi <= 9999)
    {
        Console.WriteLine("Sayinin Çözümlenmiş hali;");

        Console.WriteLine($"{(sayi % 10)} x 1 = {sayi % 10}");
        Console.WriteLine($"{((sayi % 100) - (sayi % 10)) / 10} x 10 = {(sayi % 100) - (sayi % 10)} ");
        Console.WriteLine($"{((sayi % 1000) - (sayi % 100)) / 100} x 100 = {(sayi % 1000) - (sayi % 100)}");
        Console.WriteLine($"{(sayi / 1000)} x 1000 = {(sayi / 1000) * 1000}");
    }
    else
    {
        Console.WriteLine("Lütfen 1000 ile 9999 arasında bir değer giriniz");
    } 
}
else
{
    Console.WriteLine("Lütfen bir sayı giriniz");
}

