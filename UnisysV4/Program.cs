using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UnisysV4
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\Jonathan\\source\\repos\\UnisysV4\\UnisysV4\\Routines.mdf" + ";Integrated Security=True");
            cn.Open();
            int Id;
            String Name;
            Boolean Active;
            Console.WriteLine("Enter routine id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter routine name: ");
            Name = Console.ReadLine();
            Console.WriteLine("To active routine enter ''T'', to deactive routine enter ''F'' ");
            Active = Boolean.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into Jobs values('" + Id + "','" + Name + "','" + Active + "')", cn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Insertion successfull");
            }

                cn.Close();
        }
    }
}
