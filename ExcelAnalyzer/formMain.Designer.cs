namespace ExcelAnalyzer
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenfile = new System.Windows.Forms.Button();
            this.dataSet = new System.Data.DataSet();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.menuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btLog = new System.Windows.Forms.Button();
            this.textTable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(114, 18);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(208, 20);
            this.textPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel file path :";
            // 
            // btOpenfile
            // 
            this.btOpenfile.Location = new System.Drawing.Point(452, 16);
            this.btOpenfile.Name = "btOpenfile";
            this.btOpenfile.Size = new System.Drawing.Size(75, 23);
            this.btOpenfile.TabIndex = 2;
            this.btOpenfile.Text = "Open";
            this.btOpenfile.UseVisualStyleBackColor = true;
            this.btOpenfile.Click += new System.EventHandler(this.btOpenfile_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.ContextMenuStrip = this.menuRightClick;
            this.dataView.Location = new System.Drawing.Point(12, 57);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(734, 454);
            this.dataView.TabIndex = 3;
            this.dataView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataView_CellMouseDown);
            // 
            // menuRightClick
            // 
            this.menuRightClick.Name = "menuRightClick";
            this.menuRightClick.Size = new System.Drawing.Size(61, 4);
            // 
            // btLog
            // 
            this.btLog.Location = new System.Drawing.Point(671, 18);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(75, 23);
            this.btLog.TabIndex = 4;
            this.btLog.Text = "Log";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // textTable
            // 
            this.textTable.Location = new System.Drawing.Point(334, 17);
            this.textTable.Name = "textTable";
            this.textTable.Size = new System.Drawing.Size(100, 20);
            this.textTable.TabIndex = 5;
            this.textTable.Text = "Type table name";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 523);
            this.Controls.Add(this.textTable);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btOpenfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMain";
            this.Text = " ";
            this.Move += new System.EventHandler(this.formMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenfile;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.ContextMenuStrip menuRightClick;
        private System.Windows.Forms.TextBox textTable;
    }
}

