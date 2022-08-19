namespace ConceptoPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salarty { get; set; }
        public override decimal GetValueToPay()
        {
            return Salarty;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\tValue to pay:{$"{GetValueToPay():c2}",15}"; //\n\t n saltar y t tabular
        }
    }
}
