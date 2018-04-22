using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Usuario
    {
        public Usuario()
        {
        }

        private int _id;
        private string _rut;
        private string _password;
        private static readonly List<Usuario> _listaUsuarios = new List<Usuario>();

        public Usuario(int id, string rut, string password)
        {
            this._id = id;
            this._rut = rut;
            this._password = password;
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Rut
        {
            get { return this._rut; }
            set { this._rut = value; }
        }

        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public static void AddUsers(Usuario usuario)
        {
            _listaUsuarios.Add(usuario);
        }

        public static void SeeUsers()
        {
            Console.WriteLine("\n***** Lista de usuarios *****");
            foreach (Usuario user in _listaUsuarios)
            {
                Console.WriteLine(user.Id + "). Rut: " + user.Rut + " password: " + user.Password);
            }
        }

    }
}
