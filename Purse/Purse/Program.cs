﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money1.Money(1000);
            Console.WriteLine(money.GetMoney());
            var credit = new CreditCard1.CreditCard(500);
            Console.WriteLine(credit.GetSumCreditCard());
            var bcard = new BusinessCard.BusinessCard("Vova");
            Console.WriteLine(bcard.FindOutWhose());
            Console.WriteLine("This is working");
            Console.WriteLine("This is not working");
        }
    }
}
