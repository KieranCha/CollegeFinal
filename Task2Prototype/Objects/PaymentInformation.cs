using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prototype.Objects
{
    internal class PaymentInformation
    {
        string CSV;
        string CardNumber;
        string CardHolderName;
        string CardExpiryDate;
    }

    class CreatePaymentInformation : Create<CreatePaymentInformation>
    {
        public string Csv { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardExpiryDate { get; set; }
        public int UserId { get; set; }

        public CreatePaymentInformation(string _Csv, string _CardNumber, string _CardHolderName, string _CardExpiryDate, int _UserId)
        {
            type = this.GetType();
            entity = Entity.PaymentInfo;
            Csv = _Csv;
            CardNumber = _CardNumber;
            CardHolderName = _CardHolderName;
            CardExpiryDate = _CardExpiryDate;
            UserId = _UserId;
            EntityInfo = this;
        }
    }
}
