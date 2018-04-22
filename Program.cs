using System;

namespace ControlVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlVentas.Models.Administrador administrador = new Models.Administrador(1, "11.111.111-1", "123", true);
            ControlVentas.Models.Administrador.AddAdmins(administrador);
            ControlVentas.Models.Administrador.SeeAdmins();
        }
    }
}
