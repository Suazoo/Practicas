using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO4.clases
{
    internal class Cliente:Persona
    {
        private int _idCliente;
        private DateOnly _fechaRegistro;

        public Cliente()
        {
        }

        public Cliente(int idCliente, DateOnly fechaRegistro, int idPersona, string nombres, string apellidos, string direccion, string telefono, string correoElectronico) : base(idPersona, nombres, apellidos, direccion, telefono, correoElectronico)
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public DateOnly FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        public override string? ToString()
        {
            return $"{base.ToString()} IdCliente:{IdCliente} FechaRegistro:{FechaRegistro} ";
        }
    }
}
