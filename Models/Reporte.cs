using System;
using System.Collections.Generic;
namespace ControlVentas.Models
{
    public class Reporte
    {
        private int _id;
        private string _nombrereporte;
        private string _descripcionreporte;
        private DateTime _fechainicialpasada;
        private DateTime _fechaterminopasada;
        private DateTime _fechacomparainicial;
        private DateTime _fechacomparatermino;
        private Administrador _administrador;
        private static readonly List<Reporte> _listareportes = new List<Reporte>();

        public Reporte(int id, string nombre, string descripcion, DateTime fechainicialpasada, DateTime fechaterminopasada, DateTime fechacomparainicial, DateTime fechacomparatermino, Administrador admin)
        {
            this._id = id;
            this._nombrereporte = nombre;
            this._descripcionreporte = descripcion;
            this._fechainicialpasada = fechainicialpasada;
            this._fechaterminopasada = fechaterminopasada;
            this._fechacomparainicial = fechacomparainicial;
            this._fechacomparatermino = fechacomparatermino;
            this._administrador = admin;
        }

        public Reporte(){
            
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Nombre{
            get { return this._nombrereporte; }
            set { this._nombrereporte = value; }
        }

        public string Descripcion
        {
            get { return this._descripcionreporte; }
            set { this._descripcionreporte = value; }
        }

        public DateTime FechaInicialPasada
        {
            get { return this._fechainicialpasada; }
            set { this._fechainicialpasada = value; }
        }

        public DateTime FechaTerminoPasada{
            get { return this._fechaterminopasada; }
            set { this._fechaterminopasada = value; }
        }

        public DateTime FechaComparaInicial
        {
            get { return this._fechacomparainicial; }
            set { this._fechacomparainicial = value; }
        }

        public DateTime FechaComparaTermino
        {
            get { return this._fechacomparatermino; }
            set { this._fechacomparatermino = value; }
        }

        public Administrador Admin
        {
            get { return this._administrador; }
            set { this._administrador = value; }
        }

        public static void AddReporte(Reporte reporte)
        {
            _listareportes.Add(reporte);
        }

        public static void SeeReportes()
        {
            Console.WriteLine("\n***** Lista de Reportes *****");
            foreach (Reporte report in _listareportes)
            {
                Console.WriteLine(report.Id + "). Nombre reporte: " + report.Nombre + " Descripcion: " + report.Descripcion);
            }
        }

    }
}
