using System;
using System.Security.Cryptography;
using System.Text;

namespace example.Core
{
    public class Hasher
    {
        public string GetHashString(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            StringBuilder hash = new StringBuilder();

            foreach (byte b in byteHash)
                hash.Append(string.Format("{0:x2}", b));

            return hash.ToString();
        }

        public string GetSalt ()
        {
            return Guid.NewGuid().ToString();
        }
    }
}