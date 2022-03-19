


string path = "C:/deneme";

if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}

// Klasörlerle de çeşitli işlemler yapılabiliyor dizine bak, yoksa yarat yaptık yukarda.

string[] files = Directory.GetFiles(path);

foreach (string file in files)
{
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileName(file));
}

// bu şekilde dosyaların uzantılarını isimlerini vb getirebiliyoruz.

File.WriteAllText(Path.Combine(path, "george.txt"), "merhaba dünya");

List<string> data = new List<string>() { "xxxx", "yyyy", "zzzz" };
File.WriteAllLines(Path.Combine(path, "xyz.txt"), data); // bu şekilde bir listeyi de satır satır yazdırabiliyoruz
