﻿namespace Patika_c_;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("***Atama Ve İşlem Atama***");
        //Atama ve işlem atama
        int x = 3;
        int y = 3;

        y = y+2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);
        
        Console.WriteLine("***Mantiksal Operatörler***");
        //Mantıksal Operatörler II & !
        bool isSuccess = true;
        bool isCompleted =false;

        if(isSuccess && isCompleted)
         Console.WriteLine("Perfect!");
        if(isSuccess || isCompleted )
         Console.WriteLine("Fine!");
         if(isSuccess && !isCompleted)
         Console.WriteLine("Great!");


         Console.WriteLine("***İlişkisel Operatörler***");
        //İlişkisel operatörler
        //<, >, <=, >=, ==; !=
        int a = 3;
        int b = 4;
        bool sonuc = a<b;

        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;

        Console.WriteLine("***Aritmetik Operatörler***");
        //Aritmetik operatörler
        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1++;
        Console.WriteLine(sayi1);
        //Deneme



         



    }
}
