using System;

namespace Aulas_Udemy
{
	class Program
	{
		static void Main(string[] args)
		{
			int A ,B ;
			
			Console.WriteLine("Digite o valor de A:");
			A = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor de B:");
			B = int.Parse(Console.ReadLine());

			if (A > B)
				Console.WriteLine("O maior número é " + A);
			else if (B > A)
				Console.WriteLine("O maior número é " + B);
			else if (B == A)
				Console.WriteLine("Ambos números são iguais !");
		}
	}
}
