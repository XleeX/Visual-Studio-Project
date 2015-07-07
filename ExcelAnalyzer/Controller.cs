using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;


namespace ExcelAnalyzer
{
    class Controller
    {
        private List<List<string>> _cells;
        private DataBaseAdapter _dbAdaptor;
        private string _path = "";

        public event LogMessage SendEvent;

        public Controller()
        {         
            _cells = new List<List<string>>();
        }

        public void SetPath(string path)
        {
            _path = path;
        }

        public void LoadData(DataSet ds, string table)
        {
            if(_dbAdaptor != null)
                _dbAdaptor.Dispose();

            _cells = new List<List<string>>();
            _dbAdaptor = new DataBaseAdapter(_path);

            _dbAdaptor.OleDbDataAdapter(table).Fill(ds);

            for (int c = 0; c < ds.Tables[0].Columns.Count-1; c++)
            {
                _cells.Add(new List<string>());
                for (int r = 0; r < ds.Tables[0].Rows.Count-1; r++)
                {
                    _cells[c].Add(ds.Tables[0].Rows[r][c].ToString());
                }
            }
            OnSendEvent("Excell file data has been loaded. File name : "+ Path.GetFileName(_path) + Environment.NewLine);
            OnSendEvent(_cells[0].Count + 1 + " Rows," + (_cells.Count + 1) + " Columns." + Environment.NewLine);
        }

        public void SearchEntries(string colName, string column, DataSet ds)
        {
            _dbAdaptor.AdSearch(colName, column).Fill(ds);
            OnSendEvent("Search " + colName + " is " + column + " ..." + Environment.NewLine);
            OnSendEvent(ds.Tables[0].Rows.Count + " Rows are found" + Environment.NewLine);
        }

        public void Average(List<double> list, string colName)
        {
            OnSendEvent("Average " + colName + " is " + String.Format("{0:0.00}" , list.Average()) + Environment.NewLine);
        }

        private string table()
        {
            DataSet ds = new DataSet();
            _dbAdaptor.SelectTable().Fill(ds);

            return ds.Tables[0].Columns[0].ToString();
        }

        protected virtual void OnSendEvent(string s)
        {
            if (SendEvent != null)
                SendEvent(s);
        }
    }
}   
