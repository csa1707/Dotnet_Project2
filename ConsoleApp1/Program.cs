// See https://aka.ms/new-console-template for more information
//Edit by new emplyee in night shift

using System.Data;
using System.Data.SqlClient;

class Program
{

    static void Main()
    {

        Console.WriteLine("Hi Ajith , welcome to second project");

        Console.WriteLine("Inserting values into table - vendors");

        var connection = "Data Source= DESKTOP-IURUBDV\\SQLEXPRESS; Initial Catalog=practice;Integrated Security=True";

        var sql = "insert into vendors(eid,vegname,cost) values(@eid,@vegname,@cost)";

        using (SqlConnection conn = new SqlConnection(connection))
        {
            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add("@eid", SqlDbType.Int).Value = 107;
                command.Parameters.Add("@vegname", SqlDbType.VarChar, 10).Value = "pumpkin";
                command.Parameters.Add("@cost", SqlDbType.Int).Value = 38;

                command.ExecuteNonQuery();
            }

            conn.Close();

            Console.WriteLine("Inserting values sucessfully");
        }



        Console.WriteLine("deleting values");

        var sqldelete = "delete from vendors where eid=@eid";

        using (SqlConnection conn = new SqlConnection(connection))
        {
            conn.Open();

            using (SqlCommand command = new SqlCommand(sqldelete, conn))
            {
                command.Parameters.Add("@eid", SqlDbType.Int).Value = 105;             

                command.ExecuteNonQuery();
            }

            conn.Close();

            Console.WriteLine("deleted values sucessfully");
        }


    }



}

//dummy value1 by night shot employe.....logic added...
