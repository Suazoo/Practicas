using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal class EmpleadoPorHora : Empleado
    {
        private int _horasTrabajadas;
        private double _pagoPorHora;

        public int HorasTrabajadas
        {
            get { return _horasTrabajadas; }
            set { _horasTrabajadas = value; }
        }
        public double PagoPorHora
        {
            get { return _pagoPorHora; }
            set { _pagoPorHora = value; }
        }

        public EmpleadoPorHora()
        {
        }
        public EmpleadoPorHora(int horasTrabajadas, double pagoPorHora, int idEmpleado, DateOnly fechaNombramiento, string numeroSeguroSocial, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico) : base(idEmpleado, fechaNombramiento, numeroSeguroSocial, idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }
        public override string? ToString()
        {
            return $"{base.ToString()} Horas Trabajadas: {HorasTrabajadas}, Pago por Hora: {PagoPorHora}";
        }

        public override double Ingresos()
        {
            if (HorasTrabajadas <= 40)
            {
                return HorasTrabajadas * PagoPorHora;
            }
            else if (HorasTrabajadas > 40)
            {
                return 40 * PagoPorHora + (HorasTrabajadas - 40) * (PagoPorHora * 1.5);
            }
            else 
            {
                throw new ArgumentException("Horas trabajadas no pueden ser negativas.");
            }
        }
    }
}
