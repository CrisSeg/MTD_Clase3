﻿using System;

namespace Clase_3
{
	public interface EstrategiaDeComparacionProf
	{
		bool sosIgual(Profesor p1, Profesor p2);
		
		bool sosMenor(Profesor p1, Profesor p2);
 		
		bool sosMayor(Profesor p1, Profesor p2);
	}
}
