
using System.Collections;

string userName = getUsername();
mathPractise(userName);

#region Matematik Pratiği
/// <summary>
/// Uygulamamızın temel metodu. Matematik pratiği uygulamasını çalıştırır.
/// </summary>
static void mathPractise(string userName)
{
    int falseCounter = 0; // Yanlış cevap sayacımız
    int score = 0;  // Skor puanını tutan değişken
    string answer = string.Empty; // Kullanıcının cevabını tutan değişken


    while (answer != "exit" && falseCounter < 6)
    {
        if (score < 30) // skora göre hangi seviyenin oynanacağını belirleyen if-else bloğu
        {
            level1(ref score, ref falseCounter, ref answer);
        }
        else if (score >= 30 && score < 80)
        {
            if ((score == 30))
            {
                Console.WriteLine("---2. Seviyeye Ulaştınız!---");
            }
            level2(ref score, ref falseCounter, ref answer);
        }
        else
        {
            if ((score == 80))
            {
                Console.WriteLine("---3. Seviyeye Ulaştınız!---");
            }
            level3(ref score, ref falseCounter, ref answer);
        }
    }
    Console.WriteLine($"Oyun sona erdi. Skorunuz: {score}");

    List<KeyValuePair<string, int>> scoreBoard = new List<KeyValuePair<string, int>>();
    readFromFile(scoreBoard); // Mevcut skor tablosu okunuyor
    checkPastScores(userName, score, scoreBoard); // Kullanıcının daha önce kaydı var mı kontrol ediliyor
    sortByScore(scoreBoard); // Tablo sıralanıyor
    writeToFile(scoreBoard); // Dosyaya yazılıyor
    showTopThree(scoreBoard, userName); // İlk üç gösteriliyor
}
#endregion

#region Seviye 1
/******************* Seviye 1 ********************/

static void level1(ref int score, ref int falseCounter, ref string answer)
{
    Console.WriteLine("***** Seviye 1 *****");
    int number1;
    int number2;
    bool answerCheck = false;
    float userResult = 0;
    string operation;

    number1 = generateNumber(100);
    number2 = generateNumber(100);
    operation = operatorGenerator(2); // operatorGenerator metodu aldığı parametreye göre işlem üretiyor

    while (!answerCheck) // Cevap geçersiz değer olduğu sürece kullanıcıya tekrar soruluyor.
    {
        Console.WriteLine($"{number1} {operation} {number2} ?");
        answer = Console.ReadLine();
        editAnswer(ref answer);
        answerCheck = float.TryParse(answer, out userResult);

        if (!answerCheck)
        {
            if (answer == "exit")
            {
                return;
            }

            Console.WriteLine("Lütfen bir sayı giriniz");
        }
    }

    if (resultChecker(number1, number2, operation, userResult)) // Cevabın doğru olup olmadığı kontrol ediliyor
    {
        score += 5;
        Console.WriteLine($"Cevap doğru, puanınız = {score}");
    }
    else
    {
        falseCounter++;
        if (5 - falseCounter < 0)
        {
            Console.WriteLine($"Yanlış cevap hakkınız bitti!");
        }
        else
        {
            Console.WriteLine($"Yanlış cevap! Kalan yanlış cevap hakkınız: {5 - falseCounter}");
        }
    }

}
#endregion

#region Seviye 2
/******************* Seviye 2 ********************/

