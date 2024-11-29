using System.Collections.Generic;
using System.Security.Cryptography;

namespace LZWAlgorithms
{
    public static class ExtensionMethods
    {
        public static byte[] GetBytes(this string str)
        {
            List<byte> bytes = new List<byte>();
            foreach (char c in str) bytes.Add((byte)c);
            return bytes.ToArray();
        }

        public static byte[] CreateSHA256(this string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] inputBytes = input.GetBytes();
                byte[] hashBytes = sha.ComputeHash(inputBytes);
                return hashBytes;
            }
        }
    }

}
