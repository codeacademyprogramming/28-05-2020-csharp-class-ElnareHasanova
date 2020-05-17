using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("678904", "Alex", "Foxtrot") { Article = "USB-hab", Quantity = 6, Cost =12 }; 
            inv.CostCalculation(false);
        }
    }
    class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public Invoice( string account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }
        public void CostCalculation(bool needEdv)
        {
            if (needEdv)
            {
                Console.WriteLine($"Article : {Article}, TotalAmount: { Cost = Cost * Quantity + (Cost * 0.18)} AZN");


            }
            else
            {
                Console.WriteLine($"Article : {Article}, TotalAmount: { Cost = Cost * Quantity } AZN");
              



            }

        }

    }

}
