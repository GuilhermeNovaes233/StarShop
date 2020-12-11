using StarShop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarShop.Domain.ValueObject
{
    public class FormPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Billet { get{ return Id == (int)FormPaymentEnum.billet; } }
        public bool CreditCard { get { return Id == (int)FormPaymentEnum.creditCard; } }
        public bool Undefined { get { return Id == (int)FormPaymentEnum.undefined; } }
        public bool Deposit { get { return Id == (int)FormPaymentEnum.deposit; } }
    }
}
