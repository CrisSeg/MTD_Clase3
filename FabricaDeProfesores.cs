using System;

namespace Clase_3
{
	public class FabricaDeProfesores: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Profesor(gen.stringAleatorio(5), gen.numeroAleatorio(10000000), gen.numeroAleatorio(25));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
