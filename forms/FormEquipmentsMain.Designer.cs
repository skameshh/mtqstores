
namespace mtqstores.forms
{
    partial class FormEquipmentsMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipmentsMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdImportExcel = new System.Windows.Forms.Button();
            this.btnAllMaterialExport2Excel = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.pbAdd2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtTagNo = new System.Windows.Forms.TextBox();
            this.cboSWL = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbAdd1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalEquip = new System.Windows.Forms.Label();
            this.txtEquipTag = new System.Windows.Forms.TextBox();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.btnExpiringThisMonth = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBorrowReturnHistory = new System.Windows.Forms.Button();
            this.btnUserMgmt = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new mtqstores.MyDGV.MYDgv();
            this.btEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtag_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgswl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dglength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgexp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmailSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.64648F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 738);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.cmdImportExcel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAllMaterialExport2Excel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRows, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbAdd2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmailSend, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(210, 690);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1056, 46);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cmdImportExcel
            // 
            this.cmdImportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdImportExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImportExcel.ForeColor = System.Drawing.Color.White;
            this.cmdImportExcel.Location = new System.Drawing.Point(203, 2);
            this.cmdImportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdImportExcel.Name = "cmdImportExcel";
            this.cmdImportExcel.Size = new System.Drawing.Size(177, 42);
            this.cmdImportExcel.TabIndex = 32;
            this.cmdImportExcel.Text = "Import Excel";
            this.cmdImportExcel.UseVisualStyleBackColor = false;
            this.cmdImportExcel.Click += new System.EventHandler(this.cmdImportExcel_Click_1);
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
            this.btnAllMaterialExport2Excel.Size = new System.Drawing.Size(185, 42);
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
            this.lblTotalRows.Location = new System.Drawing.Point(819, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(114, 46);
            this.lblTotalRows.TabIndex = 0;
            this.lblTotalRows.Text = "rows";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAdd2
            // 
            this.pbAdd2.Image = global::mtqstores.Properties.Resources.add;
            this.pbAdd2.Location = new System.Drawing.Point(403, 2);
            this.pbAdd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAdd2.Name = "pbAdd2";
            this.pbAdd2.Size = new System.Drawing.Size(75, 38);
            this.pbAdd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd2.TabIndex = 28;
            this.pbAdd2.TabStop = false;
            this.pbAdd2.Click += new System.EventHandler(this.pbAdd2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Salmon;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 46);
            this.label9.TabIndex = 29;
            this.label9.Text = "Expired";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboDept, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboType, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTagNo, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboSWL, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtDesc, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFromDate, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpToDate, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.pbAdd1, 9, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(210, 36);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1056, 82);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.label6.Text = "Dept";
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
            this.label1.Text = "Type";
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
            this.label2.Text = "Tag No";
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
            this.label3.Text = "SWL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboDept
            // 
            this.cboDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(23, 38);
            this.cboDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(143, 33);
            this.cboDept.TabIndex = 15;
            // 
            // cboType
            // 
            this.cboType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(172, 38);
            this.cboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(143, 33);
            this.cboType.TabIndex = 16;
            // 
            // txtTagNo
            // 
            this.txtTagNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTagNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNo.Location = new System.Drawing.Point(321, 38);
            this.txtTagNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTagNo.Name = "txtTagNo";
            this.txtTagNo.Size = new System.Drawing.Size(143, 32);
            this.txtTagNo.TabIndex = 17;
            // 
            // cboSWL
            // 
            this.cboSWL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSWL.FormattingEnabled = true;
            this.cboSWL.Location = new System.Drawing.Point(470, 38);
            this.cboSWL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSWL.Name = "cboSWL";
            this.cboSWL.Size = new System.Drawing.Size(143, 33);
            this.cboSWL.TabIndex = 18;
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
            // pbAdd1
            // 
            this.pbAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdd1.Image = global::mtqstores.Properties.Resources.add;
            this.pbAdd1.Location = new System.Drawing.Point(1310, 8);
            this.pbAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAdd1.Name = "pbAdd1";
            this.tableLayoutPanel3.SetRowSpan(this.pbAdd1, 2);
            this.pbAdd1.Size = new System.Drawing.Size(94, 72);
            this.pbAdd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd1.TabIndex = 27;
            this.pbAdd1.TabStop = false;
            this.pbAdd1.Click += new System.EventHandler(this.pbAdd1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Thistle;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lblTotalEquip, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtEquipTag, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.btnBorrowReturn, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.btnExpiringThisMonth, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtUserId, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnLogin, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnBorrowReturnHistory, 0, 11);
            this.tableLayoutPanel5.Controls.Add(this.btnUserMgmt, 0, 13);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 17;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(201, 564);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // lblTotalEquip
            // 
            this.lblTotalEquip.AutoSize = true;
            this.lblTotalEquip.BackColor = System.Drawing.Color.Gray;
            this.lblTotalEquip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEquip.ForeColor = System.Drawing.Color.White;
            this.lblTotalEquip.Location = new System.Drawing.Point(3, 163);
            this.lblTotalEquip.Name = "lblTotalEquip";
            this.lblTotalEquip.Size = new System.Drawing.Size(195, 39);
            this.lblTotalEquip.TabIndex = 10;
            this.lblTotalEquip.Text = "Enter Equipment Tag";
            this.lblTotalEquip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEquipTag
            // 
            this.txtEquipTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEquipTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipTag.ForeColor = System.Drawing.Color.DarkRed;
            this.txtEquipTag.Location = new System.Drawing.Point(3, 204);
            this.txtEquipTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEquipTag.Name = "txtEquipTag";
            this.txtEquipTag.Size = new System.Drawing.Size(195, 41);
            this.txtEquipTag.TabIndex = 11;
            this.txtEquipTag.Text = "LG31119";
            this.txtEquipTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBorrowReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowReturn.ForeColor = System.Drawing.Color.White;
            this.btnBorrowReturn.Location = new System.Drawing.Point(3, 253);
            this.btnBorrowReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Size = new System.Drawing.Size(195, 46);
            this.btnBorrowReturn.TabIndex = 12;
            this.btnBorrowReturn.Text = "Borrow / Return";
            this.btnBorrowReturn.UseVisualStyleBackColor = false;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrowReturn_Click);
            // 
            // btnExpiringThisMonth
            // 
            this.btnExpiringThisMonth.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExpiringThisMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpiringThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiringThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnExpiringThisMonth.Location = new System.Drawing.Point(3, 323);
            this.btnExpiringThisMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpiringThisMonth.Name = "btnExpiringThisMonth";
            this.btnExpiringThisMonth.Size = new System.Drawing.Size(195, 46);
            this.btnExpiringThisMonth.TabIndex = 13;
            this.btnExpiringThisMonth.Text = "Expiring List";
            this.btnExpiringThisMonth.UseVisualStyleBackColor = false;
            this.btnExpiringThisMonth.Click += new System.EventHandler(this.btnExpiringThisMonth_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 39);
            this.label10.TabIndex = 14;
            this.label10.Text = "Enter User Id";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserId
            // 
            this.txtUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.DarkRed;
            this.txtUserId.Location = new System.Drawing.Point(3, 46);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(195, 34);
            this.txtUserId.TabIndex = 15;
            this.txtUserId.Text = "68428";
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(3, 85);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(195, 56);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBorrowReturnHistory
            // 
            this.btnBorrowReturnHistory.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBorrowReturnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowReturnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowReturnHistory.ForeColor = System.Drawing.Color.White;
            this.btnBorrowReturnHistory.Location = new System.Drawing.Point(3, 393);
            this.btnBorrowReturnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrowReturnHistory.Name = "btnBorrowReturnHistory";
            this.btnBorrowReturnHistory.Size = new System.Drawing.Size(195, 46);
            this.btnBorrowReturnHistory.TabIndex = 17;
            this.btnBorrowReturnHistory.Text = "Borrow/Return History";
            this.btnBorrowReturnHistory.UseVisualStyleBackColor = false;
            this.btnBorrowReturnHistory.Click += new System.EventHandler(this.btnBorrowReturnHistory_Click);
            // 
            // btnUserMgmt
            // 
            this.btnUserMgmt.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUserMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgmt.ForeColor = System.Drawing.Color.White;
            this.btnUserMgmt.Location = new System.Drawing.Point(3, 463);
            this.btnUserMgmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserMgmt.Name = "btnUserMgmt";
            this.btnUserMgmt.Size = new System.Drawing.Size(195, 46);
            this.btnUserMgmt.TabIndex = 18;
            this.btnUserMgmt.Text = "User Mgmt";
            this.btnUserMgmt.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 688);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(201, 50);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(210, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1056, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "All Available Equipments";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::mtqstores.Properties.Resources.MTQ_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(201, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            this.btEdit,
            this.dgId,
            this.dgdept,
            this.dgdescription,
            this.dgtype,
            this.dgtag_no,
            this.dgswl,
            this.dglength,
            this.dgexp_date,
            this.dgremarks});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(210, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btEdit
            // 
            this.btEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.HeaderText = "Update";
            this.btEdit.MinimumWidth = 6;
            this.btEdit.Name = "btEdit";
            this.btEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btEdit.Width = 74;
            // 
            // dgId
            // 
            this.dgId.DataPropertyName = "Id";
            this.dgId.HeaderText = "Id";
            this.dgId.MinimumWidth = 6;
            this.dgId.Name = "dgId";
            this.dgId.ReadOnly = true;
            this.dgId.Visible = false;
            this.dgId.Width = 80;
            // 
            // dgdept
            // 
            this.dgdept.DataPropertyName = "dept";
            this.dgdept.HeaderText = "Dept";
            this.dgdept.MinimumWidth = 6;
            this.dgdept.Name = "dgdept";
            this.dgdept.ReadOnly = true;
            this.dgdept.Width = 90;
            // 
            // dgdescription
            // 
            this.dgdescription.DataPropertyName = "description";
            this.dgdescription.HeaderText = "Description";
            this.dgdescription.MinimumWidth = 6;
            this.dgdescription.Name = "dgdescription";
            this.dgdescription.Width = 250;
            // 
            // dgtype
            // 
            this.dgtype.DataPropertyName = "type";
            this.dgtype.HeaderText = "Type";
            this.dgtype.MinimumWidth = 6;
            this.dgtype.Name = "dgtype";
            this.dgtype.Width = 200;
            // 
            // dgtag_no
            // 
            this.dgtag_no.DataPropertyName = "tag_no";
            this.dgtag_no.HeaderText = "Tag No";
            this.dgtag_no.MinimumWidth = 6;
            this.dgtag_no.Name = "dgtag_no";
            this.dgtag_no.Width = 200;
            // 
            // dgswl
            // 
            this.dgswl.DataPropertyName = "swl";
            this.dgswl.HeaderText = "SWL";
            this.dgswl.MinimumWidth = 6;
            this.dgswl.Name = "dgswl";
            this.dgswl.Width = 125;
            // 
            // dglength
            // 
            this.dglength.DataPropertyName = "length";
            this.dglength.HeaderText = "Length";
            this.dglength.MinimumWidth = 6;
            this.dglength.Name = "dglength";
            this.dglength.Width = 125;
            // 
            // dgexp_date
            // 
            this.dgexp_date.DataPropertyName = "exp_date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "yyyy-MM-dd";
            dataGridViewCellStyle2.NullValue = null;
            this.dgexp_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgexp_date.HeaderText = "Exp Date";
            this.dgexp_date.MinimumWidth = 6;
            this.dgexp_date.Name = "dgexp_date";
            this.dgexp_date.ReadOnly = true;
            this.dgexp_date.Width = 90;
            // 
            // dgremarks
            // 
            this.dgremarks.DataPropertyName = "remarks";
            this.dgremarks.HeaderText = "Remarks";
            this.dgremarks.MinimumWidth = 6;
            this.dgremarks.Name = "dgremarks";
            this.dgremarks.Width = 125;
            // 
            // btnEmailSend
            // 
            this.btnEmailSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmailSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailSend.ForeColor = System.Drawing.Color.White;
            this.btnEmailSend.Location = new System.Drawing.Point(939, 2);
            this.btnEmailSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmailSend.Name = "btnEmailSend";
            this.btnEmailSend.Size = new System.Drawing.Size(114, 42);
            this.btnEmailSend.TabIndex = 33;
            this.btnEmailSend.Text = "Email";
            this.btnEmailSend.UseVisualStyleBackColor = false;
            this.btnEmailSend.Click += new System.EventHandler(this.btnEmailSend_Click);
            // 
            // FormEquipmentsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEquipmentsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipments Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEquipmentsMain_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private   MyDGV.MYDgv dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtTagNo;
        private System.Windows.Forms.ComboBox cboSWL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAllMaterialExport2Excel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTotalEquip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbAdd1;
        private System.Windows.Forms.PictureBox pbAdd2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEquipTag;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnExpiringThisMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBorrowReturnHistory;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.DataGridViewButtonColumn btEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtag_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgswl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dglength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgexp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgremarks;
        private System.Windows.Forms.Button cmdImportExcel;
        private System.Windows.Forms.Button btnEmailSend;
    }
}