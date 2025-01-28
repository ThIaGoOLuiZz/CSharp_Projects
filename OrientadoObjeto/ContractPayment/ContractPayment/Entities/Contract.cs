using System;
using System.Collections.Generic;
using System.Text;

namespace ContractPayment.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        List<Installment> list = new List<Installment>();
        

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            list.Add(installment);

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Installments: ");
            foreach(Installment installment in list)
            {
                sb.AppendLine(installment.ToString());
            }

            return sb.ToString();
        }
    }
}
