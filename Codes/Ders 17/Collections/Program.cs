using System.Collections;
using System.Collections.Generic;

/* koleksiyonların çalışma sistemi dillere göre farklılık gösterebilir fakat diziler öyle değildir. Bir dizi ifadesini
tüm diller ortak olarak okuyabilir. Mikroservisler gibi birbirleriyle konuşan farklı teknolojilerdeki yazılımlar birbirleriyle diziler yoluyla haberleşir.
*/

ArrayList diziList = new ArrayList();
Console.WriteLine(diziList.Count); // eleman sayısı
diziList.Add("bu yazıyı ekler");
diziList.Add(3);

// koleksiyonlar kendiliğinden boyutlanır. boyut 2nin katlarına göre ilerler. 2 4 8 16 gibi eleman eklendikçe ihtiyaca göre kapasitesini artırır.
// bu kapasite ramden yer yemiyor ama önden hazırlık yapıyor bi bir şey.

diziList.TrimToSize(); // fazla olan boşlukları atıyor. Otomatik olarak 5 eleman varken 8lik boşluk tutar.
                       // Trimtosize yaptığın zaman kapasitesini eleman sayısına göre ayarlar fazla boşlukları atar ve 5 olur

diziList.Insert(3, "3.indexe ekle"); // verdiğin index numarasına 2.parametreyi ekler.
diziList.Remove("3.indexe ekle"); // parametrede verileni siler. Birebir vermen lazım ama neyi sileceksen. Çünkü farklı farklı tipler tutuyor içinde
// aynı değerden birden fazla varsa hepsini siler.
diziList.RemoveAt(2); // verilen indexteki elemanı siler
diziList.RemoveRange(1, 3); // 1.indexten başla 3 eleman kaldır


/******** Hashtable ********/

Hashtable hastablosu = new Hashtable(); // key üzerinden vs erişme konusunda dizilerden arrayListten daha hızlıdır.
hastablosu.Add("elma", "apple");
hastablosu.Add("fare", "mouse");
hastablosu.Add("kalem", "pencil");

//foreach (DictionaryEntry item in hastablosu)
//{
//    Console.WriteLine(item.Key + " " + item.Value); //Bu şekilde key value şeklinde gezebiliriz
//}

foreach (string s in hastablosu.Keys)
{
    Console.WriteLine(hastablosu[s]); // valueleri bastırıyosun. Fakat bu değerler sıralı olarak tutulmaz o yüzden her döndürdüğünde farklı sıralamayla gelebilir.
}

string kelime = Console.ReadLine();

if(hastablosu.ContainsKey(kelime))
{
    Console.WriteLine(hastablosu[kelime]);
}
else
{
    Console.WriteLine("Yanlış Kelime");
}

/******** Queue Stack ********/

// LIFO => Last in First Out
// FIFO => First in First Out

Queue kuyruk = new Queue();
kuyruk.Enqueue(1);
kuyruk.Enqueue("george");
kuyruk.Enqueue(3.14);

foreach (var item in kuyruk)
{
    Console.WriteLine(item);
}

kuyruk.Dequeue(); // sırayla çıkış olur ilk giren eleman ilk çıkar böyle sırayla devam eder.
kuyruk.Peek(); // kuyruktan çıkacak sıradaki elemanı gösteriyor.

/******* Stack *********/
Stack yigin = new Stack();   // queuenin LIFO hali. Üst üste bişeyler yığmak gibi düşün ilk koydukların altta kalır alırken son koyduklarından alırsın
yigin.Push(32); // ekle
yigin.Pop(); // çıkar

/******* sortedList ******/
// içindekileri key'e göre otomatik sıralar.
SortedList sortlist = new SortedList();
sortlist.Add("key", "value");

// Bunlar non-generic koleksiyonlardı

/************ Generic Collections *************/
/* non generic koleksiyonlarda tüm girdiler object tipindedir bu da boxing-unboxinge sebep olur. Dolayısıyla performans maliyeti yüksektir.
 * Ama eğer object tipli bir şeyler kullanman gerekiyorsa non-generic kullanman daha faydalıdır.
 * Non-genericte içinde hangi data tiplerini kullanacağını önden tanımlıyorsun. Dolayısıyla boxing-unboxingden kaçınmış oluyorsun.
 */

List<int> sayilar = new List<int>();
List<string> yazilar = new List<string>();

/******* Dictionary ******/
Dictionary<int, string> sozluk = new Dictionary<int, string>(); // hashtablenin generic versiyonu

foreach (KeyValuePair<int,string> item in sozluk)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

/******* LinkedList ******/
LinkedList<string> values = new LinkedList<string>(); // birbirine bağlı ögeler tutar. Blockchain mantığına benziyor aslında biraz. Her bir node bi önceki ve sonraki node'u biliyor.
LinkedListNode<string> first = new LinkedListNode<string>("deneme");
values.AddFirst(first);
values.AddAfter(first, "test"); // firstten sonra test ekle

/******** Hashset ********/

HashSet<string> hess = new HashSet<string>(); // Koleksiyonların en hızlısıdır. Bir key değeri saklamaz. Hash değeri üretir
// spesifik olarak içinden şunu getir bunu getir diyemiyorsun anladığım kadarıy.a
hess.Add("xxx");

foreach (var item in hess)
{
    Console.WriteLine(item);
}

// anca böyle yazdırabiliyosun sanırım

//*************************************** Sonradan Ek *****************

string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
List<string> hayvanListesi = new List<string>(hayvanlar); // constructor içine parametre olarak dizi verip o dizinin elemanlarıyla bir liste oluşturmasını sağlayabiliyoruz

hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan)); // böyle bir foreach da mümkün



