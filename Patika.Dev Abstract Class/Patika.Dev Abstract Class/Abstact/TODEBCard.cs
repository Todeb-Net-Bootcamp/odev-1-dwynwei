using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Abstact
{
    public abstract class TODEBCard
    {
        public string AccountType { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CardHolder { get; set; }

        public TODEBCard(string accountType, string cardNumber, DateTime expireDate, string cardHolder)
        {
            AccountType = accountType;
            CardNumber = cardNumber;
            ExpireDate = expireDate;
            CardHolder = cardHolder;
        }

        public virtual void writeLogToConsole()
        {
            Console.WriteLine($"Merhabalar {CardHolder}. Kartınızın. {CardNumber} numaralı Kartınız ile işlem yapmaya hazırsınız!");
        }
    }
}
