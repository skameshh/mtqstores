
namespace mtqstores.Gagues
{
    partial class FormGagueExpiring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGagueExpiring));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnExport2Excel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_rance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_calib_due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_calibaration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_gage_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(482, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 32);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(332, 2);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(146, 24);
            this.dtpToDate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "From Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "To Date :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpToDate, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpFromDate, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(932, 36);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(92, 2);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(146, 24);
            this.dtpFromDate.TabIndex = 12;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalRows.Location = new System.Drawing.Point(791, 0);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(146, 45);
            this.lblTotalRows.TabIndex = 0;
            this.lblTotalRows.Text = "0";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport2Excel
            // 
            this.btnExport2Excel.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExport2Excel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport2Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport2Excel.ForeColor = System.Drawing.Color.White;
            this.btnExport2Excel.Location = new System.Drawing.Point(641, 2);
            this.btnExport2Excel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport2Excel.Name = "btnExport2Excel";
            this.btnExport2Excel.Size = new System.Drawing.Size(146, 41);
            this.btnExport2Excel.TabIndex = 1;
            this.btnExport2Excel.Text = "Export2Excel";
            this.btnExport2Excel.UseVisualStyleBackColor = false;
            this.btnExport2Excel.Click += new System.EventHandler(this.btnExport2Excel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRows, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExport2Excel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 407);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(939, 45);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(939, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gagues Expiring List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tg_id,
            this.tg_gage_id,
            this.tg_gage_desc,
            this.tg_gage_brand,
            this.tg_gage_rance,
            this.tg_gage_slno,
            this.tg_calib_due_date,
            this.tg_gage_calibaration,
            this.tg_gage_Location});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tg_id
            // 
            this.tg_id.DataPropertyName = "Id";
            this.tg_id.HeaderText = "Id";
            this.tg_id.MinimumWidth = 6;
            this.tg_id.Name = "tg_id";
            this.tg_id.ReadOnly = true;
            this.tg_id.Visible = false;
            this.tg_id.Width = 50;
            // 
            // tg_gage_id
            // 
            this.tg_gage_id.DataPropertyName = "gage_id";
            this.tg_gage_id.HeaderText = "Gauge Id";
            this.tg_gage_id.MinimumWidth = 6;
            this.tg_gage_id.Name = "tg_gage_id";
            this.tg_gage_id.ReadOnly = true;
            this.tg_gage_id.ToolTipText = "Gauge Id";
            // 
            // tg_gage_desc
            // 
            this.tg_gage_desc.DataPropertyName = "gage_desc";
            this.tg_gage_desc.HeaderText = "Description";
            this.tg_gage_desc.MinimumWidth = 6;
            this.tg_gage_desc.Name = "tg_gage_desc";
            this.tg_gage_desc.ReadOnly = true;
            this.tg_gage_desc.ToolTipText = "Description";
            this.tg_gage_desc.Width = 200;
            // 
            // tg_gage_brand
            // 
            this.tg_gage_brand.DataPropertyName = "gage_brand";
            this.tg_gage_brand.HeaderText = "Brand";
            this.tg_gage_brand.MinimumWidth = 6;
            this.tg_gage_brand.Name = "tg_gage_brand";
            this.tg_gage_brand.ReadOnly = true;
            this.tg_gage_brand.ToolTipText = "Brand";
            this.tg_gage_brand.Width = 150;
            // 
            // tg_gage_rance
            // 
            this.tg_gage_rance.DataPropertyName = "gage_rance";
            this.tg_gage_rance.HeaderText = "Range";
            this.tg_gage_rance.MinimumWidth = 6;
            this.tg_gage_rance.Name = "tg_gage_rance";
            this.tg_gage_rance.ReadOnly = true;
            this.tg_gage_rance.ToolTipText = "Range";
            this.tg_gage_rance.Width = 125;
            // 
            // tg_gage_slno
            // 
            this.tg_gage_slno.DataPropertyName = "gage_slno";
            this.tg_gage_slno.HeaderText = "Sl No";
            this.tg_gage_slno.MinimumWidth = 6;
            this.tg_gage_slno.Name = "tg_gage_slno";
            this.tg_gage_slno.ReadOnly = true;
            this.tg_gage_slno.ToolTipText = "Sl No";
            this.tg_gage_slno.Width = 125;
            // 
            // tg_calib_due_date
            // 
            this.tg_calib_due_date.DataPropertyName = "calib_due_date";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            this.tg_calib_due_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.tg_calib_due_date.HeaderText = "Expiry Date";
            this.tg_calib_due_date.MinimumWidth = 6;
            this.tg_calib_due_date.Name = "tg_calib_due_date";
            this.tg_calib_due_date.ReadOnly = true;
            this.tg_calib_due_date.Width = 125;
            // 
            // tg_gage_calibaration
            // 
            this.tg_gage_calibaration.DataPropertyName = "clib_agency";
            this.tg_gage_calibaration.HeaderText = "Supplier Claribation";
            this.tg_gage_calibaration.Name = "tg_gage_calibaration";
            // 
            // tg_gage_Location
            // 
            this.tg_gage_Location.DataPropertyName = "gage_location";
            this.tg_gage_Location.HeaderText = "Location";
            this.tg_gage_Location.Name = "tg_gage_Location";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 470);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FormGagueExpiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGagueExpiring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGagueExpiring";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Button btnExport2Excel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_rance;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_calib_due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_calibaration;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_gage_Location;
    }
}