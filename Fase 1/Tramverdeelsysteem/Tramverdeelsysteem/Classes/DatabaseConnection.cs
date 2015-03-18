namespace Tramverdeelsysteem.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net.NetworkInformation;
    using System.Data;
    using Oracle.DataAccess.Client;

    public class DatabaseConnection
    {
        private OracleConnection _connection = new OracleConnection();

        public DatabaseConnection()
        {
            Connect();
        }

        /// <summary>
        /// Ping the server and establish a connection
        /// </summary>
        private void Connect()
        {
            this._connection.ConnectionString = Properties.Resources.ConnectionString;//Dit is de connectionstring voor de server, hiervoor dient in Resources een property genaamd "ConnectionString"
            Ping pinger = new Ping();

            PingReply reply = pinger.Send(Properties.Resources.IpAddress);//This is the ipaddress for the server, you need to add a property called "IpAddress" in Resources

            bool pingable = reply.Status == IPStatus.Success; //Check if the server is online

            if (pingable)
            {
                try
                {
                    this._connection.Open();
                }
                catch (OracleException ex)
                {
                    throw new Exception("There is a problem establishing a connection with the database, original error: " + Environment.NewLine + ex.Message);
                }
            }
            else
            {
                throw new Exception("There is a problem establishing a connection with the database, original error: " + Environment.NewLine + ex.Message);
            }
        }

        /// <summary>
        /// Dispose the connection
        /// </summary>
        public void DisposeConnection()
        {
            this._connection.Dispose();
        }

        /// <summary>
        /// This function is used for executing regular select statements
        /// </summary>
        /// <param name="Query">Your sql query</param>
        /// <param name="OPArray">Your OracleParameter array</param>
        /// <returns>Returns the rows, provided by the database</returns>
        public OracleDataReader Select(string Query, OracleParameter[] OPArray)
        {
            OracleCommand Cmd = new OracleCommand();
            OracleDataReader DataR;
            Cmd.Connection = this._connection;
            Cmd.CommandText = Query;

            if (OPArray != null)
            {
                Cmd.Parameters.AddRange(OPArray); //Add parameters to the query, these are filtered for sqlinjection
            }

            try
            {
                DataR = Cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return DataR;
        }

        /// <summary>
        /// This function is used for executing regular sql querys
        /// </summary>
        /// <param name="Query">Your sql query</param>
        /// <param name="OPArray">Your OracleParameter array</param>
        public void ExecuteNonQuery(string Query, OracleParameter[] OPArray)
        {
            OracleCommand Cmd = new OracleCommand();
            Cmd.Connection = this._connection;
            Cmd.CommandText = Query;

            if (OPArray != null)
            {
                Cmd.Parameters.AddRange(OPArray); //Add parameters to the query, these are filtered for sqlinjection
            }

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Cmd.Parameters.Clear();
            Cmd.CommandText = "COMMIT"; //commit changes

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }

        /// <summary>
        /// This function is used for executing Stored procedures or functions
        /// </summary>
        /// <param name="name">Name off the procedure or function</param>
        /// <param name="opArray">Your OracleParameter array</param>
        /// <returns>Returns the rows, provided by the database</returns>
        public OracleCommand StoredProcedureOrFunction(string name, OracleParameter[] opArray)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = this._connection;
            cmd.CommandText = name;
            cmd.CommandType = CommandType.StoredProcedure;

            if (opArray != null)
            {
                cmd.Parameters.AddRange(opArray); //voeg parameters aan de query toe. deze worden op sqlinjectie gefilterd
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cmd;
        }
    }
}
