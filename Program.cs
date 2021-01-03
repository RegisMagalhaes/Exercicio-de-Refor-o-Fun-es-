using System;

namespace Usando_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b;

            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite um valor: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            b = float.Parse(Console.ReadLine());

            Somar(a,b);

            Subtrair(a,b);

            Multiplicar(a,b);
        }

        static void Somar(float a, float b){

            Console.WriteLine(a+b);

            
        }
        static void Subtrair(float a, float b){

            Console.WriteLine(a-b);

            
        }
        static void Multiplicar(float a, float b){

            Console.WriteLine(a*b);

            
        }
    }    

}





        
