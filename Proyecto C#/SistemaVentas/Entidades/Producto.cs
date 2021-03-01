using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    public class Producto
    {
        private int _Id;
        private Categoria categoria;
        private string _Nombre;
        private string _Descripcion;
        private double _Stock;
        private double _PrecioCompra;
        private double _PrecioVenta;
        private DateTime _FechaVencimiento;
        private DateTime _FechaCreado;
        private byte[] _Imagen;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double Stock { get => _Stock; set => _Stock = value; }
        public double PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public double PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public DateTime FechaCreado { get => _FechaCreado; set => _FechaCreado = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }

        public Producto()
        {
            categoria = new Categoria();
        }
        public Producto(int id,Categoria categoria, string nombre, string descripcion, double stock , double preciocompra, double precioventa, 
            DateTime fechavencimiento,  DateTime fechacreado, byte[] imagen)
        {
            Id = id;
            Categoria = categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Stock = stock;
            PrecioCompra = preciocompra;
            PrecioVenta = precioventa;
            FechaVencimiento = fechavencimiento;
            FechaCreado = fechacreado;
            Imagen = imagen;
        }
    }
}
