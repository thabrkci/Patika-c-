namespace Patika_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlem Atama
            Console.WriteLine("***Atama Ve İşlem Atama***");

            // Değişkenlerin tanımlanması
            int x = 3;
            int y = 3;

            // İşlem atama örnekleri
            y = y + 2; 
            Console.WriteLine(y); // 5
            y /= 1; 
            Console.WriteLine(y); // 5
            y += 2; 
            Console.WriteLine(y); // 7
            x *= 2; 
            Console.WriteLine(x); // 6

            // Mantıksal Operatörler
            Console.WriteLine("***Mantiksal Operatörler***");

            // Boolean değişkenlerin tanımlanması
            bool isSuccess = true;
            bool isCompleted = false;

            // Mantıksal operatör örnekleri
            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Fine!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Great!");

            // İlişkisel Operatörler
            Console.WriteLine("***İlişkisel Operatörler***");

            // İki sayının karşılaştırılması
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc); // true

            sonuc = a > b;
            Console.WriteLine(sonuc); // false

            sonuc = a >= b;
            Console.WriteLine(sonuc); // false

            sonuc = a <= b;
            Console.WriteLine(sonuc); // true

            sonuc = a == b;
            Console.WriteLine(sonuc); // false

            sonuc = a != b;
            Console.WriteLine(sonuc); // true

            // Aritmetik Operatörler
            Console.WriteLine("***Aritmetik Operatörler***");

            // İki sayı üzerinde aritmetik işlemler
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1); // 2

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1); // 50

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1); // 15

            sonuc1 = sayi1++; // Önce değeri kullan, sonra artır
            Console.WriteLine(sayi1); // 11
        }
    }
}
