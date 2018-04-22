using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Venta
    {
        private int _id;
        private DateTime _fechaventa;
        private double _totalventa;
        private Cajero _cajero;
        private Categoria _categoria;
        private static List<Venta> _listaventas = new List<Venta>();

        public Venta(int id, DateTime fechaventa, double totalventa, Cajero cajero,Categoria categoria)
        {
            this._id = id;
            this._fechaventa = fechaventa;
            this._totalventa = totalventa;
            this._cajero = cajero;
            this._categoria = categoria;
        }


    }
}
