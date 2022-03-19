


float floatsayi = 10.1F;
double doublesayi = 10.2;
decimal decimalsayi = 10.3M;

// Küsüratlı bir sayı girdiğinde onu otomatik double algılar. Burada diğerlerinde hata vermesinin sebebi de double bir veriyi
// başka değişkenlere atama çalışıyormuşsun gibi algılaması. Çözüm olarak sonlarına float için F (double için de gizli bir D var) decimal için M
// Decimal için M olmasının sebebi eskiden o tipin Money olarak kullanılması.

Console.WriteLine("float min değeri : {0} - max değeri : {1} - boyutu : {2}", float.MinValue, float.MaxValue, sizeof(float));
Console.WriteLine("double min değeri : {0} - max değeri : {1} - boyutu : {2}", double.MinValue, double.MaxValue, sizeof(double));
Console.WriteLine("decimal min değeri : {0} - max değeri : {1} - boyutu : {2}", decimal.MinValue, decimal.MaxValue, sizeof(decimal));