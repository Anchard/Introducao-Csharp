using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{

		static string LerTipo()
		{
			Console.Write("Digite o tipo das coisas que você deseja adicionar em um array: ");
			string tipo = Console.ReadLine();
			Console.WriteLine();

			return tipo;
		}

		static int LeituraQuantidade() 
		{
			Console.Write("Digite a quantidade de nomes que você deseja digitar: ");
			int quantidade = int.Parse(Console.ReadLine());
			Console.WriteLine();
			return quantidade;
		}

		static void LeituraNomes(string tipo, ref string[] nomes, int quantidade)
		{
			Console.WriteLine("Digite os/as " + tipo + ":");
			for (int i = 0; i < quantidade; i++) nomes[i] = Console.ReadLine();
			Console.WriteLine();
		}

		static void Escrita(string tipo, string[] nomes, int quantidade)
		{
			Console.WriteLine("Os/As " + tipo + " digitados/as foram:");
			for (int i = 0; i < quantidade; i++)
			{
				if (i < quantidade-1) Console.WriteLine(i + 1 + ") " + nomes[i] + ";");
				else Console.WriteLine(i + 1 + ") " + nomes[i] + ".");
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			string tipo = LerTipo();
			int quantidade = LeituraQuantidade();
			string[] nomes = new string[quantidade];

			LeituraNomes(tipo, ref nomes, quantidade);

			Escrita(tipo, nomes, quantidade);

			Console.Write("Aperte ENTER para continuar... ");
			Console.ReadLine();
		}
	}
}
