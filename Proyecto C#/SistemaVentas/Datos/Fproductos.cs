using System.Data;
using System.Data.SqlClient;
using SisVenttas.Datos;
using SistemaVentas.Entidades;
using System;

namespace SistemaVentas.Datos
{
    public class Fproductos
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_Fproductos_GetAll", dbParams);

        }

        public static int Insertar(Producto producto)
        {
           
            SqlParameter[] dbParams = new SqlParameter[]

                {
                    FDBHelper.MakeParam("@CategoriaId", SqlDbType.Int, 0, producto.Categoria.Id),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                    FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, producto.Descripcion),
                    FDBHelper.MakeParam("@Stock", SqlDbType.Decimal, 0, producto.Stock),
                    FDBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, producto.PrecioCompra),
                    FDBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, producto.PrecioVenta),
                    FDBHelper.MakeParam("@FechaVencimiento", SqlDbType.Date, 0, producto.FechaVencimiento),
                    FDBHelper.MakeParam("@Imagen", SqlDbType.Image, 0, producto.Imagen),


                   };

            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fproductos_Insertar", dbParams));

        }
        public static int Actualizar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, producto.Id),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                    FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, producto.Descripcion),
                    FDBHelper.MakeParam("@Stock", SqlDbType.Decimal, 0, producto.Stock),
                    FDBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, producto.PrecioCompra),
                    FDBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, producto.PrecioVenta),
                    FDBHelper.MakeParam("@FechaVencimiento", SqlDbType.Date, 0, producto.FechaVencimiento),
                    FDBHelper.MakeParam("@FechaCreado", SqlDbType.Date, 0, producto.FechaCreado),
                    FDBHelper.MakeParam("@Imagen", SqlDbType.Image, 0, producto.Imagen)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fproductos_Actualizar", dbParams));

        }
        public static int Eliminar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, producto.Id)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fproductos_Eliminar", dbParams));

        }
    }
}
