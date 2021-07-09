namespace Comercial
{
    public class LocalComercialNuevo : LocalComercial

    {
        public double valordefacturacion;
        public double valordedescuentos;
        public double valortotal;
        private double valorfacturacion;

        public LocalComercialNuevo()
        {
        }

        public LocalComercialNuevo(double valorfacturacion)
        {
            this.valorfacturacion = valorfacturacion;
        }

        public LocalComercialNuevo (double valordefacturacion, double valordedescuento, double valortotal)
        {
            this.valordefacturacion = valordefacturacion;
            this.valordedescuentos = valordedescuento;
            this.valortotal = valortotal;
        }
        public void calcular()
        {
            if( valordefacturacion > 3650)
            {
                valortotal = valordefacturacion - valortotal;
            }
            
        }

        }
    }

