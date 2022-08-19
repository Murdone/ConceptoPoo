using ConceptoPOO;
using Microsoft.VisualBasic;

Console.WriteLine("_____________");
Console.WriteLine("Hola Mundo");
Console.WriteLine("_____________");
Employee employee1 = new SalaryEmployee()
{
    Id= 1010,
    FirstName= "Sandra",
    LastName= "Moraga",
    IsActive=true,
    Salarty=1815453.45M
};
Employee employee2 = new CommissionEmployee()
{
    Id = 1015,
    FirstName = "Patricia",
    LastName = "Gutierres",
    IsActive = true,
    Sales = 250000M,
    CommisionPercentaje = 0.05F
};
Employee employee3 = new HourlyEmployee()
{
    Id = 1017,
    FirstName="Pedro",
    LastName="vasquez",
    IsActive=true,
    HourValue=12356.56M,
    Hours=125.5F

};
Employee employee4 = new BaseComissinEmployee()
{
    Id = 2020,
    FirstName = "Jazmin",
    LastName = "salazar",
    IsActive = true,
    Base= 860357.45M,
    Sales= 58000000M,
    CommisionPercentaje = 0.015F


};
ICollection<Employee> employees = new List<Employee>() 
{
  employee1,employee2,employee3,employee4
};
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                ==============");
Console.WriteLine($"Total{$"{ payroll:C2}",18}");
//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);
Invoice invoice = new Invoice() 
{
    Description="iphone 13",
    Id=1,
    Price=53000000M,
    Quantity= 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Premiun",
    Id = 1,
    Price = 55000M,
    Quantity = 19.5F
};
Console.WriteLine(invoice);
Console.WriteLine(invoice2);
Console.ReadKey();