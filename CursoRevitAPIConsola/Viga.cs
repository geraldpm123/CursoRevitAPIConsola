using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRevitAPIConsola
{
    class Viga
    {
        //Propiedades
        public double peralte;
        public double longitud;
        public string material;
        //Metodos
        public void InvertirDireccion()
        {

        }
        public static int ContarLasVigasExistentes()
        {
            //aqui va el codigo necesario para contar todas las vigas
            return 16;
        }

        //Constructores
        public Viga(double Peralte,double Longitud,string Material)
        {
            peralte = Peralte;
            longitud = Longitud;
            material = Material;
        }
    }
}
