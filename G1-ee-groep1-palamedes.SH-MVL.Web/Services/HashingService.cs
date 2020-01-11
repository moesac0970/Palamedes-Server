using System.Security.Cryptography;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Services
{
    public class HashingService
    {
        /// <summary>
        /// service for hasing which accepts a string and returns a hashed(md5) string @sepp
        /// </summary>
        /// <param name="pasw"></param>
        /// <returns></returns>
        public string Hasher(string pasw)
        {
            // create md5 hasher
            MD5 md5 = MD5.Create();
            // create byte string from pasw
            byte[] inputBytes = Encoding.ASCII.GetBytes(pasw);
            // create hash from bytes
            byte[] hashedPasw = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashedPasw.Length; i++)
            {
                sb.Append(hashedPasw[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
