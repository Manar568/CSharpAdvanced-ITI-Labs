using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class PublishingDAL
    {

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public PublishingDAL() { 
        
        string connectionString = "Server=DESKTOP-NQ7JL3H;Database=pubs;Integrated Security=True;Encrypt=false";
        
    sqlConnection= new (connectionString);
    sqlCommand = new ("", sqlConnection);

        }


        public int ExecuteNonQuery(string sqlStatement) // insert update delete
        {
            sqlCommand.CommandText = sqlStatement;
            //sqlCommand.Parameters.AddWithValue("p1", 7);
            if (sqlConnection.State is not ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowsAffected;
        }

        public DataTable GetAllAuthors(string sqlStatement) { 
        
        sqlCommand.CommandText= sqlStatement;
        SqlDataAdapter sqlDataAdapter = new(sqlCommand);
            DataTable dt = new();
            sqlDataAdapter.Fill(dt);
            return dt;



        }




        /*string connectionString = "Server = DESKTOP-VDOJTM6\\SQLEXPRESS; Database = MyCompany; Integrated Security = true; Encrypt = false;";

        sqlConnection = new (connectionString);
            sqlCommand = new ("", sqlConnection);
        }
        SqlConnection sqlConnection;

        SqlCommand sqlCommand;
        public int ExecuteNonQuery(string sqlStatement) // insert update delete
        {
            sqlCommand.CommandText = sqlStatement;

            //sqlCommand.Parameters.AddWithValue("p1", 7);

            if (sqlConnection.State is not ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowsAffected;
        }

        public DataTable GetAll(string sqlQuery) // select disconnected mode only
        {
            sqlCommand.CommandText = sqlQuery;
            SqlDataAdapter sqlDataAdapter = new(sqlCommand);

            DataTable dt = new();

            sqlDataAdapter.Fill(dt);

            return dt;
        }
    }*/



    }
}
