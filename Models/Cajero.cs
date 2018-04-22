using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Cajero : Usuario
    {
        private bool _cajero;
        private static List<Cajero> _listacajeros = new List<Cajero>();

        public Cajero(int id, string rut, string password, bool cajero) : base(id, rut, password){
            this._cajero = cajero;
        }

        public bool Cashier
        {
            get { return this._cajero; }
            set { this._cajero = value; }
        }

        public static void AddCajero(Cajero cajero)
        {
            _listacajeros.Add(cajero);
        }

        public static void SeeAdmins()
        {
            Console.WriteLine("\n***** Lista de cajeros *****");
            foreach (Cajero cajero in _listacajeros)
            {
                Console.WriteLine(cajero.Id + "). Rut: " + cajero.Rut + " password: " + cajero.Password);
            }
        }
    }
}
