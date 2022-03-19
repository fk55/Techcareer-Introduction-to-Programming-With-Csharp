// See https://aka.ms/new-console-template for more information

/* Üç çeşit hata vardır;
 * 1. Syntax -> Compiling Time
 * 2. Runtime hataları -> Uygulama çalıştığında çıkan hatalar
 * 3. Logic -> Mantıksal hatalar */

//try-catch

try
{
    int number = int.Parse(Console.ReadLine());
    // denenecek kod
}
catch (Exception hata) // hata ile ilgili bilgileri bir değişkene atar
{
    // hata oluşunca çalışacak kod
    // Loglama 
    Console.WriteLine(hata);
    Console.WriteLine(hata.Message);
    Console.WriteLine(hata.Source); 
    Console.WriteLine(hata.StackTrace);  // hatanın izi kaynağı
    Console.WriteLine(hata.InnerException); // zincirleme hata olduğu durumlarda. innerex.innerex... diye birkaç kez bağlı da kullanılıyo
}
finally
{
    // genelde farklı kaynaklara bağlantı atmaya çalıştığında bu da kullanılır. İşlevi tam anlamadım. Sanırım catch olduktan sonra çalışıyor. Yani aslında
    // catch içine de yazılabilirmiş ama yönetim kolaylığı açısından böyle yapılıyormuş. Database örneği verdi  
}


// farklı farklı hata türlerini yakalayıp ona göre aksiyon almak için aşağıdaki gibi kullanım yapılır

try
{

}
catch (FormatException fex) // format hatası durumunda
{

}
catch (OverflowException overflow) // taşma hatası durumunda
{

}
catch (DivideByZeroException dex)
{

}
catch (Exception ex)
{

}
// burada da switch caselerdeki çakışma durumunda olduğu gibi sıralama önemlidir. Exception geneldir tüm hataları kapsar o yüzden spesifik olanları yukarıda vermek lazım

// kendi hata tiplerini de yaratabilirsin. Örneğin kullanıcıdan almak istediğin sayı bir değer aralığında olmalı. Böyle durumlar için de aşağıdaki gibi bi kod kullanılıyor


int number = 100;
if (number > 50)
{
  throw new Exception();
}


// müthiş bir kısayol: alanı seçip ctrl+k+s ile bişeyin içine alabiliyosun