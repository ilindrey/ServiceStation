using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStation
{
    internal static class SHA256
    {
        // SHA256
        internal static string Hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToUpper();
        }
    }
}
