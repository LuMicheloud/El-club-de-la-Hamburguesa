using System.Reflection.Metadata.Ecma335;

namespace El_club_de_la_Hamburguesa.Views.Home
{
    public class Tarjeta {
        private String numero;
        private String titular;
        private String vencimiento;
        private String codigoDeSeguridad;

        public Tarjeta(string numero, string titular, string vencimiento, string codigoDeSeguridad)
        {
            this.numero = numero;
            this.titular = titular;
            this.vencimiento = vencimiento;
            this.codigoDeSeguridad = codigoDeSeguridad;
        }

        public Boolean EsValida(string numero) {
        
        } //Return Tarjeta.numero;//
    }
}
