using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRevitAPIConsola
{
    class Vehiculo
    {
        //Propiedades
        public double motor;
        public int ruedas;
        public int asientos;

        //Metodos
        public void Arrancar()
        {
            //Aca tiene que haber codigo que permita arrancar el vehiculo
            Console.WriteLine("El auto arranco");
        }

        public void Frenar()
        {
            //Aca tiene que haber codigo que permita frenar el vehiculo
            Console.WriteLine("El auto se freno");
        }

        //Constructores
        public Vehiculo(double cilindradaMotor)
        {
            motor = cilindradaMotor;
        }
    }
}
