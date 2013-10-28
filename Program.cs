
using System;

namespace prac3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("PROGRAMACION: PRACTICA NUMERO 3");
			
			Proceso Proceso = new Proceso();
			
			Proceso.capturar();
			Proceso.editar();
			Proceso.eliminar();
			Proceso.imprimir();
		}
	}
}