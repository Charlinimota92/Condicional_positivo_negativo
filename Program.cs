// See https://aka.ms/new-console-template for more information
Console.WriteLine("POSITIVO O NEGATIVO");

Console.WriteLine();

{
        Console.WriteLine("Ingrese un número:");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine("El número ingresado es positivo.");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El número ingresado es negativo.");
    }
    else
    {
        Console.WriteLine("El número ingresado es cero.");
    }
}
