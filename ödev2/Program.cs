//13253039
//Hilal Memiş


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13253039HW._1
{
    class Program
    {
        static void Main(string[] args)
        { 
            MathOperation math = new MathOperation();
            string number1 ,number2, islem, yazi;
            do
            {
                double cikis;
                bool sonuc;
                do
                {
                Console.Write("Birinci Sayıyı Giriniz :");
                number1 = Console.ReadLine();
                sonuc = Double.TryParse(number1, out cikis);
                
                if(sonuc)
                    Console.WriteLine("  ");
                else
                    Console.WriteLine("Lütfen Sayı Değeri Giriniz!!!");

                }while(sonuc!=true);

                do{
                Console.Write("İşlemi Giriniz(+ - * /)  :");
                islem = Console.ReadLine();
                Console.WriteLine();
                }while(islem != "+" && islem != "-" && islem != "*" && islem != "/");
                
                double cikis2;
                bool sonuc2;
                do
                { 
                    Console.Write("İkinci sayıyı giriniz  :");
                    number2 = Console.ReadLine();
                    sonuc2 = Double.TryParse(number2, out cikis2);

                    if (sonuc2)
                        Console.WriteLine("  ");
                    else
                        Console.WriteLine("Lütfen Sayı Değeri Giriniz!!!");

                } while (sonuc2 != true);
                
                
                    if (islem == "+")
                    {
                        Console.WriteLine(math.Toplama(double.Parse(number1), double.Parse(number2)));

                    }
                    else if (islem == "-")
                    {
                        Console.WriteLine(math.Cikarma(double.Parse(number1), double.Parse(number2)));
                    }
                    else if (islem == "*")
                    {
                        Console.WriteLine(math.Carpma(double.Parse(number1), double.Parse(number2)));
                    }
                    else
                    {
                        Console.WriteLine(math.Bolme(double.Parse(number1), double.Parse(number2)));
                    }
                
                
                
                Console.Write("Devam Etmek İstiyormusunuz(e/h)");
                yazi = Console.ReadLine();
                if (yazi == "h")
                    break;
                else if (yazi == "e")
                    Console.WriteLine("  SIRADAKİ İŞLEM  ");
                else
                {
                    do{
                    Console.WriteLine("Hatalı Giriş Tekrar Deneyiniz...");
                    Console.Write("Devam Etmek İstiyormusunuz(e/h)");
                    yazi = Console.ReadLine();
                    }while(yazi!="e" && yazi!="h");
                   
                }
                
            } while (yazi != "h");
            
    }
    }
}