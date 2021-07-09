using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial
{
    public class LocalComercial
    {
        public string nombre;
        public string direccion;
        public string propietario;
        public int fechadecreacion;

        public LocalComercial()
        {
        }

        public LocalComercial(string nombre, string direccion, string propietario, int fechadecreacion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.propietario = propietario;
            this.fechadecreacion = fechadecreacion;


        }

        public void imprimirtodo()
        {
            Console.WriteLine("El local es" + nombre + "Se encuentra en " + direccion + "creado por" + propietario + "desde" + fechadecreacion);
        }
    }
}
    
