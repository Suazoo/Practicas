using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal class EmpleadoBaseMasComision:EmpleadoPorComision
    {
        private double _salarioBase;

        public double SalarioBase
        {
            get { return _salarioBase; }
            set { _salarioBase = value; }
        }
        public EmpleadoBaseMasComision()
        {
        }

        public EmpleadoBaseMasComision(double salarioBase, int ventasTotales, double tarifaComision, int idEmpleado, DateOnly fechaNombramiento, string numeroSeguroSocial, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico) : base(ventasTotales, tarifaComision, idEmpleado, fechaNombramiento, numeroSeguroSocial, idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            SalarioBase = salarioBase;
        }

        public override double Ingresos() => SalarioBase + (VentasTotales * TarifaComision);


        public override string? ToString()
        {
            return $"{base.ToString()} SalarioBase:{SalarioBase}";
        }
    }
}
