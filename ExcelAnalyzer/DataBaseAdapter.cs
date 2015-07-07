using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAnalyzer
{
    public class DataBaseAdapter
    {
        public static string _path = "";
        private static string _connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _path + ";Extended Properties=Excel 12.0";
        private OleDbConnection con;
        private OleDbCommand _command;
        private OleDbDataReader _reader;
        private string _table;

        public DataBaseAdapter(string path)
        {
            _path = path;
            _connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _path + ";Extended Properties=Excel 12.0";
            con = new OleDbConnection(_connstr);
            con.Open();
            _command = new OleDbCommand();
            _command.Connection = con;
        }

        public OleDbDataAdapter SelectTable()
        {
            string s = "SELECT MSysObjects.Name AS table_name " +
                        "FROM MSysObjects " +
                        "WHERE (((Left([Name],1))<>\"~\")" +
                        "AND ((Left([Name],4))<>\"MSys\")" +
                        "AND ((MSysObjects.Type) In (1,4,6)))" +
                        "order by MSysObjects.Name "; 


            return new OleDbDataAdapter(s, con);
        }

        public OleDbDataAdapter OleDbDataAdapter(string table)
        {
            _table = string.Format("[{0}$]", table); 
            return new OleDbDataAdapter("select * from " + _table, con);
        }

        public List<string> Search(string colName,string column)
        {
            List<string> rows = new List<string>();
            int n;
            if(int.TryParse(column, out n))
                _command.CommandText = string.Format("SELECT * FROM {0} WHERE {1} = {2}", _table, colName,column);
            else
                _command.CommandText = string.Format("SELECT * FROM {0} WHERE {1} = '{2}'", _table, colName, column);

            _reader = _command.ExecuteReader();

            //int i = 0;
            while(_reader.Read())
            {
                rows.Add(_reader[0].ToString());
            }
            

            _reader.Close();
            _reader.Dispose();

            return rows;
        }

        public OleDbDataAdapter AdSearch(string colName, string column)
        {
            double n;
            if (double.TryParse(column, out n))
            {   
                string s = string.Format("SELECT * FROM {0} WHERE {1} = {2}", _table, colName, column);
                return new OleDbDataAdapter(s, con);
            }
            else
                return new OleDbDataAdapter(string.Format("SELECT * FROM {0} WHERE {1} = '{2}'", _table, colName, column), con);
        }


        public void Dispose()
        {



            if(con != null)
                con.Dispose();
            
        }
    }
}
