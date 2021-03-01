using System.Data;
using System.Data.SqlClient;
using SisVenttas.Datos;
using SistemaVentas.Entidades;
using System;
namespace SistemaVentas.Datos
{
    public class Flogin
    {
        public static DataSet Validar_login(string sUsuario, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUsuario),
                    FDBHelper.MakeParam("@Contraseña", SqlDbType.VarChar, 0, sPassword)
                };
            return FDBHelper.ExecuteDataSet("usp_Data_Flogin_Validar_login", dbParams);

        }
    }
}
