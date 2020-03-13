using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace SafeLife.Lib
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            //server = "br502.hostgator.com.br";
            //database = "dracc937_safelife";
            //uid = "dracc937_root";
            //password = "ZgA%5e}.Nf+z";
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connectionString = "Database=safel547_safelife;Data Source=br658.hostgator.com.br;User Id=safel547_admin;Password=]5kKf2~q9rc];";

            connection = new MySqlConnection(connectionString);
            //OpenConnection();
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception(ex.ErrorCode.ToString());
                    //MessageBox.Show("Cannot connect to server.  Contact administrator");

                    case 1045:
                        throw new Exception(ex.ErrorCode.ToString());
                    //MessageBox.Show("Invalid username/password, please try again");
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ErrorCode.ToString());
                //MessageBox.Show(ex.Message);
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //open connection
            OpenConnection();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            CloseConnection();

        }

        public void Insert(string sql, IDictionary<string, object> values)
        {
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                OpenConnection();
                cmd.CommandText = sql;

                foreach (var item in values)
                {
                    object value = Convert.ToString(item.Value) == string.Empty || Convert.ToString(item.Value).ToUpper() == "NULL" ? (object)DBNull.Value : item.Value.ToString();

                    DateTime t;
                    Boolean b;
                    Double d;
                    if (Double.TryParse(Convert.ToString(value), out d))
                    {
                        value = item.Value;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.Double;
                        cmd.Parameters.Add(param);
                    }
                    else if (DateTime.TryParse(Convert.ToString(value), out t))
                    {
                        if (Convert.ToDateTime(value).Ticks == 0)
                            value = (object)DBNull.Value;
                        else
                            value = item.Value;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.DateTime;
                        cmd.Parameters.Add(param);
                    }
                    else if (Boolean.TryParse(Convert.ToString(value), out b))
                    {
                        value = b == false ? 0 : 1;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.Boolean;
                        cmd.Parameters.Add(param);
                    }
                    else
                        cmd.Parameters.AddWithValue("@" + item.Key, value);
                }


                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        //Update statement
        public void Update(string query)
        {

            //Open connection
            OpenConnection();

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            CloseConnection();

        }
        public void Command(string sql, IDictionary<string, object> values)
        {

            using (MySqlCommand cmd = connection.CreateCommand())
            {
                OpenConnection();
                cmd.CommandText = sql;

                foreach (var item in values)
                {
                    object value = Convert.ToString(item.Value) == string.Empty || Convert.ToString(item.Value).ToUpper() == "NULL" ? (object)DBNull.Value : item.Value.ToString();

                    DateTime t;
                    Boolean b;
                    Double d;
                    if (Double.TryParse(Convert.ToString(value), out d))
                    {
                        value = item.Value;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.Double;
                        cmd.Parameters.Add(param);
                    }
                    else if (DateTime.TryParse(Convert.ToString(value), out t))
                    {
                        if (Convert.ToDateTime(value).Ticks == 0)
                            value = (object)DBNull.Value;
                        else
                            value = item.Value;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.DateTime;
                        cmd.Parameters.Add(param);
                    }
                    else if (Boolean.TryParse(Convert.ToString(value), out b))
                    {
                        value = b == false ? 0 : 1;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.Boolean;
                        cmd.Parameters.Add(param);
                    }
                    else
                        cmd.Parameters.AddWithValue("@" + item.Key, value);
                }


                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        //Delete statement
        //public void Delete(string query)
        //{
        //    OpenConnection();
        //    MySqlCommand cmd = new MySqlCommand(query, connection);
        //    cmd.ExecuteNonQuery();
        //    CloseConnection();
        //}

        //public DataTable select(string sql)
        //{
        //    DataTable dt = new DataTable();
        //    if (this.OpenConnection())
        //    {
        //        try
        //        {
        //            MySqlDataAdapter da = new MySqlDataAdapter(sql, connectionString);
        //            da.SelectCommand.CommandTimeout = TimeSpan.FromMinutes(120).Seconds;
        //            da.Fill(dt);
        //        }
        //        catch
        //        {
        //            MySqlDataAdapter da = new MySqlDataAdapter(sql, connectionString);
        //            da.Fill(dt);
        //        }

        //    }
        //    this.CloseConnection();
        //    return dt;
        //}

        public DataTable Select(string sql)
        {
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                OpenConnection();
                cmd.CommandText = sql;

                DataTable table = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                    CloseConnection();
                    return table;
                }

            }
        }
        public DataTable Select(string sql, IDictionary<string, object> values)
        {
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                OpenConnection();
                cmd.CommandText = sql;

                foreach (var item in values)
                {
                    object value = Convert.ToString(item.Value) == string.Empty || Convert.ToString(item.Value).ToUpper() == "NULL" ? (object)DBNull.Value : item.Value.ToString();

                    DateTime t;
                    if (DateTime.TryParse(Convert.ToString(value), out t))
                    {
                        if (Convert.ToDateTime(value).Ticks == 0)
                            value = (object)DBNull.Value;
                        else
                            value = item.Value;
                        MySqlParameter param = new MySqlParameter(item.Key, value);
                        param.DbType = DbType.DateTime;
                        cmd.Parameters.Add(param);
                    }
                    else
                        cmd.Parameters.AddWithValue("@" + item.Key, value);
                }

                DataTable table = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                    CloseConnection();
                    return table;
                }
            }
        }

        ////Count statement
        //public int Count(string query)
        //{
        //    int Count = -1;

        //    //Open Connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //Create Mysql Command
        //        MySqlCommand cmd = new MySqlCommand(query, connection);

        //        //ExecuteScalar will return one value
        //        Count = int.Parse(cmd.ExecuteScalar() + "");

        //        //close Connection
        //        this.CloseConnection();

        //        return Count;
        //    }
        //    else
        //    {
        //        return Count;
        //    }
        //}

        ////Backup
        //public void Backup()
        //{
        //    try
        //    {
        //        DateTime Time = DateTime.Now;
        //        int year = Time.Year;
        //        int month = Time.Month;
        //        int day = Time.Day;
        //        int hour = Time.Hour;
        //        int minute = Time.Minute;
        //        int second = Time.Second;
        //        int millisecond = Time.Millisecond;

        //        //Save file to C:\ with the current date as a filename
        //        string path;
        //        path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
        //        StreamWriter file = new StreamWriter(path);


        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysqldump";
        //        psi.RedirectStandardInput = false;
        //        psi.RedirectStandardOutput = true;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
        //        psi.UseShellExecute = false;

        //        Process process = Process.Start(psi);

        //        string output;
        //        output = process.StandardOutput.ReadToEnd();
        //        file.WriteLine(output);
        //        process.WaitForExit();
        //        file.Close();
        //        process.Close();
        //    }
        //    catch
        //    {
        //    }
        //}

        ////Restore
        //public void Restore()
        //{
        //    try
        //    {
        //        //Read file from C:\
        //        string path;
        //        path = "C:\\MySqlBackup.sql";
        //        StreamReader file = new StreamReader(path);
        //        string input = file.ReadToEnd();
        //        file.Close();


        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysql";
        //        psi.RedirectStandardInput = true;
        //        psi.RedirectStandardOutput = false;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
        //        psi.UseShellExecute = false;


        //        Process process = Process.Start(psi);
        //        process.StandardInput.WriteLine(input);
        //        process.StandardInput.Close();
        //        process.WaitForExit();
        //        process.Close();
        //    }
        //    catch
        //    {
        //    }
        //}
    }
}
