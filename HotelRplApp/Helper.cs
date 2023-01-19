using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelRplApp
{
    class Helper
    {
        public static SqlConnection getConnected()
        {
            SqlConnection conn = new SqlConnection("Server=WIN-8OCI4IO48IN;initial catalog=DB_HOTEL_RPL;integrated security=true;");
            return conn;
        }

        public static string generateBookingCode()
        {
            StringBuilder code = new StringBuilder();
            Random random = new Random();

            char letter;

            int length = 6;
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                code.Append(letter);
            }

            return code.ToString();
        }
    }
}
