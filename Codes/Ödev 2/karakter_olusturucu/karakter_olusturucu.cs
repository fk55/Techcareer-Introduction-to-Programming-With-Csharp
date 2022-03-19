// See https://aka.ms/new-console-template for more information

Random rnd = new Random();

char harf;

for (int i = 1; i <= 10; i++)
{
    harf = Convert.ToChar(rnd.Next(65, 91));

    if (i == 1)
    {
        Console.Write($"Merhaba, ben {harf}");
    }
    else if (i % 5 == 0)
    {
        
        Console.Write($"{harf} ");
    }
    else
    {     
         Console.Write(harf);
    }
}

int gun = rnd.Next(1, 30);
int ay = rnd.Next(1, 12);
int yil = rnd.Next(1900, 2021);

Console.Write($"{gun}/{ay}/{yil} tarihinde dünyaya geldim");

