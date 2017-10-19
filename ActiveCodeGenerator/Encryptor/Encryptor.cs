namespace Encrypting
{
    public static class Encryptor
    {
        public static string Encrypt( string s )
        {
            return EncryptionHelper.Encrypt( s );
        }
        public static string Decrypt( string s )
        {
            return EncryptionHelper.Decrypt( s );
        }
    }
    
}
