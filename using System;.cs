using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFA
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEstados;
            char[] alfabeto = new char[] { '0', '1' }; //Sigma
            int p = 0; //q0
            string cadena; //rho
            int guardarEstados;
            char guardarTransiciones;

            Console.WriteLine("***Alfabeto{0,1}***");
            
            Console.WriteLine("Ingrese el número de estados: ");
            numeroEstados = Convert.ToInt32(Console.ReadLine());
            char[] estados = new char[numeroEstados]; //Q
            char[,] tablaTransiciones = new char[numeroEstados, 2];//Sa
            
            Console.WriteLine("Sus estados son: ");
            for (int i = 0; i < numeroEstados; i++)
            {
                Console.WriteLine(i);

               guardarEstados =  estados[i];

            }


            Console.WriteLine("***Ingrese la tabla de transiciones***");
            for (int i = 0; i < numeroEstados; i++)
            {
                Console.WriteLine("Estado " + i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Si ingresa ' " + alfabeto[j] + " '");
                    tablaTransiciones[i, j]=Convert.ToChar(Console.ReadLine());
                    

                }
            }

            for (int i = 0; i < numeroEstados; i++)
            {
                Console.WriteLine("Tabla de transición para el estado " + i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(j+" ----->    " + tablaTransiciones[i, j]);


                }
                Console.WriteLine("     ");

            }
           
            

            Console.WriteLine("Ingrese el estado inicial: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El estado inicial es: " + p);


         


            Console.WriteLine("Ingresa la cantidad de estados final: ");
            int numeroEstadosFinales = Convert.ToInt32(Console.ReadLine());
            char[] estadosFinales = new char[numeroEstadosFinales]; //F
            Console.WriteLine("Ingresa el estado final: ");
            for (int i = 0; i < numeroEstadosFinales; i++)
            {
                estadosFinales[i] = Convert.ToChar(Console.ReadLine());
                //Console.WriteLine(estadosFinales);

            }


            string y;

            do
            {

                cadena = "";
                Console.WriteLine("Ingrese la cadena: ");
                
                cadena = Console.ReadLine();

                //Console.WriteLine(cadena);

                
                for (int i = 0; i < cadena.Length; i++)
                {
                    
                    
                   p = tablaTransiciones[p,cadena[i]]; <-------- No se controló IndexOutOfRangeException                   cadena.Substring(i);
                   
                    //Console.WriteLine(cadena[i]);
                    

                }

                if (estadosFinales.Equals(p))
                {
                    Console.WriteLine("Cadena Aceptada");
                }
                else {
                    Console.WriteLine("Cadena Rechazada");
                
                }


                Console.WriteLine("¿Quieres ingresar otra cadena?");
                y = Console.ReadLine();

            } while (y == "y");
            return;

        }
    }
}