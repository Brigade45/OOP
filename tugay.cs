using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static string komutal;
        int[,] boyananlaritut = new int[20,20]; 
        static int aracyon = 1001;  // mod 4 e göre sağ 1 aşağı 2 sol 3 yukarı 0
        static int firca = 2; // yukarı 2 aşağı 1
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.WriteLine("1 - Fırça aşağı");
            Console.WriteLine("2 - Fırça yukarı");
            Console.WriteLine("3 - Sağa dön");
            Console.WriteLine("4 - Sola dön");
            Console.WriteLine("5_x - x kadar ilerle");
            Console.WriteLine("6 - Diziyi goruntule");
            Console.WriteLine("0 - Programı sonlandır");
            Console.WriteLine("Komutlar arasında virgul kullaniniz.");
            Console.Write("Lutfen komutunuzu giriniz:");
            komutal = Console.ReadLine();
            for(int i=0;i<komutal.Length;i++)
            {
                if(komutal[i] == 44)
                {
                    continue;
                }
                else if(komutal[i] == 49)
                {
                    fircaasagi();
                }
                else if(komutal[i] == 50)
                {
                    fircayukari();
                }
                else if(komutal[i] == 51)
                {
                    sagadon();
                }
                else if (komutal[i] == 52)
                {
                    soladon();
                }
                else if (komutal[i] == 53 && komutal[i + 1] == 95)
                {
                    i = i + 2;
                    if(komutal[i] == 44)
                    {
                        continue;
                    }
                    else
                    {
                        i++;
                    }
                }

            }
        }
        static void fircaasagi()
        {
            firca = 1;          
        }
        static void fircayukari()
        {
            firca = 2; 
        }
        static void sagadon()
        {
            aracyon = aracyon + 1;
        }
        static void soladon()
        {
            aracyon = aracyon - 1;
        }
    }
}
