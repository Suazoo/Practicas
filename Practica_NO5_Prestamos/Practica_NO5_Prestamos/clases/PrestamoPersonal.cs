using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO5_Prestamos.clases
{
    internal class PrestamoPersonal : Prestamos
    {

        private const double _tasaInteres = 0.14;
        private string _referenciaPersonal;

        public double TasaInteres
        {
            get { return _tasaInteres; }
            
        }

        public string ReferenciaPersonal
        {
            get { return _referenciaPersonal; }
            set { _referenciaPersonal = value; }
        }

        public PrestamoPersonal()
        {
        }

        public PrestamoPersonal(double tasaInteres, string referenciaPersonal, int codigoPrestamo, Cliente cliente, DateOnly fechaSolicitud, int anioAprobacion, double montoSolicitud, double montoAprobado, int plazo) :
            base(codigoPrestamo, cliente, fechaSolicitud, anioAprobacion, montoSolicitud, montoAprobado, plazo)
        {
            
            ReferenciaPersonal = referenciaPersonal;
        }

        int anioActual = DateOnly.FromDateTime(DateTime.Now).Year;
        public override double CantidadCuotas()
        {
            
            return (anioActual - AnioAprobacion) * 12;
        }

        public override double MontoCuotas()
        {
            return (MontoAprobado/ ((anioActual - AnioAprobacion) * 12))*
                (1 + TasaInteres);
        }

        public override double ObtenerMontoPagado()
        {
            return (MontoAprobado / ((anioActual - AnioAprobacion) * 12)) *
                (1 + TasaInteres) * Plazo;
        }

        public override double ObtenerSaldo()
        {
            return MontoAprobado -(MontoAprobado / ((anioActual - AnioAprobacion) * 12)) *
                (1 + TasaInteres) * Plazo;
        }

        public override string? ToString()
        {
            return $"Prestamo Personal: {base.ToString()}, Tasa de Interes: {TasaInteres}, Referencia Personal: {ReferenciaPersonal}";
        }
    }
}
