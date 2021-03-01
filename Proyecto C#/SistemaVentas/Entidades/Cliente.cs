using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    public class Cliente
    {
       private int _id;
       private string _nombre;
       private string _apellido;
       private int _dni;
       private string _domicilio;
       private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public Cliente()
        {

        }
        public Cliente(int id, string nombre, string apellido, int dni, string domicilio, string telefono)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._domicilio = domicilio;
            this._telefono = telefono;
        }
    }
}
