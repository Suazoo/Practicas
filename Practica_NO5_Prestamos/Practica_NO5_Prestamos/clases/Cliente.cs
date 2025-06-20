using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_NO5_Prestamos.clases
{
    internal class Cliente
    {
        private int _idCliente;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _correo;

        public Cliente()
        {
        }

        public int Idcliente
        {
            get { return _idCliente; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("El ID del cliente debe ser un número positivo.");
                }
                else
                {
                    _idCliente = value;
                }
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public Cliente(int idcliente, string nombre, string apellido, string telefono, string correo)
        {
            Idcliente = idcliente;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }
        public override string ToString()
        {
            return $"IdCliente: {Idcliente}, Nombre: {Nombre}, Apellido: {Apellido}, Telefono: {Telefono}, Correo: {Correo}";
        }
    }
}
