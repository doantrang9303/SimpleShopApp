using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataProvider
    {
        public DataProvider() { }
        private string ConnectionString { get; set; } = string.Empty;
        public DataProvider(string connectionString) { ConnectionString = connectionString; }
        public void CloseConnection(SqlConnection sqlConnection) { sqlConnection.Close(); }
        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType
            , ParameterDirection direction = ParameterDirection.Input)
        {

            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = direction,
            };
        }

        //------------------------------------------------------------------------------------------
        public IDataReader GetDataReader(string commandText, CommandType commandType, out SqlConnection connection,
            params SqlParameter[] parameters)
        {
            IDataReader? reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        //--------------------------------------------------------------------------------------------
        public void Delete(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Data provider : Delete Method", ex.InnerException);
            }
        }

        //---------------------------------------------------------------------------------------
        public void Insert (string commandText,CommandType commandType, SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if(parameters != null)
                {
                    foreach(var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------
        public void Update(string commandText,CommandType commandType, SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
