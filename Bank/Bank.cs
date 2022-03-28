using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    class Bank
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] kol_s = new int[100];
            Console.WriteLine("Банк");
            Console.WriteLine();
            Console.WriteLine("Информация о клиентах:");
            byte test = 1;
            byte kol_clients = 0;
            byte kol_clients1 = 0;
            int i = 0;
            int id;
            List<BankClass> clients = new List<BankClass>();
            List<Account> accounts = new List<Account>();
            while (test != 0)
            {
                Console.WriteLine("Введите фамилию клиента");
                string fam = Console.ReadLine();
                Console.WriteLine("Введите номер паспорта клиента");
                int num_pusp = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество счетов клиента");
                int kol_schet = int.Parse(Console.ReadLine());
                id = random.Next(1, 100);
                kol_s[id] = kol_schet;
                Console.WriteLine("Клиенту присвоен ID - " + id);
                clients.Add(new BankClass(fam, num_pusp, kol_schet, id));
                kol_clients += 1;

                Console.WriteLine("Есть еще клиенты? 1-да, 0-нет");
                test = byte.Parse(Console.ReadLine());
            }
            kol_clients1 = kol_clients;
            Console.WriteLine();
            Console.WriteLine("Список клиентов:");
            foreach (BankClass z in clients)
            {
                Console.WriteLine($"Фамилия: {z.fam}, номер паспорта: {z.num_pasp}, количество счетов: {z.kol_schet}. ID: {z.id}");
            }
            Console.WriteLine();
            while (kol_clients != 0)
            {
                Console.WriteLine("Информация о счетах клиента с ID-" + clients[i].id);
                kol_clients -= 1;
                while (clients[i].kol_schet != i)
                {
                    Console.WriteLine("Введите номер счета");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите годовой процент по вкладу");
                    int procent = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите размер вклада");
                    int vklad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите дату открытия");
                    DateTime opening = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Введите дату закрытия (дд.мм.гггг)");
                    DateTime closing = DateTime.Parse(Console.ReadLine());
                    accounts.Add(new Account(clients[i].id, num, procent, vklad, opening, closing));
                    i += 1;
                }
            }
            i = 0;
            Console.WriteLine();
            while (kol_clients1 != 0)
            {
                Console.WriteLine("Информация о счетах клиента с ID-" + clients[i].id);
                foreach (Account z in accounts)
                {
                    Console.WriteLine($"Номер счета: {z.num}, годовой процент: {z.procent}%, размер вклада: {z.vklad} руб., дата открытия {z.opening.Date}, дата закрытия {z.closing.Date}");
                }
                i += 1;
                kol_clients1 -= 1;
            }
            Console.WriteLine("Bye");
        }
    }
}
