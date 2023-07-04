
namespace mtqstores.forms
{
    partial class FormAuditorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuditorList));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pbAdd1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboRange = new System.Windows.Forms.ComboBox();
            this.txtGaugeId = new System.Windows.Forms.TextBox();
            this.cboCalibMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAllMaterialExport2Excel = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new mtqstores.MyDGV.MYDgv();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_rance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcalib_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcalib_interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcalib_due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgclib_agency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcalib_cert_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggage_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1365, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "Auditor List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pbAdd1, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboBrand, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboRange, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtGaugeId, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboCalibMethod, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtDesc, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFromDate, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpToDate, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 8, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1365, 82);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pbAdd1
            // 
            this.pbAdd1.Image = global::mtqstores.Properties.Resources.add;
            this.pbAdd1.Location = new System.Drawing.Point(1310, 8);
            this.pbAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAdd1.Name = "pbAdd1";
            this.tableLayoutPanel3.SetRowSpan(this.pbAdd1, 2);
            this.pbAdd1.Size = new System.Drawing.Size(1, 68);
            this.pbAdd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd1.TabIndex = 28;
            this.pbAdd1.TabStop = false;
            this.pbAdd1.Click += new System.EventHandler(this.pbAdd1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Brand";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Range";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(321, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gauge Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(470, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calib Method";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboBrand
            // 
            this.cboBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(23, 38);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(143, 33);
            this.cboBrand.TabIndex = 15;
            // 
            // cboRange
            // 
            this.cboRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRange.FormattingEnabled = true;
            this.cboRange.Location = new System.Drawing.Point(172, 38);
            this.cboRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRange.Name = "cboRange";
            this.cboRange.Size = new System.Drawing.Size(143, 33);
            this.cboRange.TabIndex = 16;
            // 
            // txtGaugeId
            // 
            this.txtGaugeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGaugeId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGaugeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaugeId.Location = new System.Drawing.Point(321, 38);
            this.txtGaugeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGaugeId.Name = "txtGaugeId";
            this.txtGaugeId.Size = new System.Drawing.Size(143, 32);
            this.txtGaugeId.TabIndex = 17;
            // 
            // cboCalibMethod
            // 
            this.cboCalibMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCalibMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCalibMethod.FormattingEnabled = true;
            this.cboCalibMethod.Location = new System.Drawing.Point(470, 38);
            this.cboCalibMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCalibMethod.Name = "cboCalibMethod";
            this.cboCalibMethod.Size = new System.Drawing.Size(143, 33);
            this.cboCalibMethod.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(619, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(619, 38);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(194, 32);
            this.txtDesc.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(819, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "From Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(990, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "To Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(819, 38);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(165, 30);
            this.dtpFromDate.TabIndex = 24;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(990, 38);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(165, 30);
            this.dtpToDate.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pbSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbClear, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1161, 8);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel3.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(143, 72);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // pbSearch
            // 
            this.pbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSearch.Image = global::mtqstores.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(3, 2);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(65, 68);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 0;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbClear
            // 
            this.pbClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbClear.Image = global::mtqstores.Properties.Resources.clear;
            this.pbClear.Location = new System.Drawing.Point(74, 2);
            this.pbClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(66, 68);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClear.TabIndex = 1;
            this.pbClear.TabStop = false;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.btnAllMaterialExport2Excel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRows, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 670);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1365, 46);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAllMaterialExport2Excel
            // 
            this.btnAllMaterialExport2Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAllMaterialExport2Excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAllMaterialExport2Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMaterialExport2Excel.ForeColor = System.Drawing.Color.White;
            this.btnAllMaterialExport2Excel.Location = new System.Drawing.Point(3, 2);
            this.btnAllMaterialExport2Excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllMaterialExport2Excel.Name = "btnAllMaterialExport2Excel";
            this.btnAllMaterialExport2Excel.Size = new System.Drawing.Size(195, 42);
            this.btnAllMaterialExport2Excel.TabIndex = 1;
            this.btnAllMaterialExport2Excel.Text = "Export to Excel";
            this.btnAllMaterialExport2Excel.UseVisualStyleBackColor = false;
            this.btnAllMaterialExport2Excel.Click += new System.EventHandler(this.btnAllMaterialExport2Excel_Click);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalRows.Location = new System.Drawing.Point(1078, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(284, 46);
            this.lblTotalRows.TabIndex = 0;
            this.lblTotalRows.Text = "rows";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 718);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dggage_id,
            this.dggage_desc,
            this.dggage_brand,
            this.dggage_rance,
            this.dggage_slno,
            this.dgtolerance,
            this.dgcalib_date,
            this.dgcalib_interval,
            this.dgcalib_due_date,
            this.dgclib_agency,
            this.dgcalib_cert_no,
            this.dggage_location});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgId
            // 
            this.dgId.DataPropertyName = "Id";
            this.dgId.HeaderText = "Id";
            this.dgId.MinimumWidth = 6;
            this.dgId.Name = "dgId";
            this.dgId.ReadOnly = true;
            this.dgId.Visible = false;
            this.dgId.Width = 125;
            // 
            // dggage_id
            // 
            this.dggage_id.DataPropertyName = "gage_id";
            this.dggage_id.HeaderText = "gage_id";
            this.dggage_id.MinimumWidth = 6;
            this.dggage_id.Name = "dggage_id";
            this.dggage_id.ReadOnly = true;
            this.dggage_id.Width = 80;
            // 
            // dggage_desc
            // 
            this.dggage_desc.DataPropertyName = "gage_desc";
            this.dggage_desc.HeaderText = "Description";
            this.dggage_desc.MinimumWidth = 6;
            this.dggage_desc.Name = "dggage_desc";
            this.dggage_desc.ReadOnly = true;
            this.dggage_desc.Width = 250;
            // 
            // dggage_brand
            // 
            this.dggage_brand.DataPropertyName = "gage_brand";
            this.dggage_brand.HeaderText = "Brand";
            this.dggage_brand.MinimumWidth = 6;
            this.dggage_brand.Name = "dggage_brand";
            this.dggage_brand.ReadOnly = true;
            this.dggage_brand.Width = 125;
            // 
            // dggage_rance
            // 
            this.dggage_rance.DataPropertyName = "gage_rance";
            this.dggage_rance.HeaderText = "Range";
            this.dggage_rance.MinimumWidth = 6;
            this.dggage_rance.Name = "dggage_rance";
            this.dggage_rance.ReadOnly = true;
            this.dggage_rance.Width = 125;
            // 
            // dggage_slno
            // 
            this.dggage_slno.DataPropertyName = "gage_slno";
            this.dggage_slno.HeaderText = "Sl No";
            this.dggage_slno.MinimumWidth = 6;
            this.dggage_slno.Name = "dggage_slno";
            this.dggage_slno.ReadOnly = true;
            this.dggage_slno.Width = 90;
            // 
            // dgtolerance
            // 
            this.dgtolerance.DataPropertyName = "tolerance";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd";
            dataGridViewCellStyle2.NullValue = null;
            this.dgtolerance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtolerance.HeaderText = "tolerance";
            this.dgtolerance.MinimumWidth = 6;
            this.dgtolerance.Name = "dgtolerance";
            this.dgtolerance.ReadOnly = true;
            this.dgtolerance.Width = 125;
            // 
            // dgcalib_date
            // 
            this.dgcalib_date.DataPropertyName = "calib_date";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            dataGridViewCellStyle3.NullValue = null;
            this.dgcalib_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcalib_date.HeaderText = "calib_date";
            this.dgcalib_date.MinimumWidth = 6;
            this.dgcalib_date.Name = "dgcalib_date";
            this.dgcalib_date.ReadOnly = true;
            this.dgcalib_date.Width = 90;
            // 
            // dgcalib_interval
            // 
            this.dgcalib_interval.DataPropertyName = "calib_interval";
            this.dgcalib_interval.HeaderText = "calib_interval";
            this.dgcalib_interval.MinimumWidth = 6;
            this.dgcalib_interval.Name = "dgcalib_interval";
            this.dgcalib_interval.ReadOnly = true;
            this.dgcalib_interval.Width = 80;
            // 
            // dgcalib_due_date
            // 
            this.dgcalib_due_date.DataPropertyName = "calib_due_date";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd";
            this.dgcalib_due_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcalib_due_date.HeaderText = "calib_due_date";
            this.dgcalib_due_date.MinimumWidth = 6;
            this.dgcalib_due_date.Name = "dgcalib_due_date";
            this.dgcalib_due_date.ReadOnly = true;
            this.dgcalib_due_date.Width = 90;
            // 
            // dgclib_agency
            // 
            this.dgclib_agency.DataPropertyName = "clib_agency";
            this.dgclib_agency.HeaderText = "clib_agency";
            this.dgclib_agency.MinimumWidth = 6;
            this.dgclib_agency.Name = "dgclib_agency";
            this.dgclib_agency.ReadOnly = true;
            this.dgclib_agency.Width = 125;
            // 
            // dgcalib_cert_no
            // 
            this.dgcalib_cert_no.DataPropertyName = "calib_cert_no";
            this.dgcalib_cert_no.HeaderText = "calib_cert_no";
            this.dgcalib_cert_no.MinimumWidth = 6;
            this.dgcalib_cert_no.Name = "dgcalib_cert_no";
            this.dgcalib_cert_no.ReadOnly = true;
            this.dgcalib_cert_no.Width = 125;
            // 
            // dggage_location
            // 
            this.dggage_location.DataPropertyName = "gage_location";
            this.dggage_location.HeaderText = "gage_location";
            this.dggage_location.MinimumWidth = 6;
            this.dggage_location.Name = "dggage_location";
            this.dggage_location.ReadOnly = true;
            this.dggage_location.Width = 125;
            // 
            // FormAuditorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1371, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAuditorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditor List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGaguesMain_FormClosing);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pbAdd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboRange;
        private System.Windows.Forms.TextBox txtGaugeId;
        private System.Windows.Forms.ComboBox cboCalibMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAllMaterialExport2Excel;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyDGV.MYDgv dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_rance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtolerance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcalib_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcalib_interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcalib_due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgclib_agency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcalib_cert_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggage_location;
    }
}