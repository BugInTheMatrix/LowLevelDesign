using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.OOPS
{
    public class Card:PaymentMethod
    {
        private string cardNumber;
        private string cardHolderName;
        public Card(string cardNumber, string cardHolderName)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public string CardHolderName
        {
            get { return cardHolderName; }
            set { cardHolderName = value; }
        }

        public virtual void Pay()
        {
            Console.WriteLine($"Payment made using Card: {cardHolderName}, Card Number: {cardNumber}");
        }
    }
}
