using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HotelRPLApp3
{
    public class Helper
    {
        public static SqlConnection getConnected()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-89MUICP\\LKSITSOFTWARE;Initial Catalog=DB_HOTEL_RPL_2;Integrated Security=true;"); ;
            return conn;
        }

        public static string hashPassToSHA256(string pass)
        {
            SHA256 sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(pass);
            byte[] hash = sha256.ComputeHash(bytes);

            StringBuilder newPass = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                newPass.Append(hash[i].ToString("X2"));
            }
            return newPass.ToString();
        }

        public static string getBookingCode()
        {
            StringBuilder code = new StringBuilder();
            Random random = new Random();
            char letter;

            int length = 6;
            for (int i = 0; i < length; i++)
            {
                double num = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(num * 25));
                letter = Convert.ToChar(shift + 65);
                code.Append(letter);
            }

            return code.ToString();
        }
    }
}
