// See https://aka.ms/new-console-template for more information


Console.WriteLine("Bir sayı girin");
int sayi;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out sayi))
    {
        if (sayi % 7 == 0)
        {
            Console.WriteLine($"{sayi} 7'nin {sayi / 7} katıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} sayısının 7 ile bölümünden kalan: {sayi % 7}");
        }
    }
    else
    {
        Console.WriteLine("sayı değil");
    }
}

byte operation = byte.Parse(Console.ReadLine());  // üşendim tam yazmadım işte kullanıcıdan iki sayı alıyosun sonra toplama için 1 çıkarma için 2 çarpma 3 bölme 4 basınız diyosun
int firstNumber;
int secondNumber;
switch (operation)
{
    case 1:
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case 2:
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case 3:
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case 4:
        Console.WriteLine(firstNumber / secondNumber);
        break;
    default:
        break;
}

// switch case bu tür durumlarda performans açısından iften daha iyi. İf elsede tek tek tüm elseiflere bakılır. İlk koşul eşleşmezse 2.sine, eşleşmezse 3.süne diye gider
// fakat switch casede direk operasyon numarası olan duruma gider yani 4 düğmeden birine basmak gibi düşünebilirsin. Break kullanmamızın sebebi de eğer break olmazsa 
// diğer caselerde çalışmaya devam eder o yüzden bir yerde durdurmamız lazım. Defaultun işlebi de else ile aynı. Hiçbir eşleşme olmazsa default kısmı çalışır.

