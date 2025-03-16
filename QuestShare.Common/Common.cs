using System.Text;

namespace QuestShare.Common
{
    public class Constants
    {
        public static readonly string Version = "1";
    }

    public static class StringExtensions
    {
        public static string ToBase64(this string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }
        public static string FromBase64(this string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        public static string ToSHA256(this string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            // 10 reps of SHA256
            for (var i = 0; i < 10; i++)
                bytes = System.Security.Cryptography.SHA256.HashData(bytes);
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        public static string SaltedHash(this string str, string salt)
        {
            return (str + salt).ToSHA256();
        }
    }
}
