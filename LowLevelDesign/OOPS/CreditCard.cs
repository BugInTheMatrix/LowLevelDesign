using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.OOPS
{
    public class CreditCard : Card
    {
        private string cardNumber;
        private string cardHolderName;
        public CreditCard(string cardNumber, string cardHolderName) : base(cardNumber, cardHolderName)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
        }
        public override void Pay()
        {
            Console.WriteLine($"Payment made using Credit Card: {cardHolderName}, Card Number: {cardNumber}");
        }
    }
}
