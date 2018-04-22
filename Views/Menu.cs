using System;
namespace ControlVentas.Views
{
    public class Menu
    {
        private static int opcion = 0;

        public static void GenerarMenuGeneral(){

            do
            {
                Console.WriteLine("+----------------------------------+\n" +
                                  "+--- Menú de opciones Generales ---+\n" +
                                  "+----------------------------------+\n" +
                                  "+--- 1. Usuarios                 --+\n" +
                                  "+--- 2. Ventas                   --+\n" +
                                  "+--- 3. Reportes                 --+\n" +
                                  "+--- 4. Salir del programa       --+\n");

                Console.Write("Elija una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Genera menú Usuarios");
                        Views.MenuUsuarios.GenerarMenuUsuarios();
                        break;
                    case 2:
                        Console.WriteLine("Genera menú Ventas");
                        Views.MenuVentas.GenerarMenuVentas();
                        break;
                    case 3:
                        Console.WriteLine("Genera menú Reportes");
                        Views.MenuReportes.GenerarMenuReportes();
                        break;
                    default:
                        Console.WriteLine("Sale del programa");
                        break;
                }

            } while (opcion != 4);

        }
    }
}
