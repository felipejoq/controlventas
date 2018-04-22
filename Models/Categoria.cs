using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private static List<Categoria> _listacategorias = new List<Categoria>();

        public Categoria(int id, string nombre, string descripcion){
            this._id = id;
            this._nombre = nombre;
            this._descripcion = descripcion;
        }

        public Categoria(){}

        public int Id{
            get { return this._id; }
            set { this._id = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }

        public static void AddCategoria(Categoria categoria)
        {
            _listacategorias.Add(categoria);
        }

        public static void SeeAdmins()
        {
            Console.WriteLine("\n***** Lista de cajeros *****");
            foreach (Categoria categoria in _listacategorias)
            {
                Console.WriteLine(categoria.Id + "). Nombre: " + categoria.Nombre + " Descripción: " + categoria.Descripcion);
            }
        }




    }
}
