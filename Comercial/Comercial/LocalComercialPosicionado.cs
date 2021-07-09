namespace Comercial
{
    public class LocalComercialPosicionado : LocalComercialNuevo
    {
        private int v;

        public LocalComercialPosicionado(int v)
        {
            this.v = v;
        }

        public LocalComercialPosicionado(double valorfacturacion) : base (valorfacturacion)
        {

        }
    }
}
