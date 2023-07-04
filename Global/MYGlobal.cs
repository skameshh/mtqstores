using mtqstores.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtqstores.Global
{
    public class MYGlobal
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static string VERSION = "v1.2.0";

        public static UserDao loggedInUserDao = null;
        public static int loggedInUser_Id = 0;
        public static string MYSQL_SERVER = string.Empty;

        public static string getMySqlCString()
        {

            string server = GetSettingValue("MYSQL_SERVER_HOST"); ;//"localhost"; 
            string port = GetSettingValue("MYSQL_SERVER_PORT");
            string db = GetSettingValue("MYSQL_SERVER_DB");
            string user = GetSettingValue("MYSQL_SERVER_USER");
            string pwd = GetSettingValue("MYSQL_SERVER_PWD");
            //  return "server=" + server + ";user=root;pwd=;database=ocstoolinventorymgmt;persistsecurityinfo=True;SslMode=none;Convert Zero Datetime=True;Allow Zero Datetime=True";

            MYSQL_SERVER = server;

            return "server=" + server + ";user="+ user + ";pwd="+ pwd + ";database="+ db + ";persistsecurityinfo=True;SslMode=none;Convert Zero Datetime=True;Allow Zero Datetime=True";

        }

        public static string GetSettingValue(string paramName)
        {
            return String.Format(ConfigurationManager.AppSettings[paramName]);
        }

        public static bool checkConnection()
        {
            string sql = "select * from t_user limit 10";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(getMySqlCString()))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                         using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                int userid = (int)reader["user_id"];
                                string name = (string)reader["name"];

                                log.Info("Connection success got user " + userid + ", name=" + name);
                            }

                            return true;
                        }
                           
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Connection failed");
                log.Info("Error " + ee.Message);
                return false;
            }
           
            
        }


        public static void doButtonEnabled(Button btn, bool ok)
        {
            if (ok == true)
            {
                btn.Enabled = true;
                btn.BackColor = Color.DarkBlue;
            }
            else
            {
                btn.BackColor = Color.LightGray;
                btn.Enabled = false;
            }
        }

        public static void export2Excel(DataGridView dataGridView, String name)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "" + name;
                // storing header part in Excel  
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    //for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
                    //{
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                       // worksheet.Cells[1, i+1] = dataGridView.Columns[i+1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count-1; j++)
                    {
                        try
                        {
                            if(dataGridView.Rows[i].Cells[j].Value!=null)
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        catch (Exception ee)
                        {
                            log.Error(" " + ee.Message);
                        }
                    }
                }

                //"c:\\temp\\tpc\\output.xlsx"
                // save the application  
                workbook.SaveAs("c:\\temp\\meie\\" + name + "-" + getCurretnDate() + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  

                //MessageBox.Show("");

                app.Quit();
            }
            catch (Exception ee)
            {
                log.Error("Export Excel Error " + ee.Message);
            }
        }

        public static void export2AuditorList(DataGridView dataGridView, String name)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "" + name;
                // storing header part in Excel  
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    //for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
                    //{
                    var AuditorHeader = dataGridView.Columns[i - 1].HeaderText;
                    if ((AuditorHeader== "gage_id" ) || (AuditorHeader == "id"))
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    // worksheet.Cells[1, i+1] = dataGridView.Columns[i+1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count - 1; j++)
                    {
                        try
                        {
                            var AuditorHeader = dataGridView.Columns[i - 1].HeaderText;
                            if ((dataGridView.Rows[i].Cells[j].Value != null) && ((AuditorHeader == "gage_id") || (AuditorHeader == "id")))

                                worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        catch (Exception ee)
                        {
                            log.Error(" " + ee.Message);
                        }
                    }
                }

                //"c:\\temp\\tpc\\output.xlsx"
                // save the application  
                workbook.SaveAs("c:\\temp\\meie\\" + name + "-" + getCurretnDate() + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  

                //MessageBox.Show("");

                app.Quit();
            }
            catch (Exception ee)
            {
                log.Error("Export Excel Error " + ee.Message);
            }
        }

        public static String getCurretnDate()
        {
            DateTime dateTime = DateTime.Today;
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static String getCurretnDateTime()
        {
            DateTime dateTime = DateTime.Today;
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static String getCurretnTime()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("HH:mm:ss");
        }



        public static String htmlAlertBar()
        {
            return "<font size=\"2\" style=\"font-family:Calibri; \" >" +
                " <table border=\'0\' width=\'100%\' cellpadding=\"6\" cellspacing=\"2\"  style =\"color:#FFFFff\"> " +
                       " <tr ><td align=\'center\' bgcolor=\"#43494E\" style =\"color:#FFFFff\"> Generated by the system </td>  </tr>" +
                                                "</table></font >";
        }

        public static String getEmailFooterHTML()
        {

            return "<font color =\'#43494E\' style=\"font-family:\'sans-serif\';\">  <P>Thanks,  <br>  </font>";
        }

        public static String HTML_BEGIN = "<html><body> ";
        public static String HTML_END = "</body> </html>";

        public static void sendHALSMTPEmail(String fromEmail, String who, String subject, String to, String cc, String bcc, String message)
        {

            var smtpClient = new SmtpClient("mail.mtq.com.sg")
            {
                Port = 25,
                Credentials = new NetworkCredential("noreply.MTQApp@mtq.com.sg", "ABC123"),
                EnableSsl = false,
            };


            String wish_user = "<p> <font color =\'#43494E\'  style=\"font-family:\'sans-serif\';\"> Dear " + who + ",</font></p> ";
            String add_msg = "<p> " + message + " </p>" + getEmailFooterHTML() + htmlAlertBar();//+ getEmailFooterHTML()
            String html_body = HTML_BEGIN + htmlAlertBar() + wish_user;
            html_body = html_body + add_msg;
            html_body = html_body + HTML_END;

            log.Info("html_body = " + html_body);

            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = subject,
                Body = html_body,// "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            ArrayList al = new ArrayList();
            //mailMessage.To.Add("kamesh.shankaran@halliburton.com");


            mailMessage.To.Add(to);

            try
            {
                if (cc != null && cc.Length > 0)
                {
                    string[] allcc = cc.Split(';');
                    for (int x = 0; x < allcc.Length; x++)
                    {
                        string em = (string)allcc[x];
                        if (em.Length > 5)
                        {
                            mailMessage.CC.Add(em);
                        }

                    }

                }
            }
            catch (Exception ee)
            {
                log.Error("CC is null " + ee.Message);
            }

            try
            {
                if (bcc != null && bcc.Length > 0)
                {
                    //mailMessage.Bcc.Add(bcc);
                    string[] allbcc = bcc.Split(';');
                    for (int x = 0; x < allbcc.Length; x++)
                    {
                        string em = (string)allbcc[x];
                        if (em.Length > 5)
                        {
                            mailMessage.Bcc.Add(em);
                        }

                    }

                }
            }
            catch (Exception ee)
            {
                log.Error("BCC is null " + ee.Message);
            }


            //final send email
            smtpClient.Send(mailMessage);

        }












    }
}
