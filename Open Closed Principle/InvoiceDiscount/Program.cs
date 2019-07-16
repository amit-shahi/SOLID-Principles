using System;
using static System.Console;

namespace Open_Closed_Principle
{
        public abstract class Invoice
        {
            public abstract double GetInvoiceDiscount(double amount);
        }
    
        public class FinalInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return amount - (amount * 0.60); // 60% invoice discount
            }
        }
        public class ProposedInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return amount - (amount * 0.40); // 40% invoice discount
            }
        }
        public class RecurringInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return amount - (amount * 0.30); // 30% invoice discount
            }
        }

        public class MonthlyInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return amount - (amount * 0.20); // 20% invoice discount
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Invoice _finalInvoice = new FinalInvoice();
                Invoice _proposedInvoice = new ProposedInvoice();
                Invoice _recurringInvoice = new RecurringInvoice();
                Invoice _monthlyInvoice = new MonthlyInvoice();

                double _finalInvoiceAmount = _finalInvoice.GetInvoiceDiscount(10000);
                double _proposedInvoiceAmount = _proposedInvoice.GetInvoiceDiscount(10000);
                double _recurringInvoiceAmount = _recurringInvoice.GetInvoiceDiscount(10000);

                double _monthlyInvoiceAmount = _monthlyInvoice.GetInvoiceDiscount(1000);

               WriteLine();
               WriteLine($"Total amount is $ 1000");
               WriteLine();
               
               WriteLine($"Final Invoice : $ {_finalInvoiceAmount} with 60% discount.");
               WriteLine($"Proposed Invoice Amount : $ {_proposedInvoiceAmount}  with 40% discount.");
               WriteLine($"Recurring Invoice Amount : $ {_recurringInvoiceAmount}  with 30% discount.");
               WriteLine($"Monthly Invoice Amount : $ {_monthlyInvoiceAmount}  with 20% discount.");
                
                
            }
        }
}
