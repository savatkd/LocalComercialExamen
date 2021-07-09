using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial
{
    public class LocalEnPromocion : LocalComercialNuevo
        
    {
        
        public int cantidad;

        public LocalEnPromocion(int v1, double v2)
        {
        }

        public LocalEnPromocion(double valorfacturacion, double valordescuento, double valortotal, int cantidad) : base(valorfacturacion, valordescuento, valortotal)
        {
            this.cantidad = cantidad;

        }
            public void calcular1 ()
        {
            if(cantidad>10)
            {
                valortotal = valordefacturacion / valordedescuentos;
            }
        }
    }
}
