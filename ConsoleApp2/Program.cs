using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                opcion = Pantallas.PantallaPrincipal();

                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.RegistrarUsuario();


                        break;
                    case 2:
                      
                        break;
                    case 3:
                     
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 5);
        }
    }
}