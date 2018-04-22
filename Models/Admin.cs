using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Administrador : Usuario
    {

        private bool _admin;
        private static List<Administrador> _listaAdminis = new List<Administrador>();

        public Administrador(int id, string rut, string password, bool admin) : base (id, rut, password)
        {
            this._admin = admin;
        }

        public static void AddAdmins(Administrador admin)
        {
            _listaAdminis.Add(admin);
        }

        public bool Admin{
            get { return this._admin; }
            set{ this._admin = value; }
        }

        public static void SeeAdmins()
        {
            Console.WriteLine("\n***** Lista de Administradores *****");
            foreach (Administrador admin in _listaAdminis)
            {
                Console.WriteLine(admin.Id + "). Rut: " + admin.Rut + " password: " + admin.Password);
            }
        }
    }
}
