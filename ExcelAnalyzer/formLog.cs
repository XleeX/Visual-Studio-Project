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
    public partial class formLog : Form
    {

        #region dragging
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        #endregion
        public formLog()
        {
            InitializeComponent();
        }

        public void OnLogUpdata(string message)
        {
            textLog.Text += message;
        }

        private void textLog_TextChanged(object sender, EventArgs e)
        {
            textLog.SelectionStart = textLog.Text.Length;
            textLog.ScrollToCaret();
        }
    }
}