static void level2(ref int score, ref int falseCounter, ref string answer)
{
    Console.WriteLine("***** Seviye 2 *****");
    int number1;
    int number2;
    bool answerCheck = false;
    float userResult = 0;
    string operation;

    number1 = generateNumber(1000);
    number2 = generateNumber(1000);
    operation = operatorGenerator(4);

    while (!answerCheck)
    {
        Console.WriteLine($"{number1} {operation} {number2} ?");
        answer = Console.ReadLine();
        editAnswer(ref answer);
        answerCheck = float.TryParse(answer, out userResult);

        if (!answerCheck)
        {
            if (answer == "exit")
            {
                return;
            }
            else
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
            }
        }
    }

    if (resultChecker(number1, number2, operation, userResult))
    {
        score += 10;
        Console.WriteLine($"Cevap doğru, puanınız = {score}");
    }
    else
    {
        falseCounter++;
        if (5 - falseCounter < 0)
        {
            Console.WriteLine($"Yanlış cevap hakkınız bitti!");
        }
        else
        {
            Console.WriteLine($"Yanlış cevap! Kalan yanlış cevap hakkınız: {5 - falseCounter}");
        }
    }

}

#endregion

#region Seviye 3
/******************* Seviye 3 ********************/

static void level3(ref int score, ref int falseCounter, ref string answer)
{
    Console.WriteLine("***** Seviye 3 *****");
    int number1;
    int number2;
    bool answerCheck = false;
    float userResult = 0;
    string operation;

    number1 = generateNumber(10000);
    number2 = generateNumber(10000);
    operation = operatorGenerator(5);

    while (!answerCheck)
    {
        Console.WriteLine($"{number1} {operation} {number2} ?");
        answer = Console.ReadLine();
        editAnswer(ref answer);
        answerCheck = float.TryParse(answer, out userResult);

        if (!answerCheck)
        {
            if (answer == "exit")
            {
                return;
            }

            Console.WriteLine("Lütfen bir sayı giriniz");
        }
    }

    if (resultChecker(number1, number2, operation, userResult))
    {
        score += 20;
        Console.WriteLine($"Cevap doğru, puanınız = {score}");
    }
    else
    {
        falseCounter++;
        if (5 - falseCounter < 0)
        {
            Console.WriteLine($"Yanlış cevap hakkınız bitti!");
        }
        else
        {
            Console.WriteLine($"Yanlış cevap! Kalan yanlış cevap hakkınız: {5 - falseCounter}");
        }
    }

}
#endregion

#region Kullanıcı Adı Alma Metotu
/// <summary>
/// Kullanıcı adı alır ve girdide boşluk varsa temizler
/// </summary>
static string getUsername()
{
    Console.WriteLine("Kullanıcı Adı Giriniz: ");
    string userInput = Console.ReadLine();
    string userName = string.Empty;

    for (int i = 0; i < userInput.Length; i++)  // Kullanıcının girdiği adda boşluk varsa siler. (skor tablomuzun düzenini bozmaması için boşluk olmaması gerekiyor)
    {
        if (userInput[i] != ' ')
        {
            userName += userInput[i];
        }
    }
    return userName;
}
#endregion

#region Rastgele Sayı Oluşturan Metot
/// <summary>
/// Rastgele sayı oluşturur
/// </summary>
/// <param name="maxLimit">Oluşacak sayının üst limiti</param>
static int generateNumber(int maxLimit)
{
    Random rnd = new Random();
    return rnd.Next(1, maxLimit);
}
#endregion

#region İşlem Oluşturucu Metot
/// <summary>
/// Rastgele işlem türetir
/// </summary>
/// <param name="limit">Hangi işlemleri üreteceğini sınırlandırır, yalnızca toplama çıkarma için 2, çarpma bölme de eklemek için 4, mod da eklemek için 5</param>
/// <returns>İşlem operatörü döndürür</returns>
static string operatorGenerator(int limit)
{
    string[] operators = { "+", "-", "*", "/", "%" };
    Random rnd = new Random();
    int operationNo = rnd.Next(0, limit);
    string operate = operators[operationNo];
    return operate;
}
#endregion

#region Cevap Düzenleme Metotu
/// <summary>
/// Kullanıcının girdiği cevap nokta içeriyorsa virgüle çevirir
/// </summary>
static void editAnswer(ref string answer) // kullanıcı 3.41 gibi bir değer girdiğinde cevap 3,41 olsa bile yanlış cevap döner. Bunun önüne geçmek için oluşturuldu.
{
    if (answer.Contains('.'))
    {
        answer.Replace('.', ',');
    }
}
#endregion

