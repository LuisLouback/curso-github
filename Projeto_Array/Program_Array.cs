using System;

namespace Projeto_Array
{
    class Program
    {
        static void MaiorNumero(){

            int numeroA , numeroB;
			Console.WriteLine("Digite o valor de A:");
			numeroA = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor de B:");
			numeroB = int.Parse(Console.ReadLine());

			if (numeroA > numeroB)
				Console.WriteLine("O maior número é " + numeroA);
			else if (numeroB > numeroA)
				Console.WriteLine("O maior número é " + numeroB);
			else if (numeroB == numeroA)
				Console.WriteLine("Ambos números são iguais !");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro vamos fazer o teste de maior número");
            //MaiorNumero();  

            String [] array ;

            Console.WriteLine("Digite os numero que vc quer no array separados por ( , )");
            
            if ()
            {
                
            }
            
            array = Console.ReadLine().Split(",");

            Console.WriteLine("Os numeros que você escolheu foram :");

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {                
                Console.Write(array[i]+",");
            }
            Console.Write("}");
            Console.ReadLine();
            


        }
    }
}
