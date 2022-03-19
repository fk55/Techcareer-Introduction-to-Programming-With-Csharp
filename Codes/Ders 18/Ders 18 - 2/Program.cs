using System.IO;
using System.Text; // UTF-8 karakter kodunu kullanmak için ekledik

FileStream dosyaAkisi = new FileStream("deneme.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // harddiskteki bir dosya ile stream kurmanı sağlar.
// FileStream genelde bu kalıpta kullanılırmış.
// append ekleyerek yazma

StreamWriter writer = new StreamWriter(dosyaAkisi); // bu şekilde de kullanılıyor direk ayrı ayrı içine parametre girmene gerek kalmıyor. 

string data = "furkan ince";
byte [] buffer = Encoding.UTF8.GetBytes(data);
dosyaAkisi.Write(buffer, 0, buffer.Length); // bir byte dizisi alıp ascii kodlarıyla işlem yaparmış. 0 nereden başlayacağı. Buffer length ile de tüm datayı yaz demiş gibi oluyoruz.
dosyaAkisi.Close();

for (int i = 0; i < data.Length; i++)
{
    dosyaAkisi.WriteByte((byte)data[i]); //filestreamda bytelar üzerinden ilerliyor olaylar.
}
dosyaAkisi.Close();


string metin = "";
int value = dosyaAkisi.ReadByte(); // peekteki gibi okuyamadığı zaman -1 döner
while (value != -1) 
{
    metin += (char)value;
}
Console.WriteLine(metin);

dosyaAkisi.Position = 4; // kaçıncı karakterden işlemler yapılacağını seçebiliyoruz yani pozisyon veriyoruz
dosyaAkisi.Seek(0, SeekOrigin.Current); // Kaçıncı karakterden itibaren arayacağı, ikinci parametre de nereden arayacağı current/end/begin olabiliyor.
// yukarda pozisyon 4 verdik mesela aşağıda da current dersek 4.den itibaren arar.