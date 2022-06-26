using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAnalyse
{
    class Transaction
    {
        private DateTime date;
        private double betrag;
        private string recipient;

        public Transaction()
        {
        }

        public Transaction(DateTime date, double betrag, string recipient)
        {
            this.Date = date;
            this.Betrag = betrag;
            this.Recipient = recipient;
        }

        public DateTime Date { get => date; set => date = value; }
        public double Betrag { get => betrag; set => betrag = value; }
        public string Recipient { get => recipient; set => recipient = value; }
    }
}
