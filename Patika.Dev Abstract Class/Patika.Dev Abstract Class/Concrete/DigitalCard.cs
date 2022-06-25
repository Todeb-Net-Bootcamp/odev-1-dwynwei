using Patika.Dev_Abstract_Class_Hw.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Concrete
{
    public class DigitalCard : TODEBCard
    {

        public Guid DigitalWalletId { get
            {
                return new Guid(Guid.NewGuid().ToString());
            } 
        }
        public string CardType { get; set; }

        public DigitalCard(string accountType, string cardType, string cardNumber, DateTime expireDate, string cardHolder, Guid digitalWalletId) : base(accountType, cardNumber, expireDate, cardHolder)
        {
            digitalWalletId = DigitalWalletId;
        }

        public override void writeLogToConsole()
        {
            Console.WriteLine($"Sn {CardHolder}. {CardNumber} No'lu {CardType} Kredi Kartınız İçin, {AccountType} Olarak Giriş Yaptınız. Benzersiz ID'niz : {DigitalWalletId}");
        }

    }
}
