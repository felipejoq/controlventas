using System;
namespace ControlVentas.Views
{
    public class MenuReportes
    {
        private static int opcion = 0;

        public static void GenerarMenuReportes()
        {

            do
            {
                Console.WriteLine("+----------------------------------+\n" +
                                  "+---      Menú de Reportes      ---+\n" +
                                  "+----------------------------------+\n" +
                                  "+--- 1. Generar reporte          --+\n" +
                                  "+--- 2. Ver un reporte           --+\n" +
                                  "+--- 3. Editar un reporte        --+\n" +
                                  "+--- 4. Eliminar un reporte      --+\n" +
                                  "+--- 5. Volver al menú general   --+\n");

                Console.Write("Elija una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Proceso generar un reporte");
                        break;
                    case 2:
                        Console.WriteLine("Proceso mostrar un reporte");
                        break;
                    case 3:
                        Console.WriteLine("Proceso editar un reporte");
                        break;
                    case 4:
                        Console.WriteLine("Proceso eliminar un reporte");
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
