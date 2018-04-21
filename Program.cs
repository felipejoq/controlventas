using System;

namespace ControlVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario(1, "11.111.111-1", "123");
            Usuario.addUsers(u);
            Usuario.seeUsers();
        }
    }
}
