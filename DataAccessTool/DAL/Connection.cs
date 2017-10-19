using System.Data.OleDb;

namespace DALayer
{
    public class Connection
    {
        #region Propiedades

        public string ConnectionString { get; protected set; }

        public OleDbConnection OleDB_Connection { get; protected set; }

        #endregion

        #region Constructores
        public Connection( )
        {
            //this.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Documents and Settings\\scg\\Desktop\\Ar_Proyect\\HerrmDiag\\bin\\Debug\\ResultsDB.accdb";
            this.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|ResultsDB.accdb";
            //this.ConnectionString =
            //    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alejandro\Desktop\Ar_Proyect\HerrmDiag\bin\Debug\ResultsDB.accdb;Extended Properties=Excel 12.0";
        }
        #endregion

        #region Metodos

        // ADO.NET
        public int Connect()
        {
            this.OleDB_Connection = new OleDbConnection( this.ConnectionString );
            return 0;
        }
        public void Open()
        {
            this.OleDB_Connection.Open();
        }
        public int Disconnect()
        {
            this.OleDB_Connection.Close();
            return 0;
        }
        #endregion

    }
}
