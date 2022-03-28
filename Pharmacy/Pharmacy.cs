using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс Аптека");
            
            string name1 = "ProstoApteka";
            List<PharmacyClass> lecar_name1 = new List<PharmacyClass>();
            lecar_name1.Add(new PharmacyClass("Aspirin", 200));
            lecar_name1.Add(new PharmacyClass("Pentalgin", 50));
            PharmacyClass.Info(name1, lecar_name1);
            
            Console.WriteLine();
            
            Console.WriteLine("Название Вашей аптеки:");
            string name2 = Console.ReadLine();
            int test = 1;
            List<PharmacyClass> lecar_name2= new List<PharmacyClass>();

            while (test != 0)
            {
                Console.WriteLine("Введите название лекарства:");
                string lecarstvo = Console.ReadLine();
                Console.WriteLine("Введите его цену:");
                int price = int.Parse(Console.ReadLine());
                lecar_name2.Add(new PharmacyClass(lecarstvo, price));              
                Console.WriteLine("Есть еще лекарства? 1-да, 0-нет");
                test = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            PharmacyClass.Info(name2, lecar_name2);
            Console.WriteLine();
            PharmacyClass.MaxPrice(name1, lecar_name1);
            PharmacyClass.MaxPrice(name2, lecar_name2);
            Console.WriteLine();
            PharmacyClass.AllPrice(name1, lecar_name1);
            PharmacyClass.AllPrice(name2, lecar_name2);
        }
    }
}
