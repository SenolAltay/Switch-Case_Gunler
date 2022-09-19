using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_Gunler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Günler Programına Hoşgeldiniz..");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            int gun;
            Console.WriteLine("Seçtiğiniz Gün: ");
            Console.WriteLine();
            gun = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            switch (gun)
            {
                case 1:Console.WriteLine("Pazartesi");break;
                case 2:Console.WriteLine("Salı");break;
                case 3:Console.WriteLine("Çarşamba");break;
                case 4:Console.WriteLine("Perşembe");break;
                case 5:Console.WriteLine("Cuma");break;
                case 6:Console.WriteLine("Cumartesi");break;
                case 7:Console.WriteLine("Pazar");break;
                default:Console.WriteLine(" Böyle Bir Gün Bulunamadı");break;
                    
            }
            Console.Read();
        }
    }
}
