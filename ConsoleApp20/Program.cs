Console.WriteLine("Ingrese la base:");
int base1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el exponenete:");
int exponente=Convert.ToInt32(Console.ReadLine());

int resultado = 1;

for (int i = 1; i <= exponente; i++)
{
    resultado = resultado * base1;
}

Console.WriteLine("******************************");
Console.WriteLine("******************************");
Console.WriteLine("El resultado es: " + resultado);
Console.WriteLine("******************************");
Console.WriteLine("******************************");