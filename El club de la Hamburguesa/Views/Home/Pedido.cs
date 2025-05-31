using El_club_de_la_Hamburguesa.Views.Home;

namespace El_club_de_la_Hamburguesa.Views.Home
{
    public class Pedido {
        private int id;
        private String direccion;
        private Entrega metodoDeEntrega;
        private Estado estado;

        public Pedido(int id, string direccion, Entrega metodoDeEntrega, Estado estado)
        {
            this.id = id;
            this.direccion = direccion;
            this.metodoDeEntrega = metodoDeEntrega;
            this.estado = estado;
        }
    }


    public enum TipoEntrega{envioADomicilio, retiroEnLocal}

    public enum Pago {efectivo, tarjeta }

    public enum EstadoDePedido {enPreparacion, hecho }
}
