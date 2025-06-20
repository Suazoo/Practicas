using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal class EmpleadoPorComision: Empleado
    {
        private int _ventasTotales;
        private double _tarifaComision;

        public EmpleadoPorComision()
        {
        }

        public EmpleadoPorComision(int ventasTotales, double tarifaComision, int idEmpleado, DateOnly fechaNombramiento, string numeroSeguroSocial, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico) : base(idEmpleado, fechaNombramiento, numeroSeguroSocial, idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            VentasTotales = ventasTotales;
            TarifaComision = tarifaComision;
        }

        public int VentasTotales
        {
            get { return _ventasTotales; }
            set { _ventasTotales = value; }
        }
        public double TarifaComision
        {
            get { return _tarifaComision; }
            set { _tarifaComision = value; }
        }

        public override double Ingresos() => VentasTotales * TarifaComision;

        public override string? ToString()
        {
            return $"{base.ToString()} VentasTotales:{VentasTotales}  TarifaComision:{TarifaComision}";
        }
    }
}
