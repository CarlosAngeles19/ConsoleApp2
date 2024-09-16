using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pantallas
    {
        static int contador = 0;
        public static float[] usuarios = new float[7];
        public static int PantallaPrincipal()
        {
            Console.Clear();

            string texto = "================================\n" +
                           "Encuestas de Calidad\n" +
                           "================================\n" +
                           "1: Rol de cliente\n" +
                           "2: Rol de trabajador\n" +
                           "3: Rol de administrador\n" +
                           "================================";

            Console.WriteLine(texto);

            return Operaciones.getEntero("Ingrese su rol:", texto);
        }

        public static int RegistrarUsuario()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                string texto = "================================\n" +
                               "Registrar Usuario \n" +
                               "================================\n";
                Console.WriteLine(texto);

                // Solicitar nombre de usuario
                string nombreUsuario = Operaciones.getTextoPantalla("Ingrese su nombre de usuario: ");

                // Verificar si el usuario ya existe
                if (usuarios.ContainsKey(nombreUsuario))
                {
                    Console.WriteLine("El usuario ya existe, intenta con otro nombre.");
                }
                else
                {
                    // Solicitar contraseña
                    string contraseña = Operaciones.getTextoPantalla("Ingrese su contraseña: ");

                    // Almacenar usuario y contraseña
                    usuarios[nombreUsuario] = contraseña;
                    Console.WriteLine("Usuario registrado con éxito.");
                }

                string texto2 = "================================\n" +
                                "1: Registrar otro usuario\n" +
                                "2: Regresar\n";
                Console.WriteLine(texto2);

                // Obtener la opción del usuario
                opcion = Operaciones.getEntero("Ingrese una opción:", texto);

            } while (opcion == 1);

            return opcion;
        }



    }
}
