using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptoPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje: {$"{CommisionPercentaje:P2} ",15}" +
                $"\n\tCommission percentaje:{$"{Sales:C2} ",15}" +
                $"\n\tValue to pay.........:{$"{GetValueToPay():c2}",15}"; //\n\t n saltar y t tabular
        }
    }
}
