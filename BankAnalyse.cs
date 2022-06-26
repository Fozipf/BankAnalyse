﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAnalyse
{
    public partial class FormBankAnalyse : Form
    {
        private readonly List<Transaction> allTransactions = new List<Transaction>();

        public FormBankAnalyse()
        {
            InitializeComponent();
        }

        private void FormBankAnalyse_Load(object sender, EventArgs e)
        {
            DisplayTransactions();
        }

       private void Log(string message)
        {
            LblLog.Text += message + "\n";
        }

        private void DisplayTransactions()
        {
            LView.Clear();

            foreach(var transaction in allTransactions)
            {
                ListViewItem eintrag = new ListViewItem(transaction.Date.ToString());
                eintrag.SubItems.Add(transaction.Betrag + "");
                eintrag.SubItems.Add(transaction.Recipient);
                LView.Items.Add(eintrag);
            }

            LView.Columns.Add("Datum", 150);
            LView.Columns.Add("Betrag", 100);
            LView.Columns.Add("Empfänger", 300);
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV-Dateien (*.csv)|*.csv";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openFileDialog.FileNames)
                {
                    ImportCSVFile(file);
                }
            }
           
            DisplayTransactions();
            LblIncome.Text = String.Format("Summe Eingänge: {0:C2}", CalculateIncome(allTransactions));
            LblExpenses.Text = String.Format("Summe Ausgänge: {0:C2}", CalculateExpenses(allTransactions));
            LblAverageExpenses.Text = String.Format("Durchschnitt: {0:C2}", CalculateAvgExpensesPerMonth());
        }

        private double CalculateAvgExpensesPerMonth()
        {
            // Creating a copy of the transaction list, sort by date and then get the first and last item to
            // calculate how much month are in between (first month inclusive)
            Transaction[] transactionCopy = new Transaction[allTransactions.Count];
            allTransactions.CopyTo(transactionCopy);
            Array.Sort(transactionCopy);

            Transaction earliestTransaction = transactionCopy[0];
            Transaction latestTransaction = transactionCopy[transactionCopy.Length - 1];
            int months = (latestTransaction.Date.Year - earliestTransaction.Date.Year) * 12 +
                latestTransaction.Date.Month - earliestTransaction.Date.Month;
            
            return CalculateExpenses(allTransactions)/(months+1);
        }

        private double CalculateIncome(List<Transaction> transactions)
        {
            double sum=0;

            foreach(var transaction in transactions)
            {
                if (transaction.Betrag > 0)
                {
                    sum += transaction.Betrag;
                }
            }

            return sum;
        }

        private double CalculateExpenses(List<Transaction> transactions)
        {
            double sum = 0;

            foreach (var transaction in transactions)
            {
                if (transaction.Betrag < 0)
                {
                    sum += transaction.Betrag;
                }
            }

            return sum;
        }

        private void ImportCSVFile(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                var split = line.Split(';');

                //Skip first line
                if (split[0].Equals("IBAN"))
                {
                    continue;
                }

                if (split.Length == 6)
                {
                    Transaction transaction = new Transaction();
                    transaction.Date = DateTime.Parse(split[2]);
                    transaction.Betrag = Convert.ToDouble(split[5]) - Convert.ToDouble(split[4]);
                    transaction.Recipient = split[1];

                    allTransactions.Add(transaction);
                }
                else
                {
                    //TODO: Exceptionhandling
                    Log("Error: invalid csv line");
                }


            }

            sr.Close();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
