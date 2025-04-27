using System;

namespace Clase_3
{
	public interface Observado
	{
		void agregraObservador(Observador o);
		void quitarObsevador(Observador o);
		void notificar();
	}
}
