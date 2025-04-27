using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_3
{
	public class GenerarDatosAleatorios
	{
		public int numeroAleatorio(int max){
			Random rn = new Random();
			
			int num = rn.Next(0, max);
			return num;
		}
		
		public string stringAleatorio(int cantidad){
			Random rn = new Random();
			const string letras = "abcdefghijklmnopqrstuvwyz";
			StringBuilder palabra = new StringBuilder();
			
			for (int i = 0; i < cantidad; i++) {
				palabra.Append(letras[rn.Next(0, letras.Length)]);
			}
			
			return palabra.ToString();
		}
	}
}
