using Patika.Dev_Abstract_Class_Hw.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Concrete
{
    //Ayrı Bir Şekilde Debit card kısmı için Card type tanıımlanmıştır.
    public class DebitCard : TODEBCard
    {
        public string CardType { get; set; }
        public DebitCard(string accountType, string cardType, string cardNumber, DateTime expireDate, string cardHolder) : base(accountType, cardNumber, expireDate, cardHolder)
        {
            cardType = CardType;
        }

        public override void writeLogToConsole()
        {
            Console.WriteLine($"Sn {CardHolder}. {CardNumber} No'lu {CardType} ve {ExpireDate} Bitiş Tarihli Hesap Kartınız İçin, {AccountType} Olarak Giriş Yaptınız.");
        }

    }
}
