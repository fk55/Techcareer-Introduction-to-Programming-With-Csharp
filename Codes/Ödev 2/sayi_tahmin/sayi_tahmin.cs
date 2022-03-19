// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz, sıfırdan büyük bir sayı tutun ve en fazla kaç olabileceğini girin");
Console.WriteLine("Tuttuğunuz sayı en fazla kaç olabilir?");

int maxdeger;
int.TryParse(Console.ReadLine(), out maxdeger);

if (maxdeger > 0)
{
    maxdeger += 1;
    Console.WriteLine("Cevap Doğruysa 'E' yanlışsa 'H' tuşuna basınız");
    Random rnd = new Random();
    string cevap = "H";
    string azcok;
    int tahmin = 0;
    int mindeger = 1;
    while (cevap == "H")
    {
        
        tahmin = rnd.Next(mindeger, maxdeger);
        Console.WriteLine($"Tuttuğun sayı {tahmin} ?");
        cevap = Console.ReadLine();
        if (cevap == "H")
        {
           Console.WriteLine("Daha mı az daha mı çok? 'AZ' veya 'ÇOK' olarak cevap veriniz");
           azcok = Console.ReadLine();
           if (azcok == "AZ")
            {
                maxdeger = tahmin;
            }
           else if (azcok == "ÇOK")
            {
                mindeger = tahmin+1;
            }
            else
            {
                Console.WriteLine("Geçersiz değer");
                break;
            }
        }
        else if (cevap == "E")
        {
            Console.WriteLine("BİLDİMMM!!");
        }
        else
        {
            Console.WriteLine("Geçersiz değer");
            break;
        }
    }
     
}
else
{
    Console.WriteLine("Geçersiz değer girdiniz");
}