using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO5_Prestamos.clases
{
    internal class PrestamoHipotecario : Prestamos
    {
        private const double _tasaInteres = 0.13;
        private string _tipoBien;//casa, terreno
        private double _montoBien;
        private string _numeroRegistro;
        private string _direccion;

        public PrestamoHipotecario()
        {
        }

        public PrestamoHipotecario(double tasaInteres, string tipoBien, double montoBien, string numeroRegistro, string direccion, int codigoPrestamo, Cliente cliente, DateOnly fechaSolicitud, int anioAprobacion, double montoSolicitud, double montoAprobado, int plazo)
            : base(codigoPrestamo, cliente, fechaSolicitud, anioAprobacion, montoSolicitud, montoAprobado, plazo)
        {
            
            TipoBien = tipoBien;
            MontoBien = montoBien;
            NumeroRegistro = numeroRegistro;
            Direccion = direccion;
        }

        public Double TasaInteres
        {
            get { return _tasaInteres; }
            
        }
        public string TipoBien
        {
            get { return _tipoBien; }
            set { _tipoBien = value; }
        }
        public double MontoBien
        {
            get { return _montoBien; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El monto del bien debe ser un número positivo.");
                }
                else
                {
                    _montoBien = value;
                }
            }
        }
        public string NumeroRegistro
        {
            get { return _numeroRegistro; }
            set { _numeroRegistro = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }



        int anioActual = DateOnly.FromDateTime(DateTime.Now).Year;
        public override double CantidadCuotas()
        {

            return (anioActual - AnioAprobacion) * 12;
        }

        public override double MontoCuotas()
        {
            return (MontoAprobado / ((anioActual - AnioAprobacion) * 12)) *
                TasaInteres;
        }

        public override double ObtenerMontoPagado()
        {
            return (MontoAprobado / ((anioActual - AnioAprobacion) * 12)) *
                (1 + TasaInteres) * Plazo;
        }

        public override double ObtenerSaldo()
        {
            return MontoAprobado - (MontoAprobado / ((anioActual - AnioAprobacion) * 12)) *
                (1 + TasaInteres) * Plazo;
        }

        public override string? ToString()
        {
            return base.ToString() + $", TasaInteres: {TasaInteres}, TipoBien: {TipoBien}, MontoBien: {MontoBien}, NumeroRegistro: {NumeroRegistro}, Direccion: {Direccion}";

        }
    }
}
