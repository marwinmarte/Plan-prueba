using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    public class Venta //Id, ClienteId, FechaVenta, NumeroDocumento, TipoDocumento
    {
        private int _id;
        private Cliente _cliente;
        private DateTime _fecha_venta;
        private string _numero_documento;
        private string _tipo_documento;

        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public DateTime Fecha_venta { get => _fecha_venta; set => _fecha_venta = value; }
        public string Numero_documento { get => _numero_documento; set => _numero_documento = value; }
        public string Tipo_documento { get => _tipo_documento; set => _tipo_documento = value; }

        public Venta()
        {
            _cliente = new Cliente();
        }
    }
}
