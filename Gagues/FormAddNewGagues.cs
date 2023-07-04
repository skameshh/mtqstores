using mtqstores.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace mtqstores.Gagues
{
    public partial class FormAddNewGagues : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private string action = "edit";
        private GaguesDao dao = null;

        public FormAddNewGagues(GaguesDao dao)
        {
            InitializeComponent();
            this.dao = dao;
            init();


            if (dao != null)
            {
                action = "edit";
                try
                {
                    lblMainTitle.Text = "Update / Delete Equipment";
                    txtGaugeId.Enabled = false;
                    btnClear.Enabled = false;
                    btnDelete.Enabled = true;

                    action = "edit";


                    lblId.Text = dao.Id + "";
                    txtGaugeId.Text = dao.GageId;
                    txtDesc.Text = dao.GageDesc;
                    cboBrand.Text = dao.GageBrand;
                    cboGaugeRange.Text = dao.GageRance;
                    txtGaugeSlNo.Text = dao.GageSlNo;
                    cboCalibMethod.Text = dao.GageCalibMethod;
                    txtTolerance.Text = dao.Tolerance;
                    cboGaugeLocation.Text = dao.GageLocation;
                    txtTolerance.Text = dao.Remarks;

                    cboQty.Text = dao.Qty+"";
                    dtpCalibDate.Value = dao.CalibDate;
                    try
                    {
                        cboCalibMonths.Text = Convert.ToString(dao.CalibInterval);
                    }catch(Exception ee)
                    {
                        log.Error("Eror calib months =  " + ee.Message);
                    }

                    try
                    {
                        lblDueDate.Text = dao.CalibDueDate.ToString("yyyy-MM-dd");
                        doCalculateDueDate();

                    }
                    catch(Exception ee)
                    {
                        log.Error("EE " + ee.Message);
                    }

                    cboCalibAgency.Text = dao.CalibAgency;
                    txtCalibCertNo.Text = dao.CalibCertNo;
                    txtMasterGaugeCertNo.Text = dao.MasterGageCertNo;
                    txtMasterGaugeSlNo.Text = dao.MasterGageSlNo;

                    txtComments.Text = dao.Comments;

                    if (dao.MasterGageValidDate.Year > 2000)
                    {
                        dtpMasterGaugeValidDate.Value = dao.MasterGageValidDate;
                    }
                    else
                    {
                        dtpMasterGaugeValidDate.Value = DateTime.MinValue;
                    }                  


                    //dtpExpDate.Value = dao.ExpDate;
                }
                catch (Exception ee)
                {
                    log.Error("Error " + ee.Message);
                }
            }
            else
            {
                //add new equip
                lblMainTitle.Text = "Add New Gauge";
                action = "add";
                btnDelete.Enabled = false;
            }

        }//constructor


        private void init()
        {
            //loading brands===
            ArrayList lst_brands = DBUtils.getAllGageBrand();
            for (int x = 0; x < lst_brands.Count; x++)
            {
                String dept = (String)lst_brands[x];
                cboBrand.Items.Add(dept);
            }

            //loading gage range===
            ArrayList lst_type = DBUtils.getAllGageRange();
            for (int x = 0; x < lst_type.Count; x++)
            {
                String item_type = (String)lst_type[x];
                cboGaugeRange.Items.Add(item_type);
            }

            //===calib method ===
            ArrayList lst_swl = DBUtils.getAllGageCalibMethod();
            for (int x = 0; x < lst_swl.Count; x++)
            {
                String swl = (String)lst_swl[x];
                cboCalibMethod.Items.Add(swl);
            }

            //===gage location ===
            ArrayList lst_gage_location = DBUtils.getAllGageLocations();
            for (int x = 0; x < lst_gage_location.Count; x++)
            {
                String swl = (String)lst_gage_location[x];
                cboGaugeLocation.Items.Add(swl);
            }


            //===gage calib agency ===
            ArrayList lst_gage_agency = DBUtils.getAllGageCalibAgency();
            for (int x = 0; x < lst_gage_agency.Count; x++)
            {
                String swl = (String)lst_gage_agency[x];
                cboCalibAgency.Items.Add(swl);
            }
        }



        private void doSave()
        {
            GaguesDao dao = new GaguesDao();
            dao.Remarks = txtTolerance.Text;
            dao.GageSlNo = txtGaugeSlNo.Text;
            dao.GageDesc = txtDesc.Text;
            dao.CalibAgency = cboCalibAgency.Text;
            dao.GageId = txtGaugeId.Text;
            dao.GageRance = cboGaugeRange.Text;
            dao.GageBrand = cboBrand.Text;
            dao.CalibDate = DateTime.Parse( lblDueDate.Text);
            // dao.AvailQty = txtA;
            try
            {
              string ss = (string)cboQty.Text;
                log.Info("Qty = " + ss);
                dao.Qty = Convert.ToInt32(ss);
            }
            catch (Exception ee)
            {
                log.Error("Ee qty = " + ee.Message);
            }

            dao.AddedOn = DateTime.Now;           
            dao.CalibCertNo = txtCalibCertNo.Text ;
            dao.CalibDate = dtpCalibDate.Value;
            //dao.CalibDueDate = ;
            string inter = (string)cboCalibMonths.SelectedItem;
            dao.CalibInterval = Convert.ToInt32(inter);
            dao.CalibIntervalUnit = "Months" ;
            dao.Comments = txtComments.Text;
            dao.GageCalibMethod = cboCalibMethod.Text;            
            dao.MasterGageCertNo = txtMasterGaugeCertNo.Text;
            dao.MasterGageSlNo = txtMasterGaugeSlNo.Text;
            dao.MasterGageValidDate = dtpMasterGaugeValidDate.Value;
            dao.GageLocation = cboGaugeLocation.Text;
            dao.Tolerance = txtTolerance.Text;

            if (action == "add")
            {
                bool bb = DBUtils.doAddGaguges(dao);
                if (bb)
                {
                    MessageBox.Show("Add success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Add failed");
                }

            }
            else if (action == "edit")
            {
                dao.Id =  Convert.ToInt32(lblId.Text);
                bool bb = DBUtils.doUpdateGagues(dao);
                if (bb)
                {
                    MessageBox.Show("Update success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }



        private void doClear()
        {
            txtDesc.Text = "";
            txtGaugeSlNo.Text = "";
            txtTolerance.Text = "";
            txtGaugeId.Text = "";
            txtComments.Text = "";
            txtGaugeSlNo.Text = "";
            txtMasterGaugeCertNo.Text = "";
            txtMasterGaugeSlNo.Text = "";
            txtRemarks.Text = "";
            txtTolerance.Text = "";
            txtCalibCertNo.Text = "";

            cboCalibAgency.Text = "";
            cboGaugeRange.Text = "";
            cboBrand.Text = "";
            cboCalibMonths.Text = "";
            cboQty.Text = "";

        }

        private void doDelete()
        {
            DialogResult res = MessageBox.Show("Are you sure to delete, It will send email to the team ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                int id = Int32.Parse(lblId.Text);
                bool bb = DBUtils.doDeleteEquipment(id);
                if (bb)
                {
                    MessageBox.Show("Delete success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }

        private void doCalculateDueDate()
        {
            DateTime caldate = dtpCalibDate.Value;
            string ss = (string)cboCalibMonths.Text;
            int interval = Convert.ToInt32(ss);
            DateTime duedate =  caldate.AddMonths(interval);
            lblDueDate.Text = duedate.ToString("yyyy-MM-dd");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            doClear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            doDelete();
        }

        private void cboCalibMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            doCalculateDueDate();
        }

        private void cmdUpoload_Click(object sender, EventArgs e)
        {
            string saveDirectory = ConfigurationManager.AppSettings["CertificateFielpath"].ToString();


            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {


                    //if (!Directory.Exists(saveDirectory))
                    //{
                    //    Directory.CreateDirectory(saveDirectoryxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    //}

                    
                    string fileName = Path.GetFileName(openFileDialog1.FileName);
                    txtCalibCertNo.Text = fileName;
                    string fileSavePath = Path.Combine(saveDirectory, fileName);
                    if (File.Exists(fileSavePath))
                    {
                        File.Delete(fileSavePath);
                    }

                                       
                    File.Copy(openFileDialog1.FileName, fileSavePath, true);
                  
                }
            }
        }

        private void cmdDownoad_Click(object sender, EventArgs e)
        {
            try
            {
                string saveDirectory = ConfigurationManager.AppSettings["CertificateFielpath"].ToString();           
                var filename = txtCalibCertNo.Text;
                var filepath = saveDirectory + filename;                
                System.Diagnostics.Process.Start(filepath);
                //var objPdfview = new PdfViwer(filepath);
                //objPdfview.ShowDialog();
            }
            catch
            {
               

                //To Do
            }
        }
    }
}
