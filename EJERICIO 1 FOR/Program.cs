using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        int menor, mayor;

        Console.Write("Ingrese el primer numero: ") ;
        num1 =  Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nIngrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            mayor = num1;
            menor = num2;
        }

        Console.Write($"\nLos nùmeros comprendidos entre {menor} y el {mayor} son: ");

        for (int i = menor; i <= mayor; i++ )

        
        {

            Console.Write($"{i}  ");
            //Console.WriteLine(i);
        }
    }
   
}
