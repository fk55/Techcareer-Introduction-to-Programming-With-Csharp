
/************ Char Methods **********/

char letter = 'a';

char.IsWhiteSpace(letter); // boşluk mu diye bakıyor

char.IsUpper(letter); // büyük mü küçük mü kontrol eder islower da var.

char.IsControl(letter); // ctrl tuşuna basıldı mı kontrol eder

char.IsSymbol(letter); // | gibi bir sembol mu kontrol eder

char.IsDigit(letter); // rakam mı

string password = "TechCareer1234";
int[] counters = new int[3];

foreach (char item in password)   // metindeki küçük harf büyük harf ve rakam sayısını tespit ediyoruz
{
    if (char.IsUpper(item))
    {
        counters[0]++;
    }
    else if (char.IsLower(item))
    {
        counters[1]++;
    }
    else if (char.IsDigit(item))
    {
        counters[2]++;
    }
}



