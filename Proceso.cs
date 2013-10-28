using System;
using System.Collections;

namespace prac3
{

	public class Proceso
	{
		public Hashtable tabla;
		
		public Proceso()
		{
			this.tabla = new Hashtable();
		}
		public void capturar(){
			for(int i=0;  i<4;  i++)
			{
				Persona persona = new Persona(); //
			    Console.WriteLine("\n¿Cual es tu Nombre? \n\r");
				persona.nombre = Console.ReadLine();
			    Console.WriteLine("\n¿Cual es tu Codigo? \n\r");
			    persona.codigo = int.Parse(Console.ReadLine());
			    Console.WriteLine("\n¿Cual es tu Telefono? \n\r");
			    persona.tel =  int.Parse(Console.ReadLine());
			    Console.WriteLine("\n¿Cual es tu Facebook? \n\r");
			    persona.face =  Console.ReadLine();
			    this.tabla.Add(persona.codigo, persona);
                Console.Clear();
                
			}
		}
	public void editar()
		{
			for(int id=0; id<2; id++){
				Console.WriteLine("\r\r\r¿Cual es el Codigo que se editara:?");
				int codigo = int.Parse(Console.ReadLine());
				if(this.tabla.ContainsKey(codigo)){
				Persona edit= new Persona();
				edit = (Persona)(this.tabla[codigo]);
				
				Console.WriteLine("\n\r*Nombre\n");
				Console.WriteLine(edit.nombre);
				
				Console.WriteLine("\n\r\r*Codigo\n");
				Console.WriteLine(edit.codigo);
				
				Console.WriteLine("\n\r\r\r*Telefono\n");
				Console.WriteLine(edit.tel);
				
				Console.WriteLine("\n\r\r\r\r*Facebook\n");
				Console.WriteLine(edit.face);
				Console.WriteLine("\n Asi se Guardaran \n");
				
			
                Console.WriteLine("*Nombre:\n");
                edit.nombre= Console.ReadLine();
				
                Console.WriteLine("*Telefono:\n");
				edit.tel= int.Parse(Console.ReadLine());
				
				Console.WriteLine("*Facebook:\n");
				edit.face=Console.ReadLine();
				System.Console.Clear();	
				
			
				        Console.WriteLine("Presiona cualquier tecla para continuar...");
				        Console.ReadKey();
                        System.Console.Clear();
				}else{
					Console.WriteLine("No existe el codigo");
				        Console.ReadKey();
                        System.Console.Clear();
                        
                        }
				
			}				
				
			}
		
		
		public void eliminar()
		{
			for( int el=0; el<2; el++ ){  
				 Persona elimin= new Persona();
				 Console.WriteLine("\n Codigo a Eliminar");
				 elimin.codigo= int.Parse(Console.ReadLine());
				 
				 if(!tabla.ContainsKey(elimin.codigo)){
				Console.WriteLine("Este codigo no existe, favor de verificarlo");
				Console.ReadLine();
				System.Console.Clear();
				}
				else{
				 	System.Console.Clear();
					elimin = (Persona)(this.tabla[elimin.codigo]);
				
				Console.WriteLine("-Nombre");
				Console.WriteLine(elimin.nombre);
				
				Console.WriteLine("-telefono");
				Console.WriteLine(elimin.tel);
				
				Console.WriteLine("-facebook");
				Console.WriteLine(elimin.face);
				
				Console.WriteLine("¿Esta seguro de eliminarlo?  presiona \n Si\n No ");
				string res= Console.ReadLine();
				if(res == "Si"){
				        this.tabla.Remove(elimin.codigo);
                        Console.WriteLine("Los Datos fueron eliminados");				        
				}
				else{
					   Console.WriteLine("Los Datos no fueron eliminaron ");
				}
				Console.WriteLine("Presiona cualquier tecla para continuar...");
				Console.ReadKey();	
			}	 
		    }
			}
		
		public void imprimir()
		{
			Console.Clear();
			
			Console.WriteLine(" Datos Guardados ");
			
			  IDictionaryEnumerator comparacion = tabla.GetEnumerator();
			     while(comparacion.MoveNext() ){
				Persona mostrar=(Persona)(tabla[comparacion.Key]);
				
				Console.WriteLine("+Nombre");
				Console.WriteLine(mostrar.nombre);
				
				Console.WriteLine("+Codigo");
				Console.WriteLine(mostrar.codigo);
				
				Console.WriteLine("+telefono");
				Console.WriteLine(mostrar.tel);
					
				Console.WriteLine("+facebook");
				Console.WriteLine(mostrar.face);	
                				
		}
			  Console.ReadLine();
	}
	}
		
}
	

