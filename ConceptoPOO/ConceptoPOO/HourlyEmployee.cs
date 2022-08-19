namespace ConceptoPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHouyrs...............: {$"{Hours:N2} ",15}" +
                $"\n\tHours Values.........:{$"{HourValue:C2} ",15}" +
                $"\n\tValue to pay.........:{$"{GetValueToPay():c2}",15}"; //\n\t n saltar y t tabular
        }
    }
}
