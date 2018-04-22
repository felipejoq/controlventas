using System;
namespace ControlVentas.Views
{
    public class MenuUsuarios
    {
        private static int opcion = 0;

        public static void GenerarMenuUsuarios(){
            do
            {
                Console.WriteLine("+----------------------------------+\n" +
                                  "+---      Menú de Usuarios      ---+\n" +
                                  "+----------------------------------+\n" +
                                  "+--- 1. Crear Usuarios           --+\n" +
                                  "+--- 2. Ver Usuarios             --+\n" +
                                  "+--- 3. Editar Usuarios          --+\n" +
                                  "+--- 4. Eliminar Usuarios        --+\n" +
                                  "+--- 5. Volver al menú general   --+\n");

                Console.Write("Elija una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Proceso crea usuarios");
                        break;
                    case 2:
                        Console.WriteLine("Proceso muestra lista de usuarios");
                        break;
                    case 3:
                        Console.WriteLine("Proceso edita usuarios");
                        break;
                    case 4:
                        Console.WriteLine("Proceso elimina usuarios");
                        break;
                    default:
                        Console.WriteLine("Vuelve al menú general\n\n");
                        Views.Menu.GenerarMenuGeneral();
                        break;
                }

            } while (opcion != 5);
        }

    }
}
