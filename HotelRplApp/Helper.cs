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
            SqlConnection conn = new SqlConnection("Server=DESKTOP-89MUICP;initial catalog=DB_HOTEL_RPL;integrated security=true;");
            return conn;
        }
    }
}
