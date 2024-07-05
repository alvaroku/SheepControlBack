using System.Security.Cryptography;
using System.Text;

namespace Shared
{
    public class Utilities
    {
        public static string CalculateDoseRecomended(string indicatedDose, float weight)
        {
            float quantityVolume = float.Parse(indicatedDose.Split("/")[0].Split("|")[0]);
            string unitVolume = indicatedDose.Split("/")[0].Split("|")[1];

            float quantityWeight = float.Parse(indicatedDose.Split("/")[1].Split("|")[0]);

            float doseRecomended = (weight * quantityVolume) / quantityWeight;

            return doseRecomended + "" + unitVolume;
        }
        public static string GenerateDescriptionForPermission(string controller, string action)
        {
            string description = $"Permiso para el módulo {controller} y la acción {action}";
            return description;
        }
        public static string GenerateKeyForPermission(string controller, string action)
        {
            string clave = $"{controller}_{action}";
            return clave;
        }

        public static string CalcularHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerificarHash(string input, string hash)
        {
            string hashIngresado = CalcularHash(input);
            return hashIngresado == hash;
        }

        public static string GenerateRandomPassword(int length = 8)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
    }
}
