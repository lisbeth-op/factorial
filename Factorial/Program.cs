using System;
using System.Linq;

class Factorial
{
   

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = factorial(num);
        Console.WriteLine($"\n\n\nEl factorial de [{num}]es {resultado}.\n\n\n ");
       
    }




    static int factorial(int numero)
    {
        return Enumerable.Range(1, numero).Aggregate(1, (acc, x) => acc * x);
    }


}

