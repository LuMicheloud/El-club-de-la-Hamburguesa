using System.Reflection.Metadata.Ecma335;

namespace El_club_de_la_Hamburguesa.Views.Home
{
    public class Usuario {
        private int id;
        private String name;
        private String email;
        private String contrasenia;
        private Boolean descuentoBienvenidaAplicado;

        public Usuario(int id, String nombre, String email, String contrasenia)
        {

            this.id = id;
            this.email = email;
            this.contrasenia = contrasenia;

        }
        public int getId() { return id; 
        }
        public String getName() { return name;
        }
        public String getEmail() { return email; 
        }


        public Boolean verificarContrasenia (String contrasenia) {

            return !string.IsNullOrEmpty(contrasenia);

        } 



    }
}
