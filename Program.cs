// See https://aka.ms/new-console-template for more information
using System;

namespace ForLoop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.      
            Console.WriteLine("lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                 if (i%2 ==1)
             Console.WriteLine(i);
            }
         //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamını ekrana yazdırın
         int teToplam =0;
         int çiftToplam= 0;
         for(int i =1; i<=1000; i++)
         {
          if(i%2 ==1)
          teToplam += i;
          else
          çiftToplam += i;
         } 
        Console.WriteLine("tek Toplam:" +teToplam);
        Console.WriteLine("çift Toplam:" + çiftToplam);
        //break continue
          for (int i = 1; i < 10; i++)
          {
              if(i==4)
              break;
              Console.WriteLine(i);
          } 
        for (int i = 1; i < 10; i++)
        {
            if(i==6)
            continue;
            Console.WriteLine(i);
        }
        }
         
    }
}

