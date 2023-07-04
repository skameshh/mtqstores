
namespace mtqstores.forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnEquipments = new System.Windows.Forms.Button();
            this.btnGagues = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDBStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDBServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquipments
            // 
            this.btnEquipments.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEquipments.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEquipments.Location = new System.Drawing.Point(126, 189);
            this.btnEquipments.Name = "btnEquipments";
            this.btnEquipments.Size = new System.Drawing.Size(277, 135);
            this.btnEquipments.TabIndex = 1;
            this.btnEquipments.Text = "Equipments";
            this.btnEquipments.UseVisualStyleBackColor = false;
            this.btnEquipments.Click += new System.EventHandler(this.btnEquipments_Click);
            // 
            // btnGagues
            // 
            this.btnGagues.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGagues.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGagues.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGagues.Location = new System.Drawing.Point(126, 21);
            this.btnGagues.Name = "btnGagues";
            this.btnGagues.Size = new System.Drawing.Size(277, 120);
            this.btnGagues.TabIndex = 2;
            this.btnGagues.Text = "Gauges";
            this.btnGagues.UseVisualStyleBackColor = false;
            this.btnGagues.Click += new System.EventHandler(this.btnGagues_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDBStatus
            // 
            this.lblDBStatus.AutoSize = true;
            this.lblDBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBStatus.ForeColor = System.Drawing.Color.Green;
            this.lblDBStatus.Location = new System.Drawing.Point(23, 368);
            this.lblDBStatus.Name = "lblDBStatus";
            this.lblDBStatus.Size = new System.Drawing.Size(37, 24);
            this.lblDBStatus.TabIndex = 4;
            this.lblDBStatus.Text = "DB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mtqstores.Properties.Resources.MTQ_logo;
            this.pictureBox1.Location = new System.Drawing.Point(572, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBServer.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDBServer.Location = new System.Drawing.Point(620, 368);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(104, 24);
            this.lblDBServer.TabIndex = 5;
            this.lblDBServer.Text = "DB Server";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 392);
            this.Controls.Add(this.lblDBServer);
            this.Controls.Add(this.lblDBStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGagues);
            this.Controls.Add(this.btnEquipments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquipments;
        private System.Windows.Forms.Button btnGagues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDBStatus;
        private System.Windows.Forms.Label lblDBServer;
    }
}