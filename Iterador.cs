using System;

namespace Clase_3
{
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
