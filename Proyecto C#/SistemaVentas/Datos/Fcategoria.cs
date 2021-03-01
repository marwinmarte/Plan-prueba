using System.Data;
using System.Data.SqlClient;
using SisVenttas.Datos;
using SistemaVentas.Entidades;
using System;

namespace SistemaVentas.Datos
{
    public class Fcategoria
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_Fcategoria_GetAll", dbParams);

        }
        public static int Insertar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fcategoria_Insertar", dbParams));

        }
        public static int Actualizar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, categoria.Id),
                    FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fcategoria_Actualizar", dbParams));

        }
        public static int Eliminar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.VarChar, 0, categoria.Id)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_Fcategoria_Eliminar", dbParams));

        }
    }
}
