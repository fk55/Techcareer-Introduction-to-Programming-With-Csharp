// See https://aka.ms/new-console-template for more information

// girilen sayıları toplayarak gitme = deyince sonuç verme 0 girilince durdurma.
//Console.WriteLine("sayı ver");
//int sayi;
//string girdi = " ";
//int toplam = 0;
//while (girdi != "0")
//{
//    girdi = Console.ReadLine();

//    if (girdi == "=")
//    {
//        Console.WriteLine($"Toplam = {toplam}");
//    }
//    else
//    {
//        if (int.TryParse(girdi, out sayi))
//        {
//            toplam += sayi;
//        }
//        else
//        {
//            Console.WriteLine("Geçersiz Değer");
//        }
//    }
//}

//*********** ÇOK BOYUTLU DİZİLER *************** //

// 1 Matris diziler     2 Düzensiz (jagged) diziler

//int[,] numbers = new int[2, 3]; // 2 boyutlu bir dizi tanımladık sol tarafta boyut belirtiyoruz [,] şeklinde. Öbür tarafta ise genişliğini kaça kaç olacağını
//numbers[0, 0] = 1;
//numbers[0, 1] = 2;
//numbers[0, 2] = 3;
//numbers[1, 0] = 4;
//numbers[1, 1] = 5;
//numbers[1, 2] = 6;
//// bunlarda gezmek için iç içe for lazım.

//for (int i = 0; i < numbers.GetLength(0); i++) // GetLength ile boyut numarasını veriyoruz burada önce ilk boyutu döndük
//{
//    for (int j = 0; j < numbers.GetLength(1); j++) // burada ise ikinci boyutu döndük
//    {
//        Console.WriteLine(numbers[i , j]);
//    }
//}
//Console.WriteLine(numbers.GetUpperBound(0)); // ilk boyutun üst sınırı
//Console.WriteLine(numbers.GetLowerBound(0)); // alt sınırı

//******************************************************************************************************************************

// Jagged arrays --> Her bir elemanı yine dizi olan dizi

//int[][] numbers = new int[3][]; /* şimdi burda 3 yazdık ama yanı boş neden. 3 dediğimizde dizi içeren dizinin kaç elemanı olacağını söylüyoruz.
//                               * yani içinde kaç dizi olacak. Yan tarafı da boş bırakıyoruz çünkü içindeki dizilerin eleman sayıları farklı olabilir. */
//numbers[0] = new int[] { 1, 2, 3 };
//numbers[1] = new int[] { 10 };
//numbers[2] = new int[] { 13, 25 };
//// bir dizinin içinde üç farklı dizi tanımladık. 3 elemanı olan bu dizinin her bir elemanı başka birer dizi

//Console.WriteLine(numbers.Length); // 3 basar çünkü üç elemanı var
//Console.WriteLine(numbers[2].Length); // indisi 2 olan dizinin uzunluğunu basar yani 2 ( 13 ve 25 olan )

//******************************************************************************************************************************

//int[] sayilar = { 1, 2, 3, 4, 3, 6 };

//Array.IndexOf(sayilar, 3); // sayilar dizisinde varsa 3'ün olduğu indexi verir yoksa -1 döner. Birden fazla 3 varsa ilk gördüğü yerin indexini veriyor.
//Array.LastIndexOf(sayilar, 3); // yukardakinin aynısı ama bu sondan dönüyor

//Array.Reverse(sayilar); // diziyi ters çevirir
//int[] yeniSayilar = new int[sayilar.Length];
//Array.Copy(sayilar, yeniSayilar, sayilar.Length); // aldığı parametreler: kaynak - hedef - ne kadar kopyalanacağı
//Array.Sort(sayilar); // diziyi sıralar küçükten büyüğe
//Console.WriteLine(Array.BinarySearch(sayilar, 3));  // bunu kullanmamız için düzenli sıralanmış olması lazım dizinin. 3ü arayıp indexini dönüyor
//Array.Resize(ref sayilar, 8); // ikinci parametre yeni boyut

//******************************************************************************************************************************

// kullanıcının girdiği sayılarla otomatik dizi oluşturma
//int[] values = new int[0];
//string value = string.Empty;
//bool check = false;

//do
//{
//    Console.WriteLine("Sayı: ");
//    value = Console.ReadLine();
//    check = int.TryParse(value, out int number);

//    if (check)
//    {
//        Array.Resize(ref values, values.Length + 1);
//        values[values.Length - 1] = number;
//    }
//} while (value != "ok");

//******************************************************************************************************************************
//int[] numbers = { 1, 2, 3, 4, 5 };
//int gecici;
//for (int i = 0; i < numbers.Length; i++)
//{
//    gecici = numbers[i];
//    numbers[i] = numbers[numbers.Length - 1 - i];
//    numbers[numbers.Length - 1 - i] = gecici;

//    if (i == numbers.Length - 1 - i)
//    {
//        break;
//    }
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    Console.WriteLine(numbers[j]);
//}
//**********************************************************************************************************************************

// 14.02.2022
