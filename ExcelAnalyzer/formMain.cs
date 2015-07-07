using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAnalyzer
{
    public partial class formMain : Form
    {
        private Controller c;

        private formLog logform;
        
        bool b = false;
        

        public formMain()
        {
            InitializeComponent();
            c = new Controller();
            logform = new formLog();
            btLog_Click(new object(), new EventArgs());

            c.SendEvent += logform.OnLogUpdata;
            
            
        }

        private void btOpenfile_Click(object sender, EventArgs e)
        {
            try
            {
                dataView.DataSource = null;
                dataView.Rows.Clear();
                dataView.Refresh();
                dataSet.Clear();


                c.SetPath(textPath.Text);

                c.LoadData(dataSet, textTable.Text);

                dataView.DataSource = dataSet.Tables[0];
            }
            catch(Exception x)
            {
                MessageBox.Show("Make sure you entered right file path and table name.");
            }
        }


        private void btLog_Click(object sender, EventArgs e)
        {
            if (!b)
            {
                logform.Show();
                logform.Location = new Point(this.Location.X + this.Width, this.Location.Y); 
                b = true;
            }
            else
            {
                logform.Hide();
                b = false;
            }
            
        }

        private void formMain_Move(object sender, EventArgs e)
        {
            logform.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }


        private void dataView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            menuRightClick.Items.Clear();
            try
            {
                dataView.ClearSelection();
                dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                dataView.CurrentCell = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                newSearchForStrip();
                newAverageStrip();
    
            }
            catch (Exception ex)
            { }
        }

        private void newSearchForStrip() 
        {
            ToolStripMenuItem it = new ToolStripMenuItem();
            string cell = dataView.CurrentCell.Value.ToString(); string col = dataView.Columns[dataView.CurrentCell.ColumnIndex].Name;
            it.Text = "Search for all \"" + cell + "\" in " + "\"" + col + "\"";
            it.Click += (o, i) =>
            {
                try
                {
                    dataView.DataSource = null;
                    dataView.Rows.Clear();
                    dataView.Refresh();
                    dataSet.Clear();

                    c.SearchEntries(col, cell, dataSet);
                    dataView.DataSource = dataSet.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Make sure there is no Space in between column names.");
                }
            };

            menuRightClick.Items.Add(it);
        }

        private void newAverageStrip()
        { 
            double n;
            if (double.TryParse(dataView.CurrentCell.Value.ToString(), out n))
            {
                ToolStripMenuItem it = new ToolStripMenuItem();
                int coln = dataView.CurrentCell.ColumnIndex; string col = dataView.Columns[coln].Name;
                it.Text = "Find average " + col;

           
                List<double> list = new List<double>();

                for (int i = 0; i < dataView.Rows.Count; i ++)
                    list.Add(Convert.ToDouble(dataView.Rows[i].Cells[coln].Value.ToString()));
                
                
                it.Click += (o, i) =>
                {
                    c.Average(list, col);
                    dataView.DataSource = dataSet.Tables[0];
                };

                menuRightClick.Items.Add(it);

            }
        }


    }
}
