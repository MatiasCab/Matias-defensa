using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        private string code { get; set; }
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value < 0)
                {
                    this.amount = value;
                }
                else
                {
                    throw new ArgumentException("El descuento debe de ser negativo");
                }
            }
        }

        public PromoCode(string code, int amount)
        {
            if (amount < 0)
            {
                this.code = code;
                this.SubTotal = amount;
            }
            else
            {
                throw new ArgumentException("El descuento debe de ser negativo");
            }
        }
    }
}