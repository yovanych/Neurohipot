using System;
using System.Security.Cryptography;
using System.Text;

namespace Encrypting
{
    public static class EncryptionHelper
    {
        private const string cryptoKey = "ernenec#araych@CUBITALABELLA";

        // Vector de inicialización para la rutina de encriptación DES
        private static readonly byte[] IV = new byte[] { 240, 3, 45, 29, 0, 76, 173, 59 };

        /// <summary>
        /// Encripta la cadena proporcionada
        /// </summary>
        public static string Encrypt( string s )
        {
            if ( string.IsNullOrEmpty( s ) ) return string.Empty;


            byte[] buffer = Encoding.ASCII.GetBytes( s );

            var des = new TripleDESCryptoServiceProvider();
            var MD5 = new MD5CryptoServiceProvider();

            des.Key = MD5.ComputeHash( ASCIIEncoding.ASCII.GetBytes( cryptoKey ) );
            des.IV = IV;
            string result = Convert.ToBase64String(
                des.CreateEncryptor().TransformFinalBlock(
                    buffer, 0, buffer.Length ) );
            

            return result;
        }

        /// <summary>
        /// Desencripta la cadena proporcionada
        /// </summary>
        public static string Decrypt( string s )
        {
            if ( string.IsNullOrEmpty( s ) ) return string.Empty;


            byte[] buffer = Convert.FromBase64String( s );

            var des = new TripleDESCryptoServiceProvider();
            var MD5 = new MD5CryptoServiceProvider();

            des.Key = MD5.ComputeHash( ASCIIEncoding.ASCII.GetBytes( cryptoKey ) );
            des.IV = IV;

            string result = Encoding.ASCII.GetString(
                des.CreateDecryptor().TransformFinalBlock(
                    buffer, 0, buffer.Length ) );
            

            return result;
        }
    }
}
