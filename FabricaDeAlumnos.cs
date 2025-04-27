using System;

namespace Clase_3
{
	public class FabricaDeAlumnos: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(gen.stringAleatorio(5), gen.numeroAleatorio(10000000), gen.numeroAleatorio(1000), gen.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
