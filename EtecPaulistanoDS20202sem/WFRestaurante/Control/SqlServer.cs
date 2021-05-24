using System;
using System.Data;
using System.Data.SqlClient;
using WFRestaurante.Properties;

namespace WFRestaurante.Control
{
    public class SqlServer
    {
        private SqlConnection sqlConnection;

        public void Executar(String comando, SqlParameterCollection sqlParameterCollection)
        {
            SqlCommand sqlCommand = ComandoSql(comando);
            foreach (SqlParameter sqlParameter in sqlParameterCollection)
            {
                sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
            }
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            

        } 
        public DataTable Consultar(String comando, CommandType commandType, SqlParameter sqlParameter)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = ComandoSql(comando);
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandText = comando;
            sqlCommand.Parameters.Add(sqlParameter);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable); // .Fill() Esse método busca no Banco as informações e adapta dentro do DataTable
            return dataTable;
        }

        private SqlCommand ComandoSql(String comando)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Settings.Default.stringConnection;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 1800;
            sqlCommand.CommandText = comando;
            return sqlCommand;
        }



    }
}
