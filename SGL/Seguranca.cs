using System;
using System.Security.Cryptography;

namespace SGL
{
    public static class Seguranca
    {
        public static string GerarHash(string senha)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000))
            {
                hash = pbkdf2.GetBytes(32);
            }
            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool Verificar(string senha, string armazenado)
        {
            if (string.IsNullOrEmpty(armazenado) || !armazenado.Contains(":")) return false;

            string[] partes = armazenado.Split(':');
            byte[] salt = Convert.FromBase64String(partes[0]);
            byte[] hashEsperado = Convert.FromBase64String(partes[1]);

            byte[] hashCalculado;
            using (var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000))
            {
                hashCalculado = pbkdf2.GetBytes(32);
            }

            int diferenca = 0;
            for (int i = 0; i < hashEsperado.Length; i++)
                diferenca |= hashEsperado[i] ^ hashCalculado[i];
            return diferenca == 0;
        }
    }
}