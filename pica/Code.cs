using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace pica
{
    [Serializable]
    public class Code : ISerializable
    {
        public string ActiveCode { get; set; }
        public Code()
        {
            this.ActiveCode = string.Empty;
        }
        public Code( SerializationInfo info, StreamingContext ctxt )
        {
            ActiveCode = (string)info.GetValue( "AccessCode", typeof( string ) );
        }
        public void GetObjectData( SerializationInfo info, StreamingContext context )
        {
            info.AddValue( "AccessCode", ActiveCode );
        }

        public void Save( string path )
        {
            Stream stream = new FileStream( path, FileMode.Create );
            var bformatter = new BinaryFormatter();
            bformatter.Serialize( stream, this );
            stream.Close();
        }
        public static string Load( string path )
        {
            var fi = new FileInfo( path );
            if ( !fi.Exists ) return string.Empty;
            Stream stream=File.Open( path, FileMode.Open );
            var bformatter = new BinaryFormatter();
            Code c;
            try
            { c = (Code) bformatter.Deserialize( stream ); }
            catch(Exception ex)
            { return string.Empty; }
            stream.Close();
            return  c.ActiveCode;
        }

    }
}
 