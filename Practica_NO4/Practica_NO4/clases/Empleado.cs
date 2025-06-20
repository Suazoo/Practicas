using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal abstract class Empleado:Persona
    {
        private int _idEmpleado;
        private DateOnly _fechaNombramiento;
        private string _numeroSeguroSocial;

        public Empleado()
        {
        }

        public Empleado(int idEmpleado, DateOnly fechaNombramiento, string numeroSeguroSocial, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico) : base(idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            IdEmpleado = idEmpleado;
            FechaNombramiento = fechaNombramiento;
            NumeroSeguroSocial = numeroSeguroSocial;
        }

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        public DateOnly FechaNombramiento
        {
            get { return _fechaNombramiento; }
            set { _fechaNombramiento = value; }
        }
        public string NumeroSeguroSocial
        {
            get { return _numeroSeguroSocial; }
            set { _numeroSeguroSocial = value; }
        }


        public abstract double Ingresos(); 


        public override string? ToString()
        {
            return $"Id Empleado: {IdEmpleado}, Fecha de Nombramiento: {FechaNombramiento}, Numero Seguro Social: {NumeroSeguroSocial}, {base.ToString()}";
        }
    }
}
