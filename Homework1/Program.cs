
void firstQuestion()
{
    Console.Write("Sipariş Numarasını Giriniz  ");
    int orderNumber = Convert.ToInt32(Console.ReadLine());
    switch (orderNumber)
    {
        case 1:
            Console.WriteLine("Çikolata");
            break;
        case 2:
            Console.WriteLine("Gofret");
            break;
        case 3:
            Console.WriteLine("Çay");
            break;
        case 4:
            Console.WriteLine("Kahve");
            break;
        case 5:
            Console.WriteLine("Nohut");
            break;
        default:
            Console.WriteLine("Yanlış Sipariş Numarası Girdiniz.");
            break;
    }
}

void secondQuestion()
{

    Console.Write("Ürün Sayısını Giriniz ");
    int totalProduct = Convert.ToInt32(Console.ReadLine());
    int total = 0;
    for (int i = 1; i <= totalProduct; i++)
    {
        Console.Write(+i + " .Ürün Fiyatını Giriniz  ");
        int fiyat = Convert.ToInt32(Console.ReadLine());
        total += fiyat;
    }

    Console.Write("Ürünlerinizin Toplam Fiyatı : " + total);
}

void thirdQuestion()
{
    //While Döngüsü, belirlenen komut bloğunu koşul sağlandığı
    //sürece çalıştıran temel döngü yapılarından bir tanesidir.
    //Döngü gövdesi koşul deyimi true olduğu sürece çalıştırılır,
    //koşul false olduğunda ise döngüden çıkılır.

    //1’den 10’a kadar olan tek sayıları ekrana yazdıran program.

    int say = 1;
    while (say <= 10)
    {
        Console.WriteLine(say);
        say += 2; // yukarıda kodumuzdan farkı bu kısım
    }

    //Do -while döngüsü koşulun doğruluğunu kontrol etmeden
    //en az bir kere çalıştırılması istenilen durumlarda kullanılmaktadır.
    //Do while döngüsü while döngüsüne benzemektedir.
    //Fakat aralarında ufak bir fark vardır.
    //Bu fark while döngüsü koşulun doğruluğunu başta kontrol eder,
    //do -while döngüsünde koşul yanlış olsa bile bir kez çalışır.

    // 1 ile 100 arasında sayı üretelim, üretilen sayı 50 olana kadar sayıları ekrana yazdırır
    Random r = new Random();
    int sayi;
    do
    {
        sayi = r.Next(1, 11);
        Console.Write("{0} ", sayi); // sayi+" " 
    }
    while (sayi != 5);
    //sayi 50 den farklı olduğu sürecek döngü devam eder. 
    Console.ReadKey();

}

void fourthQuestion()
{
    Random random = new Random();
    int prediction, number = random.Next(10);
    while (true)
    {
        Console.Write("Sayı Giriniz ");
        prediction = Convert.ToInt32(Console.ReadLine());
        if (prediction > number)
        {
            Console.WriteLine("Daha küçük bir sayı giriniz ");
        }
        else if (prediction < number)
        {
            Console.WriteLine("Daha büyük bir sayı giriniz ");
        }
        else
        {
            Console.WriteLine("Doğru Sayıyı Buldunuz");
        }
    }
}
void fifthQuestion()
{
    Console.WriteLine("Sayı giriniz \n");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam = toplam + i;
        }
    }
    if (toplam == sayi)
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");
    }
    else
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");
    }
}

void sixthQuestion()
{
    string str1 = "Test String";
    string str2 = "Hello World";

    Console.WriteLine("The length of the txt string is: " + str1.Length);
    Console.WriteLine(str1.ToUpper());   // Outputs "TEST STRING"
    Console.WriteLine(str1.ToLower());   // Outputs "test string"

    //Join two strings
    string joinedString = string.Concat(str1, str2);
    Console.WriteLine("Joined string: " + joinedString);

    //Split Method
    string str = "Test, Split Method";
    char[] spearator = { ',', ' ' };

    // using the method 
    String[] strlist = str.Split(spearator);

    foreach (String s in strlist)
    {
        Console.WriteLine(s);
    }
}

void seventhQuestion()
{
    Console.Write("Öğrenci Sayısını Giriniz ");
    int totalStudent = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= totalStudent; i++)
    {
        Console.Write(" Öğrenci Adını Giriniz ");
        string firstName = Console.ReadLine();

        Console.Write(" Öğrenci Soyadını Giriniz ");
        string lastName = Console.ReadLine();

        Console.Write(" 1. Sınav Notunu Giriniz ");
        int firstExam = Convert.ToInt32(Console.ReadLine());

        Console.Write(" 2. Sınav Notunu Giriniz ");
        int secondExam = Convert.ToInt32(Console.ReadLine());

        Console.Write(" 3. Sınav Notunu Giriniz ");
        int thirdExam = Convert.ToInt32(Console.ReadLine());

        double average = (firstExam + secondExam + thirdExam) / 3;
        Console.WriteLine("Öğrenci : " + firstName + " " + lastName);
        Console.WriteLine("Not Ortalaması : " + average);
        Console.WriteLine("********************************************");

    }
}
