using Patika.Dev_Abstract_Class_Hw.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Concrete
{
    public class CreditCard : TODEBCard
    {
        public string CardType { get; set; }
        public CreditCard(string accountType, string cardType, string cardNumber, DateTime expireDate, string cardHolder) : base(accountType, cardNumber, expireDate, cardHolder)
        {
            CardType = cardType;
        }

        public override void writeLogToConsole()
        {
            Console.WriteLine($"Sn {CardHolder}. {CardNumber} No'lu {CardType} Kredi Kartınız İçin, {AccountType} Olarak Giriş Yaptınız.");
        }
    }
}
