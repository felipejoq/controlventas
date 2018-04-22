using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Administrador : User
    {

        private bool administrador;
        private static List<Administrador> _listaAdminis = new List<Administrador>();

        public Administrador(int id, string rut, string password, bool admin) : base (id, rut, password)
        {
            this.administrador = admin;
        }

        public static void AddAdmins(Administrador admin)
        {
            _listaAdminis.Add(admin);
        }

        public static void SeeAdmins()
        {
            Console.WriteLine("\n***** Lista de usuarios *****");
            foreach (Administrador admin in _listaAdminis)
            {
                Console.WriteLine(admin.Id + "). Rut: " + admin.Rut + " password: " + admin.Password);
            }
        }
    }
}
