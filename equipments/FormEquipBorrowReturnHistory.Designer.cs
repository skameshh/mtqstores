
namespace mtqstores.equipments
{
    partial class FormEquipBorrowReturnHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipBorrowReturnHistory));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtEquipTag = new System.Windows.Forms.TextBox();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnExport2Excel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg_tag_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgborrowed_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgreturned_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgborrowed_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgreturned_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgborrow_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgreturn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatusremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(737, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 33);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(587, 2);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(146, 26);
            this.dtpToDate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(257, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 37);
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
            this.label1.Location = new System.Drawing.Point(497, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "To Date :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpToDate, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpFromDate, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtEquipTag, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1001, 37);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Equip Tag :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(347, 2);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(146, 26);
            this.dtpFromDate.TabIndex = 12;
            // 
            // txtEquipTag
            // 
            this.txtEquipTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipTag.Location = new System.Drawing.Point(92, 2);
            this.txtEquipTag.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipTag.Name = "txtEquipTag";
            this.txtEquipTag.Size = new System.Drawing.Size(146, 28);
            this.txtEquipTag.TabIndex = 16;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalRows.Location = new System.Drawing.Point(853, 0);
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
            this.btnExport2Excel.Location = new System.Drawing.Point(703, 2);
            this.btnExport2Excel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport2Excel.Name = "btnExport2Excel";
            this.btnExport2Excel.Size = new System.Drawing.Size(146, 41);
            this.btnExport2Excel.TabIndex = 1;
            this.btnExport2Excel.Text = "Export2Excel";
            this.btnExport2Excel.UseVisualStyleBackColor = false;
            this.btnExport2Excel.Click += new System.EventHandler(this.btnExport2Excel_Click);
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
            this.label8.Size = new System.Drawing.Size(1001, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Equipments Borrow Return History";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tg_id,
            this.tg_tag_no,
            this.dgborrowed_by,
            this.dgreturned_by,
            this.dgborrowed_on,
            this.dgreturned_on,
            this.dgborrow_comments,
            this.dgreturn_comments,
            this.dgstatus,
            this.dgStatusremark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 369);
            this.dataGridView1.TabIndex = 0;
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
            // tg_tag_no
            // 
            this.tg_tag_no.DataPropertyName = "equip_tag";
            this.tg_tag_no.HeaderText = "Tag No";
            this.tg_tag_no.MinimumWidth = 6;
            this.tg_tag_no.Name = "tg_tag_no";
            this.tg_tag_no.ReadOnly = true;
            this.tg_tag_no.ToolTipText = "Tag No";
            this.tg_tag_no.Width = 90;
            // 
            // dgborrowed_by
            // 
            this.dgborrowed_by.DataPropertyName = "borrowed_by";
            this.dgborrowed_by.HeaderText = "borrowed_by";
            this.dgborrowed_by.MinimumWidth = 6;
            this.dgborrowed_by.Name = "dgborrowed_by";
            this.dgborrowed_by.ReadOnly = true;
            this.dgborrowed_by.ToolTipText = "borrowed_by";
            this.dgborrowed_by.Width = 90;
            // 
            // dgreturned_by
            // 
            this.dgreturned_by.DataPropertyName = "returned_by";
            this.dgreturned_by.HeaderText = "returned_by";
            this.dgreturned_by.MinimumWidth = 6;
            this.dgreturned_by.Name = "dgreturned_by";
            this.dgreturned_by.ReadOnly = true;
            this.dgreturned_by.ToolTipText = "returned_by";
            this.dgreturned_by.Width = 90;
            // 
            // dgborrowed_on
            // 
            this.dgborrowed_on.DataPropertyName = "borrowed_on";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            dataGridViewCellStyle1.NullValue = null;
            this.dgborrowed_on.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgborrowed_on.HeaderText = "borrowed_on";
            this.dgborrowed_on.MinimumWidth = 6;
            this.dgborrowed_on.Name = "dgborrowed_on";
            this.dgborrowed_on.ReadOnly = true;
            this.dgborrowed_on.ToolTipText = "borrowed_on";
            this.dgborrowed_on.Width = 80;
            // 
            // dgreturned_on
            // 
            this.dgreturned_on.DataPropertyName = "returned_on";
            this.dgreturned_on.HeaderText = "returned_on";
            this.dgreturned_on.MinimumWidth = 6;
            this.dgreturned_on.Name = "dgreturned_on";
            this.dgreturned_on.ReadOnly = true;
            this.dgreturned_on.ToolTipText = "returned_on";
            this.dgreturned_on.Width = 80;
            // 
            // dgborrow_comments
            // 
            this.dgborrow_comments.DataPropertyName = "borrow_comments";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Format = "yyyy-MM-dd";
            this.dgborrow_comments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgborrow_comments.HeaderText = "borrow_comments";
            this.dgborrow_comments.MinimumWidth = 6;
            this.dgborrow_comments.Name = "dgborrow_comments";
            this.dgborrow_comments.ReadOnly = true;
            this.dgborrow_comments.Width = 200;
            // 
            // dgreturn_comments
            // 
            this.dgreturn_comments.DataPropertyName = "return_comments";
            this.dgreturn_comments.HeaderText = "return_comments";
            this.dgreturn_comments.MinimumWidth = 6;
            this.dgreturn_comments.Name = "dgreturn_comments";
            this.dgreturn_comments.Width = 200;
            // 
            // dgstatus
            // 
            this.dgstatus.DataPropertyName = "StatusStr";
            this.dgstatus.HeaderText = "status";
            this.dgstatus.MinimumWidth = 6;
            this.dgstatus.Name = "dgstatus";
            this.dgstatus.ReadOnly = true;
            this.dgstatus.Width = 125;
            // 
            // dgStatusremark
            // 
            this.dgStatusremark.DataPropertyName = "StatusRemark";
            this.dgStatusremark.HeaderText = "Status Remark";
            this.dgStatusremark.Name = "dgStatusremark";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 511);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 448);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1001, 45);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // FormEquipBorrowReturnHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEquipBorrowReturnHistory";
            this.Text = "FormEquipBorrowReturnHistory";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg_tag_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgborrowed_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgreturned_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgborrowed_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgreturned_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgborrow_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgreturn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatusremark;
    }
}