#region Sonuç Kontrol Eden Metot
/// <summary>
/// Kullanıcıdan gelen cevap doğru mu değil mi kontrol eder
/// </summary>
/// <param name="number1">İlk sayı</param>
/// <param name="number2">İkinci sayı</param>
/// <param name="operation">Yapılacak işlem</param>
/// <param name="inputResult">Kontrol edilecek cevap</param>
static bool resultChecker(int number1, int number2, string operation, float inputResult)
{
    float result = 0;
    string[] stringResult;
    switch (operation)
    {
        case "+":
            result = number1 + number2;
            break;

        case "-":
            result = number1 - number2;
            break;

        case "*":
            result = number1 * number2;
            break;

        case "/":
            stringResult = ((float)number1 / (float)number2).ToString().Split(',');
            stringResult[1] = stringResult[1].Remove(2);
            result = float.Parse(string.Join(',', stringResult));
            // Bölme işlemlerinde hassasiyeti virgülden sonraki iki basamağın kontrol edilmesiyle sınırlandırarak
            // hassasiyeti düşürdüm ve kullanıcıdan gelen cevapların kontrolunu kolaylaştırdım. 
            break;

        case "%":
            result = number1 % number2;
            break;
    }

    if (result == inputResult)
    {
        return true;
    }
    else
    {
        return false;
    }
}
#endregion

#region Dosyaya Yazdıran Metot
/// <summary>
/// Dosyayla bağlantı kurup listeyi yazdırır.
/// </summary>
static void writeToFile(List<KeyValuePair<string, int>> scoreBoard)
{
    StreamWriter writeBoard = new StreamWriter("scoreBoard.txt");
    foreach (KeyValuePair<string, int> item in scoreBoard)
    {
        writeBoard.WriteLine(item.Key + " " + item.Value);
    }
    writeBoard.Flush();
    writeBoard.Close();
}
#endregion

#region Dosyadan Okuyan Metot
/// <summary>
/// Dosyayla bağlantı kurup içini okuyarak listeye ekler
/// </summary>
static void readFromFile(List<KeyValuePair<string, int>> scoreBoard)
{
    StreamReader readBoard = new StreamReader("scoreBoard.txt");
    string[] line;
    string temp;
    do
    {
        temp = readBoard.ReadLine();

        if (temp != "" && temp != null)
        {
            line = temp.Split(' ');
            scoreBoard.Add(new KeyValuePair<string, int>(line[0], int.Parse(line[1])));
        }

    } while (temp != "" && temp != null);

    readBoard.Close();
}
#endregion

#region En yüksek 3 Skoru Listeleme Metotu
/// <summary>
/// En yüksek 3 skoru listeler, kullanıcı içindeyse bilgilendirir
/// </summary>
static void showTopThree(List<KeyValuePair<string, int>> list, string userName)
{
    Console.WriteLine("***Yüksek Skorlar***");
    int counter = 1;
    bool isDegree = false;
    int degree = 0;
    foreach (KeyValuePair<string, int> item in list)
    {
        if (counter == 4)
        {
            break;
        }
        Console.WriteLine(counter + "--" + item.Key + " " + item.Value);

        if (userName == item.Key)
        {
            isDegree = true;
            degree = counter;
        }
        counter++;
    }

    if (isDegree)
    {
        Console.WriteLine($"Tebrikler! {list[degree - 1].Value} puanla {degree}. sırada yer alıyorsunuz.");
    }
}
#endregion

