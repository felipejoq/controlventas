using System;
namespace ControlVentas.Views
{
    public class MenuVentas
    {
        private static int opcion = 0;

        public static void GenerarMenuVentas()
        {
            
            do
            {
                Console.WriteLine("+----------------------------------+\n" +
                                  "+---       Menú de Ventas       ---+\n" +
                                  "+----------------------------------+\n" +
                                  "+--- 1. Hacer venta              --+\n" +
                                  "+--- 2. Ver ventas               --+\n" +
                                  "+--- 3. Enmendar venta           --+\n" +
                                  "+--- 4. Archivar venta           --+\n" +
                                  "+--- 5. Volver al menú general   --+\n");

                Console.Write("Elija una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Proceso hacer venta");
                        break;
                    case 2:
                        Console.WriteLine("Proceso muestra ventas");
                        break;
                    case 3:
                        Console.WriteLine("Proceso enmienda venta");
                        break;
                    case 4:
                        Console.WriteLine("Proceso archiva venta");
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
