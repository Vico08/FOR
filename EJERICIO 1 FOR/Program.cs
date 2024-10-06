internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        int menor, mayor;

        Console.WriteLine("Ingrese el primer numero");
        num1 =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo numero");
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

        for ( int i = 0; i < menor ; i++ ) 
        {   
    }
}