using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    public class Detalle_Venta //Id, VentaId, ProductoID, Cantidad, PrecioUnitario
    {
        private int _id;
        private Venta _venta;
        private Producto _producto;
        private double _cantidad;
        private double _precio_unitario;

        public int Id { get => _id; set => _id = value; }
        public Venta Venta { get => _venta; set => _venta = value; }
        public Producto Producto { get => _producto; set => _producto = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Precio_unitario { get => _precio_unitario; set => _precio_unitario = value; }

        public Detalle_Venta()
        {
            _venta = new Venta();
            _producto = new Producto();
        }

    }
}
