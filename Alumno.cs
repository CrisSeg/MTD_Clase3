using System;
using System.Collections.Generic;

namespace Clase_3
{
	public class Alumno : Persona, Comparable, Observador
	{
		private int legajo;
		private int promedio;
		private EstrategiaDeComparacion estrategia;
		
		public Alumno(string n, int d, int l, int p): base(n, d){
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
			estrategia = new ComparacionPorLegajo();
		}
		
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDni(){
			return this.dni;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia = nvaEstrategia;
		}
		
		public override bool sosIgual(Comparable c)
        {
			return this.estrategia.sosIgual(this, (Alumno)c);
        }

        public override bool sosMenor(Comparable c)
        {
            return this.estrategia.sosMenor(this, (Alumno)c);
        }

        public override bool sosMayor(Comparable c)
        {
            return this.estrategia.sosMayor(this, (Alumno)c);
        }
        
		public override string toString()
		{
			return base.toString() + string.Format(" Legajo: {0}, Promedio: {1}", legajo, promedio);
		}
		
		//Practica 3 Ejercicio 11
		public void prestandoAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		
		public void distraerse(){
			string[] l = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			Random rn = new Random();
			
			Console.WriteLine(l[rn.Next(0,3)]);
		}
		
		//implemento la interface observador
		public void actualizar(Observado o){
			if (((Profesor)o).isHablando()) {
				this.prestandoAtencion();
			}
			else
				this.distraerse();
		}
	}
}
