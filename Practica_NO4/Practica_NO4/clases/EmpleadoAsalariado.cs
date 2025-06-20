using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal class EmpleadoAsalariado : Empleado
    {
        private double _salarioSemanal;

        public double SalarioSemanal
        {
            get { return _salarioSemanal; }
            set { _salarioSemanal = value; }
        }
        public EmpleadoAsalariado()
        {
        }

        public EmpleadoAsalariado(int idEmpleado, DateOnly fechaNombramiento, string numeroSeguroSocial, double salarioSemanal, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico)
            : base(idEmpleado, fechaNombramiento, numeroSeguroSocial, idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override string? ToString()
        {
            return $"Id Empleado: {IdEmpleado}, Fecha de Nombramiento: {FechaNombramiento}, Numero Seguro Social: {NumeroSeguroSocial}, Salario Semanal: {SalarioSemanal}, {base.ToString()}";
        }

        public override double Ingresos() => SalarioSemanal;

    }
}
