using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    class Usuario
    {
        private static int _id;
        private static string _nombre;
        private static string _apellido;
        private static int _dni;
        private static string _direccion;
        private static string _telefono;
        private static string _usuario;
        private static string _contraseña;
        private static string _tipo;

        public static int Id { get => _id; set => _id = value; }
        public static string Nombre { get => _nombre; set => _nombre = value; }
        public static string Apellido { get => _apellido; set => _apellido = value; }
        public static int Dni { get => _dni; set => _dni = value; }
        public static string Direccion { get => _direccion; set => _direccion = value; }
        public static string Telefono { get => _telefono; set => _telefono = value; }
        public static string Usuarios { get => _usuario; set => _usuario = value; }
        public static string Contraseña { get => _contraseña; set => _contraseña = value; }
        public static string Tipo { get => _tipo; set => _tipo = value; }
    }
}
