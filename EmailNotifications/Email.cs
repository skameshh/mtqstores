using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using mtqstores.Global;
namespace mtqstores.EmailNotifications
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }


        private int SendEmail(string emailFrom, string emailTo, string emailCc, string emailSubject, string emailBody, string emailAccount, string emailPassword)
        {


            try
            {
                //  var mailBody = "<div style=\"font-family: 'Times New Roman', Times, serif; text-decoration: underline; font-weight: bold\">" + ds.Tables[0].Rows[0]["HeaderMessage"] + "<br /></div>";
                var mailfrom = new MailAddress(emailFrom);
                // var mailto = new MailAddress(emailTo);             
              
                          
                var cclist = new List<string>();
                var newmsg = new MailMessage()
                {
                    Subject = emailSubject,
                    Body = emailBody,
                    IsBodyHtml = true,
                    From= mailfrom

                };

                if (!string.IsNullOrEmpty(emailCc))
                {
                    var toMuliId = emailCc.Split(',');
                    foreach (var ccEmail in toMuliId)
                    {
                        newmsg.CC.Add(new MailAddress(ccEmail));                      
                        //Adding Multiple BCC email Id
                    }

                }
                if (!string.IsNullOrEmpty(emailTo))
                {
                    var emaliTolist = emailTo.Split(',');
                    foreach (var ccEmail in emaliTolist)
                    {
                        newmsg.To.Add(new MailAddress(ccEmail));
                        //Adding Multiple BCC email Id
                    }

                }
                //For File Attachment, more file can also be attached
                //path = Session["Path"].ToString();
                //var fileAtt = new Attachment(Server.MapPath(path));
                //newmsg.Attachments.Add(fileAtt);



                if (ConfigurationManager.AppSettings["Mailoption"] == "1")
                {

                    var smtps = new SmtpClient(emailAccount,
                        int.Parse(emailPassword));
                    smtps.Send(newmsg);
                    return 1;
                }
                else
                {
                    //Test mail code  for local PC
                    var smtps = new SmtpClient
                    {
                        Host = ConfigurationManager.AppSettings["host"],
                        Port = int.Parse(ConfigurationManager.AppSettings["port"]),
                       EnableSsl = true,
                        UseDefaultCredentials = false,
                     //   Credentials =new System.Net.NetworkCredential("mtquser@outlook.com", "sgMTQ(*)638955")
                       Credentials = new System.Net.NetworkCredential(emailAccount, emailPassword)
                    };
                    smtps.Send(newmsg);
                    //smtps.
                    return 1;
                }

            }



            catch (Exception Ex)
            {


                return 0;

            }

        }

        private void SetupEmail()
        {
            var GaExpiry = int.Parse(ConfigurationManager.AppSettings["GaExpiry"].ToString());
            var dtFrom = DateTime.Now;
            var dtTo = DateTime.Now.AddMonths(GaExpiry);
            var theadr = "<div> <div class=\"row\"><div class=\"col - xs - 12\"> <h5 class=\"page - header\">Dear <small class=\"pull - right\"> QA Team  </h2> </div>  </div></div> <div class=\"row\">  <div class=\"col - xs - 12 table - responsive\">" +
                "<br />" +
                "<h4>Gagues Expiring List</h4>" +
                "<h4>From:" + dtFrom.ToShortDateString() + "</h4> <h4>To:" + dtTo.ToShortDateString() + "</h4>" +
                          " <table  border=\"1\" class=\"table table-striped\"> <thead> <tr> <th>#</th>  <th>Gage ID</th>  <th>Gage Desc</th>   <th>Gage Brand</th>  <th>Gage_Rang</th><th>Gage SlNo</th><th>Expiry Date</th></tr>  </thead>" +

                          "<tbody> ";
            var tbody = "";

            var sqlbody = loadGagueExpire();
            foreach (DataRow row in sqlbody.Rows)
            {
                if (tbody.Length<=0)
                    tbody = " <tr> <td>'" + row["id"].ToString() + "'</td><td>'" + row["gage_id"].ToString() + "'</td> <td>'" + row["gage_desc"].ToString() + "'</td><td>'" + row["gage_brand"].ToString() + "'</td><td>'" + row["gage_rance"].ToString() + "'</td><td>'" + row["gage_slno"].ToString() + "'</td><td>'" + row["calib_due_date"].ToString() + "'</td> </tr>";
          else
                    tbody = tbody+" <tr> <td>'" + row["id"].ToString() + "'</td><td>'" + row["gage_id"].ToString() + "'</td> <td>'" + row["gage_desc"].ToString() + "'</td><td>'" + row["gage_brand"].ToString() + "'</td><td>'" + row["gage_rance"].ToString() + "'</td><td>'" + row["gage_slno"].ToString() + "'</td><td>'" + row["calib_due_date"].ToString() + "'</td> </tr>";
            }

            var table = theadr + tbody + "</tbody> " + "</ table >";

            var EquListtable = "<br />" +
                "<h4>Equipment Expiring List</h4>" +
                "<h4>From:" + dtFrom.ToShortDateString() + "</h4> <h4>To:" + dtTo.ToShortDateString() + "</h4>" +
                          " <table  border=\"1\" class=\"table table-striped\"> <thead> <tr> <th>#</th>  <th>Tag No</th>  <th>Department</th>   <th>Description</th>  <th>Type</th><th>SWL</th><th>Expiry Date</th></tr>  </thead>" +

                          "<tbody> ";
            var Equtbody = "";

            var sqlEqbody = loadDG();
            foreach (DataRow row in sqlEqbody.Rows)
            {
                if (Equtbody.Length <= 0)
                    tbody = " <tr> <td>'" + row["id"].ToString() + "'</td><td>'" + row["tag_no"].ToString() + "'</td> <td>'" + row["dept"].ToString() + "'</td><td>'" + row["description"].ToString() + "'</td><td>'" + row["type"].ToString() + "'</td><td>'" + row["swl"].ToString() + "'</td><td>'" + row["exp_date"].ToString() + "'</td> </tr>";
                else
                    Equtbody = Equtbody + " <tr> <td>'" + row["id"].ToString() + "'</td><td>'" + row["tag_no"].ToString() + "'</td> <td>'" + row["dept"].ToString() + "'</td><td>'" + row["description"].ToString() + "'</td><td>'" + row["type"].ToString() + "'</td><td>'" + row["swl"].ToString() + "'</td><td>'" + row["exp_date"].ToString() + "'</td> </tr>";
                
            }

            var Eqtable = EquListtable + Equtbody + "</tbody> " + "</ table >";

            if (sqlEqbody.Rows.Count > 0)
                table = table + Eqtable;
            var Emaillist = GetEmailList();
            var emailTo = "";
            foreach (DataRow row in Emaillist.Rows)
            {
                if (emailTo.Length <= 0)
                    emailTo = row["Email"].ToString();
                else
                    emailTo= emailTo+","+ row["Email"].ToString();
            }


                SendEmail(ConfigurationManager.AppSettings["FromEmail"].ToString(), emailTo, "", "Expiring List", table, ConfigurationManager.AppSettings["emailAccount"].ToString(), ConfigurationManager.AppSettings["emailPassword"].ToString());


        }



        private DataTable loadDG()
        {
            String sql = "select id, tag_no,  dept, description, type,swl, exp_date  from t_equipments ";
            try
            {
                var GaExpiry = int.Parse(ConfigurationManager.AppSettings["GaExpiry"].ToString());
                var dtFrom = DateTime.Now;
                var dtTo = DateTime.Now.AddMonths(GaExpiry);
                var dt = new DataTable();


                //date
               
                if (sql.Contains("where "))
                {
                    sql = sql + " and exp_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and exp_date<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }
                else
                {
                    sql = sql + " where  exp_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and exp_date<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }


                //
                sql = sql + " order by id desc";
              

                using (MySqlConnection conn = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd))
                        {
                            try
                            {
                               
                                sqlDa.Fill(dt);
                              

                            }
                            catch (Exception ee)
                            {
                                //log.Error("Error in row " + ee.Message);
                            }
                        }
                    }
                }

                return dt;
            }
            catch (Exception ee)
            {
                return null;
            }
        }






        private DataTable loadGagueExpire()
        {
            var sql = "select id, gage_id, gage_desc, gage_brand,  gage_rance, gage_slno, calib_due_date  from t_gagues ";
            try
            {
                //date
                var GaExpiry =int.Parse( ConfigurationManager.AppSettings["GaExpiry"].ToString());
                var dtFrom = DateTime.Now;
                var dtTo = DateTime.Now.AddMonths(GaExpiry);
                var dt = new DataTable();
                if (sql.Contains("where "))
                {
                    sql = sql + " and calib_due_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and calib_due_date<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }
                else
                {
                    sql = sql + " where  calib_due_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and calib_due_date<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }


                //
                sql = sql + " order by id desc";
               

                using (MySqlConnection conn = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd))
                        {
                            try
                            {
                              
                                sqlDa.Fill(dt);                        
                          
                             

                            }
                            catch (Exception ee)
                            {
                                
                            }
                        }
                    }
                }

                return dt;
            }
            catch (Exception ee)
            {
                return null;  
            }
        }


        private DataTable GetEmailList()
        {
            var sql = "SELECT  Email  FROM  t_emp    WHERE  IsNotfication=1 ";
            try
            {
                //date
               
                var dt = new DataTable();        
              

                using (MySqlConnection conn = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd))
                        {
                            try
                            {

                                sqlDa.Fill(dt);



                            }
                            catch (Exception ee)
                            {

                            }
                        }
                    }
                }

                return dt;
            }
            catch (Exception ee)
            {
                return null;
            }
        }



        private void Email_Load(object sender, EventArgs e)
        {
           // SetupEmail();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            SetupEmail();
        }
    }
}
