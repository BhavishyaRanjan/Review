using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string owner
        {
            get;
            set;
        } 
        public Guid accountNumber
        {
            get;
            set;
        }   
        public decimal balance
        {
            get;
            set;
        }

    }
}
