using System;

namespace Clase_3
{
	public class FabricaDeNumeros: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Numero(gen.numeroAleatorio(1000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(lector.numeroPorTeclado());
		}
	}
}
