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
        public void Initialize()
        {
            server = "host";
            database = "database";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                                "DATABASE=" + database + ";" +
                                "UID=" + uid + ";" +
                                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
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
        public bool CloseConnection()
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
            string myDate = string.Empty;

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

        public List<string>[] GetAppointments(string sDatum, string sMonth)
        {
            //Geeft een lijst terug met een koppeling naar de appointment_status tabel en naar de employees tabel.
            //Het moet een left join zijn, omdat we alle appointments willen zien en anders de lijst ingekort wordt bij een inner join

            string query = string.Empty;
            string myDate = string.Empty;


            if (sDatum == string.Empty && sMonth == string.Empty)
            {
                //Alle appointments weergeven
                query = "SELECT appointments.id, appointments.comment, appointments.licence_plate, appointments.hours, appointments.total_price, date(appointments.created_at) as createdat, " +
                        "appointment_status.status, employees.firstname, employees.lastname FROM appointments " +
                        "Left Join appointment_status ON(appointments.status_id = appointment_status.id) " +
                        "Left Join employees ON(appointments.mechanic_id = employees.id) order by appointments.created_at desc";
            }
            else if (sDatum != string.Empty && sMonth == string.Empty)
            {
                //Zoeken op dag
                query = "SELECT appointments.id, appointments.comment, appointments.licence_plate, appointments.hours, appointments.total_price, date(appointments.created_at) as createdat, " +
                         "appointment_status.status, employees.firstname, employees.lastname FROM appointments " +
                         "Left Join appointment_status ON(appointments.status_id = appointment_status.id) " +
                         "Left Join employees ON(appointments.mechanic_id = employees.id) where appointments.created_at = '" + sDatum + "' order by appointments.created_at desc";
            }
            else if (sMonth != string.Empty) // Toon data voor de eigenaar
            {
                query = "SELECT appointments.id, appointments.comment, appointments.licence_plate, appointments.hours, appointments.total_price, date(appointments.created_at) as createdat, " +
                        "appointment_status.status, employees.firstname, employees.lastname FROM appointments " +
                        "Left Join appointment_status ON(appointments.status_id = appointment_status.id) " +
                        "Left Join employees ON(appointments.mechanic_id = employees.id) where Month(appointments.created_at) = " + sMonth + 
                        " and  Year(appointments.created_at) = " + DateTime.Now.Year + " order by appointments.created_at desc";
            }
            //Create a list to store the result
            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();


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
                    myDate = dataReader["createdat"] + "";
                    if (!string.IsNullOrEmpty(myDate))
                    {
                        DateTime objDate = DateTime.Parse(myDate);
                        myDate = objDate.Day + "-" + objDate.Month + "-" + objDate.Year;
                    }
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["comment"] + "");
                    list[2].Add(dataReader["licence_plate"] + "");
                    list[3].Add(dataReader["hours"] + "");
                    list[4].Add(dataReader["total_price"] + "");
                    list[5].Add(myDate); //dataReader["createdat"] + "");
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
        public List<string>[] GetParts(string AppointmentID)
        {
            string query = string.Empty;


                query = "SELECT appointment_part.part_id, parts.name, appointment_part.price_per_piece, amount FROM appointment_part left join parts on (appointment_part.part_id = parts.id) " + 
                        "where appointment_part.appointment_id = '" + AppointmentID + "'";

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
                    list[0].Add(dataReader["part_id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["price_per_piece"] + "");
                    list[3].Add(dataReader["amount"] + "");
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

        public void UpdateStatusMonteurOpmerking(string Status, string Monteur, string Opmerking, int id)
        {
            string query = string.Empty;

            
            Opmerking = Opmerking.Replace("'", "''");
            
            List<string>[] myList = ReturnList("SELECT id FROM appointment_status where status = '" + Status + "' order by status asc", "id");
            string[] row1 = new string[] { myList[0][0].ToString() };

            List<string>[] myList1 = ReturnList("SELECT id FROM employees where (firstname + ' ' + lastname) = '" + Monteur + "'", "id");
            string[] row2 = new string[] { myList1[0][0].ToString() };

            if (Monteur != string.Empty)
            {
                query = "UPDATE appointments SET status_id = " + row1[0] + ", mechanic_id = '" + row2[0] + "', comment = '" + Opmerking + "' where id = " + id;
            }
            else
            {
                query = "UPDATE appointments SET status_id = " + row1[0] + ", comment = '" + Opmerking + "' where id = " + id;
            }
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

        public void ExecuteSQL(string SQL)
        {
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = SQL;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        public List<string>[] GetPartsIDAndPrice(string PartsName)
        {
            string query = string.Empty;


            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("select id, price from parts where name = '" + PartsName + "'", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["price"] + "");
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

        public List<string>[] ReturnList(string SQL, string ReturnField)
        {

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader[ReturnField] + "");
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
        public List<string>[] GetMonthlyRevenueAndHours(string SQL, string Omzet, string Uren)
        {


            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader[Omzet] + "");
                    list[1].Add(dataReader[Uren] + "");
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
