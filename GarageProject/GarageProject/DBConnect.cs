using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GarageProject
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }


        //Initialize values
        private void Initialize()
        {
            //ok
            //server = "192.67.198.61";
            server = "web0098.zxcs.nl";
            database = "u71481p69034_garage";
            uid = "u71481p69034_garage";
            password = "C3Zagza3R";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                                "DATABASE=" + database + ";" +
                                "UID=" + uid + ";" +
                                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        //Select statement
        public List<string>[] SelectPartijen()
        {
            string query = "SELECT naam FROM Partijen";

            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["naam"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement
        public List<string>[] LoginPerson(string Email, string Wachtwoord)
        {
            string query = "SELECT A1.email, A1.password, A2.role FROM employees A1 left outer join employee_roles A2 on (A1.role_id = A2.id) " +
               "where A1.email = '" + Email + "'";
            

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Email"] + "");
                    list[1].Add(dataReader["Password"] + "");
                    list[2].Add(dataReader["Role"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] GetEmployees()
        {
            string query = "SELECT employees.id, employees.firstname, employees.lastname, employee_roles.role FROM employees " + 
                           "Left Join employee_roles on (employees.role_id = employee_roles.id) where employee_roles.role = 'monteur'";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["firstname"] + "");
                    list[2].Add(dataReader["lastname"] + "");
                    list[3].Add(dataReader["role"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] GetAppointments(string sDatum)
        {
            string query = string.Empty;
            string dt = sDatum.ToString();

            
            if (sDatum == string.Empty)
            {
                 query = "SELECT appointments.*, appointment_status.status, employees.firstname, employees.lastname FROM appointments " +
                         "Left Join appointment_status ON(appointments.status_id = appointment_status.id) " + 
                         "Left Join employees ON(appointments.mechanic_id = employees.id) order by created_at desc";
            }
            else
            {
                query = "SELECT appointments.*, appointment_status.status, employees.firstname, employees.lastname FROM appointments " +
                         "Left Join appointment_status ON(appointments.status_id = appointment_status.id) " +
                         "Left Join employees ON(appointments.mechanic_id = employees.id) where created_at = '" + sDatum + "' order by created_at desc";
            }
            //Create a list to store the result
            List<string>[] list = new List<string>[14];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["comment"] + "");
                    list[2].Add(dataReader["licence_plate"] + "");
                    list[3].Add(dataReader["hours"] + "");
                    list[4].Add(dataReader["total_price"] + "");
                    list[5].Add(dataReader["created_at"] + "");
                    list[6].Add(dataReader["status"] + "");
                    list[7].Add(dataReader["firstname"] + "");
                    list[8].Add(dataReader["lastname"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        public void UpdateReceptionist(string Status, string Monteur, string Opmerking, int id)
        {
            List<string>[] myList = GetStatusID(Status);
            string[] row1 = new string[] { myList[0][0].ToString() };

            List<string>[] myList1 = GetMonteurID(Monteur);
            string[] row2 = new string[] { myList1[0][0].ToString() };

            string query = "UPDATE appointments SET status_id = " + row1[0] + ", mechanic_id = '" + row2[0] + "', comment = '" + Opmerking + "' where id = " + id;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public List<string>[] GetStatus()
        {
            string query = string.Empty;


                query = "SELECT status FROM appointment_status order by status asc";

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["status"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<string>[] GetStatusID(string Status)
        {
            string query = string.Empty;


            query = "SELECT id FROM appointment_status where status = '" + Status + "' order by status asc";

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<string>[] GetMonteurID(string Monteur)
        {
            string query = string.Empty;

            query = "SELECT id FROM employees where (firstname + ' ' + lastname) = '" + Monteur + "'";

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

    }
}
