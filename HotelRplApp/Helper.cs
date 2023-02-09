using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace HotelRplApp
{
    class Helper
    {
        public static SqlConnection getConnected()
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-89MUICP;initial catalog=DB_HOTEL_RPL;integrated security=true;");
            return conn;
        }

        public static string hashPassword(String pass)
        {
            using (var algorithm = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(pass);
                var hash = algorithm.ComputeHash(bytes);

                StringBuilder hashedPass = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    hashedPass.Append(hash[i].ToString("X2"));
                }
                
                return hashedPass.ToString();
            }
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
