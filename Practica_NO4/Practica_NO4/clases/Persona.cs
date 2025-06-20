using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal abstract class Persona
    {
        private int _idPersona;
        private string _nombres;
        private string _apellidos;
        private string _dirireccion;
        private string _telefono;
        private string _correoElectronico;

        public Persona()
        {
        }

        public Persona(int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico)
        {
            IdPersona = idPersona;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }

        public int IdPersona 
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public string Direccion
        {
            get { return _dirireccion; }
            set { _dirireccion = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string CorreoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }
        public override string? ToString()
        {
            return $"IdPersona:{IdPersona} Nombres:{Nombres} Apellidos:{Apellidos} Direccion:{Direccion} Telefono:{Telefono} CorreoElectronico:{CorreoElectronico}";
        }

    }
}
