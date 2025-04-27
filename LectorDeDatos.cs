using System;
using System.Collections.Generic;

namespace Clase_3
{
	public class LectorDeDatos
	{
		public int numeroPorTeclado(){
			Console.WriteLine("Escriba un numero: ");
			int n = int.Parse(Console.ReadLine());
			return n;
		}
		
		public string stringPorTeclado(){
			Console.WriteLine("Escribe un string: ");
			string s = Console.ReadLine();
			return s;
		}
	}
}
