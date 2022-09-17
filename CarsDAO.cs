using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using model;   // accessig the car Class
using System.Data.SqlClient;    // this is module is needed for SqlConnection, SqlCommand
using System.Data;              // this is needed to access the SqlDbType
namespace AssignmentNicoloRossi
{
    internal class CarsDAO
    {
        // creating the connection that will be initialized in constructor with the connection string as param
        private SqlConnection connection;



        public CarsDAO()
        {
            connection = new SqlConnection()
            {
                ConnectionString = "Data Source=.;Initial Catalog=Hire;Integrated Security=True"
            };
        }


        //this method will be used to retrieve all data from the table and return a list of Car objects
        public List<Car> SelectAll(out string error) {

            List<Car> CarList = new List<Car>();
            String sql = "SELECT * FROM tblCar";
            error = String.Empty;

            SqlCommand cmd = new SqlCommand(sql, connection);
            // Try to open connection and get all data using the SQL command object and the SQL DataReader
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // loop through the reader (that contains table data) row by row to populate
                // the list with Car objects
                    while(reader.Read())
                    {
                    Car CarFromTable = new Car()
                    {
                        VehicleRegNo = reader["VehicleRegNo"].ToString(),
                        Make = reader["Make"].ToString(),
                        EngineSize = reader["EngineSize"].ToString(),
                        DateRegistered = (DateTime)reader["DateRegistered"],
                        RentalPerDay = (decimal)reader["RentalPerDay"],
                        Available = (bool)reader["Available"]
                    };

                    CarList.Add(CarFromTable);
                }
                   
            }
            // catching exception and adding some details based on the type of error
            // if related to SQL informing user that can't connect to DB
            catch (SqlException ex1)
            {
                Console.WriteLine(ex1.Message);
                error += "Error connecting with the database\n";
            }
            // in case of error not related to database user is informed to contact support
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                error += "Error with the program please contact tech support";

            }

            finally
            {
                connection.Close();
            }

            return CarList;
        }


        // this method perform a non query on the table, if successuful returns true.
        // It accept a string containing the command and returns a string containing errors
        // As non-mandatory parameters it takes a car and string as car registration number
        // these are non mandatories as in case of DELETE query they are not necessary
        public bool PerformNonQuery(string query, out string error, Car car = null, String RegNum = null)
        {
            // following strings contain SQL commands 
            string InsertQuery = "INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available)" +
            " VALUES (@vehicleRegNo, @make, @engineSize, @dateRegistered, @rentalPerDay, @available)";

            string UpdateQuery = "UPDATE tblCar SET Make = @make, EngineSize = @engineSize, " +
            "DateRegistered = @dateRegistered, RentalPerDay = @rentalPerDay, Available = @available " +
            "WHERE VehicleRegNo = @vehicleRegNo";

            string DeleteQuery = "DELETE FROM tblCar WHERE VehicleRegNo = @vehicleRegNo";

            bool result = false;

            error = "";

            string sql = "";

            // this if statement will decide which type of query to assing to the SqlCommand
            if (query.ToLower().Equals("delete"))
            {
                sql = DeleteQuery;
            }
            else if (query.ToLower().Equals("update"))
            {
                sql = UpdateQuery;
            }
            else if (query.ToLower().Equals("insert"))
            {
                sql = InsertQuery;
            }
            else
            {
                error += "The query parameter for method PerformNonQuery is wrong";
            }


            SqlCommand cmd = new SqlCommand(sql, connection);

            //checking if it is a Delete query because then only one parameter is needed and no Car object
            if (query.ToLower().Equals("delete"))
            {
                sql = DeleteQuery;
                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@vehicleRegNo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = RegNum
                    });
            }
            //if it is another type of query (Insert or Update) it can continue with creation of all parameters

            else
            {
 

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@make",
                        SqlDbType = SqlDbType.VarChar,
                        Value = car.Make,
                    });

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@engineSize",
                        SqlDbType = SqlDbType.VarChar,
                        Value = car.EngineSize
                    });

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@dateRegistered",
                        Value = car.DateRegistered,
                        SqlDbType = SqlDbType.DateTime,
                    });

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@rentalPerDay",
                        DbType = DbType.Decimal,
                        Value = car.RentalPerDay
                    });

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@available",
                        SqlDbType = SqlDbType.Bit,
                        Value = car.Available
                    });

                cmd.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@vehicleRegNo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = car.VehicleRegNo
                    });
            }


            // the next part try to establish connction and perform the SQL command
            try
            {
                connection.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    result = true;
                } 
                else
                {
                    error += "No rows in database were affected. Verify that all information required are present" +
                        " and verify their value is correct." +
                        "\n\n Ex: Registration Number";
                    result = false;
                }
                

            }
            // catching exception and adding some details based on the type of error
            // if related to SQL informing user that can't connect to DB
            catch (SqlException ex1)
            {
                Console.WriteLine(ex1.Message);
 
                error += $"Error connecting with the database\n";
                if (ex1.Message.Contains("duplicate"))
                {
                    error += "\nThe primary key (Reg. No) already exists in Database";
                }
            }
            // in case of error not related to database user is informed to contact support
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                error += "Error with the program please contact tech support";

            }
            finally
            {
                connection.Close();

            }
            return result;
        }


        // this method run a research on database based on parameters and return DataSet and a boolean
        public DataSet Search(string column, string logicOperator, string value, out bool success)
        {
            DataSet ds = new DataSet();
            success = false;
            string sql = $"SELECT * FROM tblCar WHERE {column} {logicOperator} '{value}'";
            Console.WriteLine(sql);
            SqlCommand cmd = new SqlCommand(sql, connection);

            try
            {

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds, "Data Result");

                success = true;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);

            }
            finally 
            { 

                connection?.Close(); 

            }

            return ds;
        }
    }
}
