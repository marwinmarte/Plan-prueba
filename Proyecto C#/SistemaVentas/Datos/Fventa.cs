using System;
using System.Data;
using System.Data.SqlClient;
using SistemaVentas.Entidades;
using SisVenttas.Datos;

namespace SistemaVentas.Datos
{
    public static class Fventa
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                  

                };
            return FDBHelper.ExecuteDataSet("usp_Data_Fventa_GetAll", dbParams);

        }
        public static int Insertar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@ClienteId", SqlDbType.Int, 0, venta.Cliente.Id),
                    FDBHelper.MakeParam("@FechaVenta", SqlDbType.Date, 0, venta.Fecha_venta),
                    FDBHelper.MakeParam("@NumeroDocumento", SqlDbType.VarChar, 0, venta.Numero_documento),
                    FDBHelper.MakeParam("@TipoDocumento", SqlDbType.VarChar, 0, venta.Tipo_documento),
                    
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fventa_Insertar", dbParams));

        }
        public static int Actualizar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, venta.Id),
                    FDBHelper.MakeParam("@ClienteId", SqlDbType.Int, 0, venta.Cliente.Id),
                    FDBHelper.MakeParam("@FechaVenta", SqlDbType.Date, 0, venta.Fecha_venta),
                    FDBHelper.MakeParam("@NumeroDocumento", SqlDbType.VarChar, 0, venta.Numero_documento),
                    FDBHelper.MakeParam("@TipoDocumento", SqlDbType.VarChar, 0, venta.Tipo_documento),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fventa_Actualizar", dbParams));

        }
        public static int Eliminar(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, venta.Id)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fventa_Eliminar", dbParams));

        }
    }
}
