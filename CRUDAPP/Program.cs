using System;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

SqlConnection sqlConnection;
string connectionstring = @" Data Source = (LocalDB)\MSSQLLocalDB;  Integrated Security = True";
try
{
    sqlConnection = new SqlConnection(connectionstring);
    sqlConnection.Open();
    Console.WriteLine("Connection established Succesfully");
    Console.WriteLine(" Enter your ID ");
#pragma warning disable CS8604 // Possible null reference argument.
    int ID = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
    Console.WriteLine("Enter your Name?");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    String NAME = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.WriteLine("Enter your Father Name?");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string FATHERNAME = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.WriteLine("Enter your AGE");
#pragma warning disable CS8604 // Possible null reference argument.
    int Age = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

    string insertQuery = "INSERT INTO DETAILS(ID,NAME,FATHERNAME,Age) VALUES('" + ID + "', " + NAME + ", " + FATHERNAME + ", "+ Age +" )";
        SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
    insertCommand.ExecuteNonQuery();
    Console.WriteLine("DATA is successfully Inserted");
    sqlConnection.Close();

        }
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
