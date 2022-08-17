Console.WriteLine("_____________");
Console.WriteLine("Hola Mundo");
Console.WriteLine("_____________");

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1957, 9, 23));
	Console.WriteLine(new Date(1985, 11, 5));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}
Console.ReadKey();