#region Kullanıcının Önceki Skorunu Kontrol Eden Metot
/// <summary>
/// Kullanıcının daha önce bir skor kaydı bulunup bulunmadığını kontrol eder. 
/// Daha önce kaydı yoksa yeni kayıt ekler, varsa listede en yüksek puanını tutar.
/// </summary>
static void checkPastScores(string userName, int score, List<KeyValuePair<string, int>> scoreBoard)
{
    foreach (KeyValuePair<string, int> item in scoreBoard)
    {
        if (item.Key == userName)
        {
            if (score > item.Value)
            {
                Console.WriteLine($"Kendi rekorunuzu kırdınız! Yeni rekorunuz: {score}");
                for (int i = 0; i < scoreBoard.Count(); i++)
                {
                    if (scoreBoard[i].Key == userName)
                    {
                        scoreBoard[i] = new KeyValuePair<string, int>(userName, score);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"En yüksek skorunuz: {item.Value}");
                return;
            }
        }
    }
    scoreBoard.Add(new KeyValuePair<string, int>(userName, score)); // Eğer kullanıcının daha önce skor kaydı varsa return
                                                                    // ile metot sonlanacağı için en sona kontrol etmeden yazabildim.
}
#endregion

#region Skor Tablosunu Puana Göre Sıralayan Metot
/// <summary>
/// Skora göre kullanıcıları sıralar
/// </summary>
static void sortByScore(List<KeyValuePair<string, int>> scoreBoard)
{
    int currentIndex;
    for (int i = 1; i < scoreBoard.Count(); i++)
    {
        var temp = scoreBoard[i];
        currentIndex = i;
        while (currentIndex > 0 && scoreBoard[currentIndex - 1].Value < scoreBoard[currentIndex].Value) /* Önceki değer indisteki değerden küçük olduğu sürece yer değiştiriyor
                                                                                                         * ve her yer değiştirmesinde yeni yerine göre de bir önceki indisle kıyaslıyor
                                                                                                         * böylece döngü halinde kendinden büyük olmayan indisin arkasına gelene kadar
                                                                                                         * devam ediyor */
        {
            temp = scoreBoard[currentIndex - 1];
            scoreBoard[currentIndex - 1] = scoreBoard[currentIndex];
            scoreBoard[currentIndex] = temp;
            currentIndex--;
        }
    }
}
#endregion

#region Notlar

/*  1-Skor, yanlış cevap sayısı ve cevap değişkenleri metotlarda referanslı olarak kullanılıyor çünkü bu değişkenler metotların içinde
 *  durumlara göre değişiyor ve bu değişiklikler uygulamanın gidişatında belirleyici oluyor;
 *  Skora göre seviye belirleniyor ve o seviyenin metotu çağrılıyor.
 *  Yanlış sayacına göre uygulama sona eriyor veya devam ediyor.
 *  Kullanıcıdan gelen cevap "exit" ise uygulama sona eriyor.
 *  
 *  2-Sonuç değişkenlerini "float" olarak ele aldım. Çünkü bölme işlemlerinde küsüratlı sonuçlar çıkabiliyor. Int ile float tipin ramde kapladığı alan aynı (4byte)
 *  Performans açısından rastgele türettiğimiz numaraları int yerine short vermeyi düşündüm fakat sürdürülebilirlik açısından daha fazla seviye eklendiğinde
 *  daha çok basamaklı sayılar kullanılabilir diye integer kullandım.
 *  
 *  3-Skorları tutabilmek için her bir elemanı anahtar-değer çifti olan bir liste kullandım. Önce sortedlist kullandım sıralamayı keylere göre yaptığı için
 *  skorları key olarak aldım fakat keylerin eşsiz olması gerekiyordu. Kullanıcıların aynı skoru alabileceği ihtimalini sonradan farkedip key-value listesine göre düzenledim.
 *  Sıralama için de ayrı bir metot yazdım.
 *  
 *  4-scoreBoard.txt yoksa hata geliyor onun sebebi dosyadan okuma komutunun yazmadan önce çalıştırılıyor olması. Önce dosyadan okuyup listeye atıyorum
 *  liste üzerinden işlemler yapıp en son güncel listeyi tekrar yazdırıyorum.
 *  
 *  *** Nasıl daha iyi olabilir ne değiştirilebilir geri bildirim istemeyi unutma ***
 */
#endregion
