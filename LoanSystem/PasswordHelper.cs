using System.Security.Cryptography;
using System.Text;

namespace LoanSystem
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hashBuilder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    hashBuilder.Append(b.ToString("x2")); // Convert to hexadecimal
                }
                return hashBuilder.ToString();
            }
        }
    }
}
