using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        /// <summary>
        /// ID клиента
        /// </summary>
        public int id;
        /// <summary>
        /// Номер счета
        /// </summary>
        public int num;
        /// <summary>
        /// Годовой процент по вкладу
        /// </summary>
        public int procent;
        /// <summary>
        /// Размер вклада
        /// </summary>
        public int vklad;
        /// <summary>
        /// Дата открытия
        /// </summary>
        public DateTime opening;
        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTime closing;
        public Account (int id, int num, int procent, int vklad, DateTime opening, DateTime closing)
        {
            this.id = id;
            this.num = num;
            this.procent = procent;
            this.vklad = vklad;
            this.opening = opening;
            this.closing = closing;
        }
    }
    class BankClass
    {
        /// <summary>
        /// ID клиента
        /// </summary>
        public int id;
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string fam;
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public int num_pasp;
        /// <summary>
        /// Количество счетов
        /// </summary>
        public int kol_schet;
        public BankClass(string fam, int num_pasp, int kol_schet, int id)
        {
            this.id = id;
            this.fam = fam;
            this.num_pasp = num_pasp;
            this.kol_schet = kol_schet;
        }
        public List<BankClass> clients = new List <BankClass>();
        public List <Account> accounts = new List <Account>();

    }
}
