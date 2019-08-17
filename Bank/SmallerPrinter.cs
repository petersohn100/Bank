﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SmallerPrinter:IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: ");
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);  
            Console.WriteLine("Imię i nazwisko właściciela {0}", account.GetFullName());
        }
    }
}
