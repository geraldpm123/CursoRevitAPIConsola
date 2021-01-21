using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRevitAPIConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Se escribe en la consola la frase "Hola Mundo"
            Console.WriteLine("Hola Mundo");
            //Se esta escribiendo los numeros del 1 al 4 
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            */

            #region Variables
            /*
            //Principales variables de programacion en C#
            //Bool
            bool mayorEdad;
            mayorEdad = false;

            //Char
            char caract = 'g';
            //Int
            int edad;
            edad = 25;
            //Float
            float decim = 0;
            //Double
            double numeroDeIdentificacion;
            numeroDeIdentificacion = 5000;
            //String
            string nombreUsuario = "Gerald";
            string ggg = "holaaa";

            mayorEdad = true;

            Console.WriteLine("Su edad es {0}",numeroDeIdentificacion);
            */
            #endregion

            #region Operadores Aritmeticos
            /*
            double numero1 = 5;
            numero1 = numero1 + 2;

            double numero2 = 2;

            double operacion = (numero1 / numero2)+numero1;

            Console.WriteLine(operacion);
            */
            #endregion

            #region Condicionales
            /*
            int edad = 20;

            if (edad==18)
            {
                Console.WriteLine("Tienes 18 años");
            }
            else
            {
                Console.WriteLine("No tienes 18 años");
            }*/
            #endregion

            #region Bucles
            /*
            int tope = 10;

            for (int i = 0; i < tope; i++)
            {
                Console.WriteLine(i);
            }
            

            //Programa que calcule la suma de los n primeros numeros
            Console.WriteLine("Escriba un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());


            int suma=0;

            for (int i = 1; i <= numero; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine("La suma de los {0} primeros numeros es {1}",numero,suma);
            */
            #endregion

            #region Funciones
            /*
            double[] vector = { 1, 2, 3 };
            string[] valor4s = { "gg", "hh" };


            double numero1 = 5.2;
            double numero2 = 7.5;
            double suma = SumarDosValores(numero1, numero2);
            Console.WriteLine(suma);
            numero1 = 100;
            suma = SumarDosValores(2,2);
            Console.WriteLine(suma);


            double SumarDosValores(double num1,double num2)
            {
                return num1 + num2;
            }
            */
            #endregion

            #region Objetos
            //Instanciar objeto de la clase Vehiculo
            Vehiculo autoVerde = new Vehiculo(1600);
            Vehiculo camionAzul = new Vehiculo(2000);
            Vehiculo motoNaranja = new Vehiculo(600);

            //Lista de objetos
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(autoVerde);
            vehiculos.Add(camionAzul);
            vehiculos.Add(motoNaranja);

            camionAzul.Arrancar();
            camionAzul.Frenar();
            //Console.WriteLine(autoVerde.motor);

            //Instanciar objeto de la clase Viga
            //Viga viga1 = new Viga(0.6, 3, "concreto 210");

            int numeroVigas = Viga.ContarLasVigasExistentes();
            Console.WriteLine(numeroVigas);
            #endregion

        }
    }
}
