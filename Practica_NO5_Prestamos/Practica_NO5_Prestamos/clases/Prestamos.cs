using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO5_Prestamos.clases
{
    internal abstract class Prestamos
    {
        private int _codigoPrestamo;
        private Cliente _cliente;
        private DateOnly _fechaSolicitud;
        private int _anioAprobacion;
        private double _montoSolicitado;
        private double _montoAprobado;
        private int _plazo;

        public Prestamos()
        {
        }

        public int CodigoPrestamo
        {
            get { return _codigoPrestamo; }
            set
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("El código del préstamo debe ser un número positivo.");
                }
                else
                {
                    _codigoPrestamo = value;
                }
            }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        public DateOnly FechaSolicitud
        {
            get { return _fechaSolicitud; }
            set { _fechaSolicitud = value; }
        }
        public int AnioAprobacion
        {
            get { return _anioAprobacion; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El año del préstamo debe ser un número positivo.");
                }
                else
                {
                    _anioAprobacion = value;
                }
            }
        }
        
        public double MontoSolicitud
        {
            get { return _montoSolicitado; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El monto solicitado debe ser un número positivo.");
                }
                else
                {
                    _montoSolicitado = value;
                }
            }
        }
        public double MontoAprobado
        {
            get { return _montoAprobado; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El monto aprobado debe ser un número positivo.");
                }
                else
                {
                    _montoAprobado = value;
                }
            }
        }
        public int Plazo
        {
            get { return _plazo; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El plazo debe ser un número positivo.");
                }
                else
                {
                    _plazo = value;
                }
            }
        }

        public Prestamos(int codigoPrestamo, Cliente cliente, DateOnly fechaSolicitud, int anioAprobacion, double montoSolicitud, double montoAprobado, int plazo)
        {
            CodigoPrestamo = codigoPrestamo;
            Cliente = cliente;
            FechaSolicitud = fechaSolicitud;
            AnioAprobacion = anioAprobacion;
            MontoSolicitud = montoSolicitud;
            MontoAprobado = montoAprobado;
            Plazo = plazo;
        }

        public abstract double MontoCuotas();
        public abstract double ObtenerMontoPagado();
        public abstract double ObtenerSaldo();
        public abstract double CantidadCuotas();

        public override string? ToString()
        {
            return $"CodidgoPrestamo: {CodigoPrestamo}, Cliente: {Cliente}, FechaSolicitud: {FechaSolicitud}, AnioAprobacion: {AnioAprobacion}, MontoSolicitado: {MontoSolicitud}, MontoAprobado: {MontoAprobado}, Plazo: {Plazo}";
        }
    }
}
