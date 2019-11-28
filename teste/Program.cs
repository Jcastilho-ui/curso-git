using System;
using System.Globalization;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados x, y;
            x = new Dados();
            y = new Dados();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.A = (Console.ReadLine());
            Console.Write("Salário: ", CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            x.B = (Console.ReadLine());
            Console.Write("Salário: ", CultureInfo.InvariantCulture);
            x.D = double.Parse(Console.ReadLine());

           
        }
    }
}
