using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ABCDMallClient.Handle
{
    public class DBHandleDAO
    {
        public string _strConn = "Data Source=localhost:1521/db11g;User ID=ABCD_Mall;Password=sa123;pooling=false;";

        public DataTable GetData_Dish(int p_typeCust)
        {
            try
            {
                DataTable dt = new DataTable();
                using (OracleConnection connection = new OracleConnection(_strConn))
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand(Constants.spmyDishGet, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    var arrParam = new OracleParameter[2];
                    arrParam[0] = new OracleParameter("p_typeCust", OracleDbType.Int32) { Direction = ParameterDirection.Input, Value = p_typeCust };
                    arrParam[1] = new OracleParameter("rs", OracleDbType.RefCursor) { Direction = ParameterDirection.Output, Value = DBNull.Value };

                    foreach (OracleParameter item in arrParam)
                    {
                        command.Parameters.Add(item);
                    }
                    command.ExecuteNonQuery();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    { adapter.Fill(dt); }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
