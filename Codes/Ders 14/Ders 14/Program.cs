// See https://aka.ms/new-console-template for more information

/* Metoda parametre girerken değer tipli bir değişken girdiğinde metot bakıyor onun içinde bir değer var, o değeri alıyor.
 * Ama dizi gibi referans tipli bir şey girdiğinde bakıyor içinde başka bi adres yazıyor o zaman metot o adresi alıyor.
 * ikisi de heapte aynı adresi gösteriyor olmuş oluyor. O yüzden metot içinde bir değişiklik olduğunda direk o adreste gerçekleşmiş oluyor değişiklik.
 * Dolayısıyla o adresi işaret eden değişken çağrıldığında, o adresteki bilgi değiştiği için değişkenin çıktısı da değişmiş olur. */


/************* Pass by value / pass by referance *******************/

/* Referansın geçmesi --> Adres bilgisinin geçmesi.  Ref keywordu kullanılarak değer tipli bir değişkenin de orjinalinin geçmesi sağlanılabilir.
 * 
 */

//int sayi1 = 10;
//int sayi2 = 20;
//Console.WriteLine(sayi1 + " " + sayi2);
//change(ref sayi1,ref sayi2);  // parametre olarak verirken de referansını verdiğimizi belirtmeliyiz
//static void change(ref int firstNumber,ref int secNumber)
//{
//    int temp = firstNumber;
//    firstNumber = secNumber;
//    secNumber = temp;
//}

// bu şekilde kullandığımızda orjinal değerler değişmiş oluyor ve sayi1 ile sayi2 yer değiştirmiş oluyor.

/***********************************************************************/

//int sayi3 = 3;
//ref int refSayi = ref sayi3; // bu şekilde sayıları birbirine bağlamış oluyoruz bir nevi. İkisi de ramde aynı adresi tutulduğu için birinde olan değişiklik diğerini de etkiler.
//refSayi = 40;
//sayi3 = 24;
//Console.WriteLine(sayi3);
//Console.WriteLine(refSayi); 

/***********************************************************************/

//int[] dizi = { 8,14,32,6 };

//static void changeArray(int[] numbers)
//{   
//    numbers[0] = 1; // Bunu yaptığında değişir 0.indis 1 olur
//}
//static void newArray(int[] numbers)
//{
//    numbers = new int[] {10,20}; // Ama bunu yaptığında değişmez
//}
//static void writeItems(int[] numbers)
//{
//    foreach (int item in numbers)
//    {
//        Console.WriteLine(item);
//    }
//}
//newArray(dizi);
//writeItems(dizi);
//Console.WriteLine("*********************");
//changeArray(dizi);
//writeItems(dizi);

///* Neden böyle oldu bakalım;
// * Şimdi newArrayda ilk dizinin heapteki içeriği gösteren adresi geldi XYZ diyelim. Metodun içinde new int ile yeni bir dizi oluşuyor onun adresi de ABC olsun. 
// * numbers = new int[] {10,20}; verdiğimizde metodun içinde adresi XYZ olan geçici dizinin adresi değişiyor ABC oluyor. XYZ adresinin içeriği değişmemiş aynı kalmış oluyor.
// * Bu yüzden parametre olarak giren dizide herhangi bir değişiklik olmuyor onun adresi XYZ ve içeriği 8 14 32 6 olarak kalıyor. */

//static void newArrayRefli(ref int[] numbers) /* burada referanslı verirsek gelen dizi 10,20 olur. Burada işleyen mekanizma da şu şekilde
//                                              * Yukarıda giren dizinin heapteki içeriği gösteren adresi geçiyor demiştik. Bu şekilde verdiğimizde ise
//                                              * metottaki geçici dizi giren parametrenin stackteki yerini işaret ediyor. O yüzden ABC adresi verildiğinde geçici dizi
//                                              * gidiyor dışardaki dizinin adresini ABC yapıyor.
//                                              * Burada biraz beynim yandı düzgün ifade edememiş olabilirim umarım sonradan baktığında anlarsın. Tam anlayamamış da olabilirim.
//                                              * Ya kısaca şöyle düşün ref keywordu ile verdiğinde komple birbirine bağlanıyor.*/
//{
//    numbers = new int[] { 10, 20 }; 
//}

//newArrayRefli(ref dizi);
//writeItems(dizi);

/***********************************************************************/

string[] dizi = { "xxx", "yyy", "zzz" };

static void MyResize(ref string[] values, int newLength)
{
    string[] newValues = new string[newLength];
    for (int i = 0; i < newLength && i < values.Length; i++) // Eğer giren dizinin uzunluğu 3 çıkacak olanın 5 olursa atama yaparken 4. ve 5. elemanları atarken hata verecek
    {                                                        // Çünkü gelen dizide 3 eleman var. Onun için aynı zamanda i < gelen dizinin uzunluğundan dedik.
        newValues[i] = values[i];
    }
    values = newValues;
}

Array.Resize(ref dizi, 6); // yukarda bunun metot halini yaptık