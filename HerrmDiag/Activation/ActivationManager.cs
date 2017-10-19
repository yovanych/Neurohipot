using System;
using System.Linq;
using System.Management;
using BusinessObjects;
using Encrypting;
using HerrmDiag.Properties;

namespace HerrmDiag.Activation
{
    /// <summary>
    /// La generación de los puntos a evaluar en la función será siempre de la siguiente forma:
    /// p = 1:(K+2)*7:N
    /// N de escoge hasta completar 6 puntos
    /// </summary>
    internal class ActivationManager
    {
        #region Generation Code
        private const string staticPatern = "CINTURA";
        
        public static string GenerationCode()
        {
            //OperationsLog.ClearLog();
            //OperationsLog.LogOperation( "Begin" );
            int[] serial = AscciMBSerialNumber() ?? AscciHDSerialNumber();
            //OperationsLog.LogOperation( "ASCCI - Done" );
            string P1 = string.Empty;
            if ( serial != null )
            {
                for ( int i = 0; i < serial.Length - 1; i++ )
                    P1 += string.Format( "{0}-", serial[i] );
                P1 += serial[serial.Length - 1].ToString();
                //OperationsLog.LogOperation( "MB Serial not null" );
            }
            else
            {
                //OperationsLog.LogOperation( "Returned null serial number" );
                return string.Empty;
            }
            int K = GetKCode(serial[0]);
            //OperationsLog.LogOperation( "KCode - Done" );
            string P2 = staticPatern[K].ToString();
            int[] puntos = PuntosDeEvaluacion( K );
            //OperationsLog.LogOperation( "Evaluation Point - Done" );
            string P3 = string.Empty;
            for ( int i = 0; i < puntos.Length - 1; i++ )
                P3 += string.Format( "{0}-", puntos[i] );
            P3 += puntos[puntos.Length - 1].ToString();
            string str_serial = string.Format( "{0}:{1}[{2}]", P1, P2, P3 );
            //OperationsLog.LogOperation( str_serial );
            //OperationsLog.LogOperation( "End" );
            return str_serial;
        }
        
        #region Private
        private static int[] AscciMBSerialNumber()
        {
            ManagementObjectSearcher mbs = null;
            try
            {
                mbs = new ManagementObjectSearcher( "Select SerialNumber from Win32_BaseBoard" );
            }
            catch(Exception ex)
            {
                //OperationsLog.LogOperation( string.Format( "Getting MB Serial: {0}", ex.Message ) );
                return null;
            }
            string snl = string.Empty;

            try
            {
                foreach ( ManagementObject mo in mbs.Get() )
                {
                    string sn = mo["SerialNumber"].ToString().Trim( ' ' );
                    if ( string.IsNullOrEmpty( sn ) )
                    {
                        //OperationsLog.LogOperation( "S.N. Null or Empty" );
                        continue;
                    }
                    string[] ls = sn.Split( ' ' );
                    snl = ls.Aggregate( snl, ( current, s ) => current + s );
                    var codes = snl.Select( c => (int) c ).ToList();
                    //OperationsLog.LogOperation( "MB - OK" );
                    return codes.ToArray();
                }
            }
            catch {}
            return null;
        }
        private static int[] AscciHDSerialNumber()
        {
            ManagementObjectSearcher mbs;
            try
            {
                mbs = new ManagementObjectSearcher( "Select SerialNumber from Win32_DiskDrive" );
                string snl = string.Empty;

                foreach ( ManagementObject mo in mbs.Get() )
                {
                    string sn = mo["SerialNumber"].ToString().Trim( ' ' );
                    if ( string.IsNullOrEmpty( sn ) )
                    {
                        //OperationsLog.LogOperation( "S.N. Null or Empty" );
                        continue;
                    }
                    string[] ls = sn.Split( ' ' );
                    snl = ls.Aggregate( snl, ( current, s ) => current + s );
                    var codes = snl.Select( c => (int)c ).ToList();
                    //OperationsLog.LogOperation( "HD - OK" );
                    return codes.ToArray();
                }
            }
            catch {}
            return null;
        }
        private static int GetKCode(int serial)
        {
            return  serial % staticPatern.Length;
        }
        private static int[] PuntosDeEvaluacion( int K )
        {
            var puntos = new int[6];
            puntos[0] = 1;
            for ( int i = 1; i < 6; i++ )
                puntos[i] = i * ( K + 2 ) * 7;
            return puntos;
        }
        #endregion
        #endregion

        #region Activation Code
        //public static string ActivationCode()
        //{
        //    return Encryptor.Decrypt( Resources.FILE_ActKey );
        //}
        #endregion

        public static bool Evaluate(string generationCode, string activationCode )
        {
            return generationCode == activationCode;
        }

    }
}
