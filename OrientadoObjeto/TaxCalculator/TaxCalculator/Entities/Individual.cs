using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpanditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpanditures) : base(name, anualIncome)
        {
            HealthExpanditures = healthExpanditures;
        }
        public override double Tax()
        {
            double percentualTax;

            if (AnualIncome < 20000.00) percentualTax = 0.15;
            else percentualTax = 0.25;

            return (AnualIncome * percentualTax) - (HealthExpanditures * 0.5);
        }
    }
}
