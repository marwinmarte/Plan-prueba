using System;
using System.Data;
using System.Data.SqlClient;
using SistemaVentas.Entidades;
using SisVenttas.Datos;

namespace SistemaVentas.Datos
{
    public static class Fdetalle_venta
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_Fdetalle_venta_GetAll", dbParams);

        }
        public static int Insertar(Detalle_Venta detalle_venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, detalle_venta.Venta.Id),
                    FDBHelper.MakeParam("@ProductoID", SqlDbType.Int, 0, detalle_venta.Producto.Id),
                    FDBHelper.MakeParam("@Cantidad", SqlDbType.Decimal, 0, detalle_venta.Cantidad),
                    FDBHelper.MakeParam("@PrecioUnitario", SqlDbType.Decimal, 0, detalle_venta.Precio_unitario),

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fdetalle_venta_Insertar", dbParams));

        }
        
        public static int Eliminar(Detalle_Venta detalle_venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, detalle_venta.Id)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fdetalle_venta_Eliminar", dbParams));

        }

        internal static int disminuir_stock(Detalle_Venta dventa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@ProductoId", SqlDbType.Int, 0, dventa.Producto.Id),
                    FDBHelper.MakeParam("@Cantidad", SqlDbType.Decimal, 0, dventa.Cantidad),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fdetalle_venta_disminuir_stock", dbParams));
        }

        internal static int aumentar_stock(Detalle_Venta dventa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@ProductoId", SqlDbType.Int, 0, dventa.Producto.Id),
                    FDBHelper.MakeParam("@Cantidad", SqlDbType.Decimal, 0, dventa.Cantidad),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fdetalle_venta_aumentar_stock", dbParams));
        }
    }
}
