using System;
using System.Security.Cryptography;
using System.Text;

namespace hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm alive!");
            Console.ReadKey();

            // define passw
            string pasw = "GeneralReaper666";
            // create md5 hasher
            MD5 md5 = MD5.Create();
            // create byte string from pasw
            byte[] inputBytes = Encoding.ASCII.GetBytes(pasw);
            // create hash from bytes
            byte[] hashedPasw = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hashedPasw.Length; i++)
            {
                sb.Append(hashedPasw[i].ToString("X2"));
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine("754f4789adeac685009905e3a5b9c6ef");

            Console.ReadKey();



        }
    }
}
