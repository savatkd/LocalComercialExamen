using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalComercial localComercial = new LocalComercial(); 
            localComercial.nombre = "veicor";
            localComercial.direccion = "Via Alajuela";
            localComercial.propietario = "Edwin Rivadeneira";
            localComercial.fechadecreacion = 2014;

            Console.WriteLine("El Comercial" + localComercial.nombre + "Brinda sus servicios en" + localComercial.direccion + ", su propetario es:" + localComercial.propietario + "quien brinda sus servicios desde" + localComercial.fechadecreacion);
            
            LocalComercialNuevo precios = new LocalComercialNuevo ();
            precios.valordefacturacion = 21050;
            precios.valordedescuentos = 0.8;
            precios.valortotal = 0;
            precios.calcular();

            Console.WriteLine("El valor de su factura es:" + precios.valortotal);

            LocalEnPromocion pago = new LocalEnPromocion(4562, 0.10);
            pago.cantidad = 14;
            pago.valortotal = 0;
            pago.calcular1();

            Console.WriteLine("El cobro es" + pago.valortotal);

            LocalComercialPosicionado visualizar = new LocalComercialPosicionado(15000);
            visualizar.valortotal = 15000;
            Console.WriteLine("El calaculo a cobrar es" + visualizar.valortotal);
        }
        
    }
}

