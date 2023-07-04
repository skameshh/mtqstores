using mtqstores.Global;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtqstores.DB
{
    public class DBUtils
    {

        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);




        public static bool doAddUser(UserDao tpdao)
        {
            try
            {
                String sql = "insert into  t_user (user_id, password,  name, dept) values(@userid, @pwd, @name, @dept)";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateUser()  userId = " + tpdao.UserId);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@userid", tpdao.UserId);
                        cmd.Parameters.AddWithValue("@name", tpdao.Name);
                        cmd.Parameters.AddWithValue("@pwd", tpdao.UserId);
                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                                             


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateUser() :" + ee.Message);
                return false;
            }
        }




        public static bool doUpdateUser(UserDao tpdao)
        {
            try
            {
                String sql = "update t_user set name=@name, dept=@dept where id=@id" ;

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateUser()  userId = " + tpdao.UserId);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@name", tpdao.Name);
                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                       
                        cmd.Parameters.AddWithValue("@id", tpdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateUser() :" + ee.Message);
                return false;
            }
        }


        public static ArrayList getUsersByDept(string dept)
        {
            ArrayList al = new ArrayList();
            string sql = string.Empty;

            if (dept.Equals("All") || dept==null)
            {
                sql = "select * from t_user order by ud desc " ;
            }
            else
            {
                sql = "select * from t_user where dept='" + dept + "'";
            }


            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getUsersByDept()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserDao dao = new UserDao();
                                try
                                {
                                    dao.Id = (int)reader["id"];

                                    if ((reader["user_id"]) != DBNull.Value)
                                    {
                                        dao.UserId = ((int)reader["user_id"]);
                                    }

                                    if ((reader["password"]) != DBNull.Value)
                                    {
                                        dao.Password = ((string)reader["password"]);
                                    }

                                    if ((reader["name"]) != DBNull.Value)
                                    {
                                        dao.Name = ((string)reader["name"]);
                                    }

                                    if ((reader["dept"]) != DBNull.Value)
                                    {
                                        dao.Dept = ((string)reader["dept"]);
                                    }

                                    al.Add(dao);
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getUserByUserId = " + ee.Message);

                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getUsersByDept " + ee.Message);
            }

            return al;
        }



        public static UserDao getUserByUserId(string userid, int id)
        {
            UserDao dao = null;
            string sql = string.Empty;

            if (id > 0)
            {
                sql = "select * from t_user where  id=" + id ;
            }
            else
            {
                sql = "select * from t_user where user_id='" + userid + "'";
            }
             

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getUserByUserId()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dao = new UserDao();
                                try
                                {
                                    dao.Id = (int)reader["id"];

                                    if ((reader["user_id"]) != DBNull.Value)
                                    {
                                        dao.UserId = ((int)reader["user_id"]);
                                    }

                                    if ((reader["password"]) != DBNull.Value)
                                    {
                                        dao.Password = ((string)reader["password"]);
                                    }

                                    if ((reader["name"]) != DBNull.Value)
                                    {
                                        dao.Name = ((string)reader["name"]);
                                    }

                                    if ((reader["dept"]) != DBNull.Value)
                                    {
                                        dao.Dept = ((string)reader["dept"]);
                                    }


                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getUserByUserId = " + ee.Message);
                                    
                                }
                            }
                        }
                       
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error " + ee.Message);
            }

            return dao;
        }


        //================== Equipments =====================//

        public static EquipmentDao getEqupmentForTagId(int id, string tag)
        {
            EquipmentDao dao = null;
            string sql = string.Empty;
            if (id > 0)
            {
                sql = "select * from t_equipments where id=" + id  ;
            }
            else
            {
                sql = "select * from t_equipments where tag_no='" + tag + "'";
            }
             

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getEqupmentForTagId()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dao = new EquipmentDao();
                                dao.Id = (int)reader["id"];
                                try
                                {
                                    if ((reader["tag_no"]) != DBNull.Value)
                                    {
                                        dao.TagNo=((string)reader["tag_no"]);
                                    }

                                    if ((reader["description"]) != DBNull.Value)
                                    {
                                        dao.Description = ((string)reader["description"]);
                                    }

                                    if ((reader["swl"]) != DBNull.Value)
                                    {
                                        dao.Swl = ((string)reader["swl"]);
                                    }

                                    if ((reader["length"]) != DBNull.Value)
                                    {
                                        dao.Length = ((string)reader["length"]);
                                    }

                                    if ((reader["qty"]) != DBNull.Value)
                                    {
                                        dao.Qty = ((int)reader["qty"]);
                                    }

                                    if ((reader["avail_qty"]) != DBNull.Value)
                                    {
                                        dao.AvailQty = ((int)reader["avail_qty"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getEqupmentForTagId = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error " + ee.Message);
            }

            return dao;
        }


        public static ArrayList getAllEqupmentsDepts()
        {
            ArrayList al = new ArrayList();
            string sql = "select dept from t_equipments group by dept order by dept asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllDepts()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["dept"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["dept"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllDepts = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error " + ee.Message);
            }

            return al;
        }

        public static ArrayList getAllSWL()
        {
            ArrayList al = new ArrayList();
            string sql = "select swl from t_equipments group by swl order by swl asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllSWL()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["swl"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["swl"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllSWL = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error " + ee.Message);
            }

            return al;
        }


        public static ArrayList getAllEqupmentsType()
        {
            ArrayList al = new ArrayList();
            string sql = "select type from t_equipments group by type order by type asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllEqupmentsType()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["type"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["type"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllEqupmentsType = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error " + ee.Message);
            }

            return al;
        }

         
        public static bool doUpdateEquipment(EquipmentDao tpdao)
        {
            try
            {
                String sql = "update t_equipments set dept=@dept, description=@description, type=@type, tag_no=@tag_no, " +
                    " swl=@swl,length=@length, exp_date=@exp_date, remarks=@remarks, " +
                    "   updated_by=@updated_by, updated_on=@updated_on  " +
                    " where id=@id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateEquipment()  materialNum = " + tpdao.TagNo);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                        cmd.Parameters.AddWithValue("@description", tpdao.Description);
                        cmd.Parameters.AddWithValue("@type", tpdao.Type);
                        cmd.Parameters.AddWithValue("@tag_no", tpdao.TagNo);
                        cmd.Parameters.AddWithValue("@swl", tpdao.Swl);
                        cmd.Parameters.AddWithValue("@length", tpdao.Length);
                        cmd.Parameters.AddWithValue("@exp_date", tpdao.ExpDate);
                        cmd.Parameters.AddWithValue("@remarks", tpdao.Remarks);

                        //cmd.Parameters.AddWithValue("@added_by", "");
                       // cmd.Parameters.AddWithValue("@added_on", DateTime.Now);

                        cmd.Parameters.AddWithValue("@updated_by", "user");
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", tpdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipment() :" + ee.Message);
                return false;
            }
        }

        public static bool doUpdateImportEquipment(EquipmentDao tpdao)
        {
            try
            {
                String sql = "update t_equipments set dept=@dept, description=@description, type=@type, " +
                    " swl=@swl,length=@length, exp_date=@exp_date, remarks=@remarks, " +
                    "   updated_by=@updated_by, updated_on=@updated_on,qty=qty+@qty,avail_qty=avail_qty+@avail_qty  " +
                    " where tag_no=@tag_no";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateEquipment()  materialNum = " + tpdao.TagNo);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                        cmd.Parameters.AddWithValue("@description", tpdao.Description);
                        cmd.Parameters.AddWithValue("@type", tpdao.Type);
                        cmd.Parameters.AddWithValue("@tag_no", tpdao.TagNo);
                        cmd.Parameters.AddWithValue("@swl", tpdao.Swl);
                        cmd.Parameters.AddWithValue("@length", tpdao.Length);
                        cmd.Parameters.AddWithValue("@exp_date", tpdao.ExpDate);
                        cmd.Parameters.AddWithValue("@remarks", tpdao.Remarks);
                        cmd.Parameters.AddWithValue("@qty", tpdao.Qty);
                        cmd.Parameters.AddWithValue("@avail_qty", tpdao.AvailQty);
                        //cmd.Parameters.AddWithValue("@added_by", "");
                        // cmd.Parameters.AddWithValue("@added_on", DateTime.Now);

                        cmd.Parameters.AddWithValue("@updated_by", "user");
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", tpdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipment() :" + ee.Message);
                return false;
            }
        }
        public static bool doUpdateEquipmentAvailQty(int id, int avail_qty)
        {
            try
            {
                String sql = "update t_equipments set avail_qty=@avail_qty " +                   
                    " where id=@id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateEquipment()  id = " + id + ", avail_qty="+ avail_qty);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@avail_qty", avail_qty); 
                        cmd.Parameters.AddWithValue("@id",id);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipment() :" + ee.Message);
                return false;
            }
        }

        public static bool doAddEquipment(EquipmentDao tpdao)
        {
            try
            {
                String sql = "insert into t_equipments (dept, description, type, tag_no, " +
                    " swl, length, exp_date, remarks,  " +
                    "   updated_by, updated_on , added_by, added_on)  values( @dept, @description, @type, @tag_no, @swl," +
                    "@length, @exp_date, @remarks, @updated_by, @updated_on, @added_by, @added_on)  ";


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doAddEquipment()  materialNum = " + tpdao.TagNo + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                        cmd.Parameters.AddWithValue("@description", tpdao.Description);
                        cmd.Parameters.AddWithValue("@type", tpdao.Type);
                        cmd.Parameters.AddWithValue("@tag_no", tpdao.TagNo);
                        cmd.Parameters.AddWithValue("@swl", tpdao.Swl);
                        cmd.Parameters.AddWithValue("@length", tpdao.Length);
                        cmd.Parameters.AddWithValue("@exp_date", tpdao.ExpDate);
                        cmd.Parameters.AddWithValue("@remarks", tpdao.Remarks);
                        cmd.Parameters.AddWithValue("@updated_by", "user");
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@added_by", "user");
                        cmd.Parameters.AddWithValue("@added_on", DateTime.Now);
                        //cmd.Parameters.AddWithValue("@id", tpdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doAddEquipment() :" + ee.Message);
                return false;
            }
        }

        public static bool doAddImportEquipment(EquipmentDao tpdao)
        {
            try
            {
                String sql = "insert into t_equipments (dept, description, type, tag_no, " +
                    " swl, length, exp_date, remarks,  " +
                    "   updated_by, updated_on , added_by, added_on,qty,avail_qty)  values( @dept, @description, @type, @tag_no, @swl," +
                    "@length, @exp_date, @remarks, @updated_by, @updated_on, @added_by, @added_on,@qty,@avail_qty)  ";


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doAddEquipment()  materialNum = " + tpdao.TagNo + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@dept", tpdao.Dept);
                        cmd.Parameters.AddWithValue("@description", tpdao.Description);
                        cmd.Parameters.AddWithValue("@type", tpdao.Type);
                        cmd.Parameters.AddWithValue("@tag_no", tpdao.TagNo);
                        cmd.Parameters.AddWithValue("@swl", tpdao.Swl);
                        cmd.Parameters.AddWithValue("@length", tpdao.Length);
                        cmd.Parameters.AddWithValue("@exp_date", tpdao.ExpDate);
                        cmd.Parameters.AddWithValue("@remarks", tpdao.Remarks);
                        cmd.Parameters.AddWithValue("@updated_by", "user");
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@added_by", "user");
                        cmd.Parameters.AddWithValue("@added_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@qty", tpdao.Qty);
                        cmd.Parameters.AddWithValue("@avail_qty", tpdao.AvailQty);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doAddEquipment() :" + ee.Message);
                return false;
            }
        }


        public static bool doDeleteEquipment(int id)
        {
            try
            {
                String sql = "delete from t_equipments where id=@id ";


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doDeleteEquipment()  id = " + id + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id", id);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doDeleteEquipment() :" + ee.Message);
                return false;
            }
        }

        //  ==================== TRANS HISTORY ============

        public static bool doAddEquipmentTransHistory(EquipmentTransHistoryDao tpdao)
        {
            String sql = string.Empty;
            try
            {
                if (tpdao.BorrowedBy > 0)
                {
                    sql = "insert into t_equip_trans (equip_tag, borrowed_by,   borrowed_on, borrow_comments,StatusStr,StatusRemark " +
                        "  )  values( @equip_tag, @borrowed_by,  @borrowed_on, @borrow_comments,@StatusStr,@StatusRemark" +
                        " )  ";
                }
                else
                {
                    sql = "insert into t_equip_trans (equip_tag,  returned_by,  " +
                        "   returned_on, return_comments,StatusStr,StatusRemark )  values( @equip_tag, @returned_by, " +
                        " @returned_on, @return_comments,@StatusStr,@StatusRemark)  ";
                }


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doAddEquipmentTransHistory()  materialNum = " + tpdao.EquipTag + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@equip_tag", tpdao.EquipTag);
                        cmd.Parameters.AddWithValue("@borrowed_by", tpdao.BorrowedBy);
                        cmd.Parameters.AddWithValue("@returned_by", tpdao.ReturnedBy);
                        if (tpdao.BorrowedBy > 0)
                        {
                            cmd.Parameters.AddWithValue("@borrowed_on", tpdao.BorrowedOn);
                            cmd.Parameters.AddWithValue("@borrow_comments", tpdao.BorrowComments);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@returned_on", tpdao.RequrnedOn);
                            cmd.Parameters.AddWithValue("@return_comments", tpdao.ReturnedComments);
                        }
                        cmd.Parameters.AddWithValue("@StatusStr", tpdao.StatusStr);
                        cmd.Parameters.AddWithValue("@StatusRemark", tpdao.StatusRemark);



                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doAddEquipmentTransHistory() :" + ee.Message);
                return false;
            }
        }


        public static bool doUpdateEquipmentTransHistory(EquipmentTransHistoryDao tpdao)
        {
            string sql = string.Empty;

            try
            {
                if (tpdao.ReturnedBy > 0)
                {
                    sql = "update t_equip_trans set   returned_by=@returned_by, " +
                                       "   returned_on=@returned_on, return_comments=@return_comments , status=@status,StatusStr=@StatusStr,StatusRemark=@StatusRemark  where id=@Id";
                }
                else
                {
                    sql = "update t_equip_trans set borrowed_by=@borrowed_by,   borrowed_on=@borrowed_on," +
                   " borrow_comments=@borrow_comments , status=@status ,StatusStr=@StatusStr,StatusRemark=@StatusRemark where id=@Id";
                }
                 


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateEquipmentTransHistory()  materialNum = " + tpdao.EquipTag + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", tpdao.Id);
                        cmd.Parameters.AddWithValue("@status", tpdao.Status);

                        if (tpdao.ReturnedBy > 0)
                        {                           
                            cmd.Parameters.AddWithValue("@returned_on", tpdao.RequrnedOn);
                            cmd.Parameters.AddWithValue("@returned_by", tpdao.ReturnedBy);
                            cmd.Parameters.AddWithValue("@return_comments", tpdao.ReturnedComments);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@borrowed_by", tpdao.BorrowedBy);
                            cmd.Parameters.AddWithValue("@borrowed_on", tpdao.BorrowedOn);
                            cmd.Parameters.AddWithValue("@borrow_comments", tpdao.BorrowComments);
                        }
                        cmd.Parameters.AddWithValue("@StatusStr", tpdao.StatusStr);
                        cmd.Parameters.AddWithValue("@StatusRemark", tpdao.StatusRemark);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipmentTransHistory() :" + ee.Message);
                return false;
            }
        }

        public static ArrayList getAEquipTransHistory(string equiptag)
        {
            ArrayList al = new ArrayList();
            string sql = "select * from t_equip_trans where equip_tag='"+ equiptag + "' and status=0";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAEquipTransHistory()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EquipmentTransHistoryDao dao = new EquipmentTransHistoryDao();
                                dao.Id = (int)reader["id"] ;
                                try
                                {
                                    if ((reader["borrow_comments"]) != DBNull.Value)
                                    {
                                        dao.BorrowComments = (string)reader["borrow_comments"];
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAEquipTransHistory = " + ee.Message);
                                    continue;
                                }

                                al.Add(dao);
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAEquipTransHistory " + ee.Message);
            }

            return al;
        }

        //================== GAGUES ========================== //

        public static ArrayList getAllCalibAgency()
        {
            ArrayList al = new ArrayList();
            string sql = "select clib_agency from t_gagues group by clib_agency order by clib_agency asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllCalibAgency()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["clib_agency"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["clib_agency"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllCalibAgency = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllCalibAgency " + ee.Message);
            }

            return al;
        }

        public static GaguesDao getGagueForTagId(int id, string tag)
        {
            GaguesDao dao = null;
            string sql = string.Empty;
            if (id > 0)
            {
                sql = "select * from t_gagues where id=" + id;
            }
            else
            {
                sql = "select * from t_gagues where gage_id='" + tag + "'";
            }


            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getGagueForTagId()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dao = new GaguesDao();
                                dao.Id = (int)reader["id"];
                                try
                                {
                                    if ((reader["gage_id"]) != DBNull.Value)
                                    {
                                        dao.GageId = ((string)reader["gage_id"]);
                                    }

                                    if ((reader["gage_desc"]) != DBNull.Value)
                                    {
                                        dao.GageDesc = ((string)reader["gage_desc"]);
                                    }

                                    

                                    if ((reader["qty"]) != DBNull.Value)
                                    {
                                        dao.Qty = ((int)reader["qty"]);
                                    }

                                    if ((reader["avail_qty"]) != DBNull.Value)
                                    {
                                        dao.AvailQty = ((int)reader["avail_qty"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getGagueForTagId = " + ee.Message);
                                    continue;
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getGagueForTagId() = " + ee.Message);
            }

            return dao;
        }



        public static bool doUpdateGagueAvailQty(int id, int avail_qty,string status)
        {
            try
            {
                String sql = "update t_gagues set avail_qty=@avail_qty, BorrowStatus=@status  " +
                    " where id=@id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateGaugeAvailQty()  id = " + id + ", avail_qty=" + avail_qty);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@avail_qty", avail_qty);
                        cmd.Parameters.AddWithValue("@id", id);
                       cmd.Parameters.AddWithValue("@status", status);
                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateGaugeAvailQty() :" + ee.Message);
                return false;
            }
        }

        public static bool doUpdateGagueAvailReturnQty(int id, int avail_qty)
        {
            try
            {
                String sql = "update t_gauges set avail_qty=@avail_qty" +
                    " where id=@id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateGaugeAvailQty()  id = " + id + ", avail_qty=" + avail_qty);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@avail_qty", avail_qty);
                        cmd.Parameters.AddWithValue("@id", id);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateGaugeAvailQty() :" + ee.Message);
                return false;
            }
        }

        public static ArrayList getAllGageBrand()
        {
            ArrayList al = new ArrayList();
            string sql = "select GAGE_BRAND from t_gagues group by GAGE_BRAND order by GAGE_BRAND asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllGageBrand()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["GAGE_BRAND"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["GAGE_BRAND"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllGageBrand = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllGageBrand " + ee.Message);
            }

            return al;
        }


        public static ArrayList getAllGageRange()
        {
            ArrayList al = new ArrayList();
            string sql = "select gage_rance from t_gagues group by gage_rance order by gage_rance asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllGageRange()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["gage_rance"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["gage_rance"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllGageRange = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllGageRange " + ee.Message);
            }

            return al;
        }

        public static ArrayList getAllGageCalibMethod()
        {
            ArrayList al = new ArrayList();
            string sql = "select gage_calib_metho from t_gagues group by gage_calib_metho order by gage_calib_metho asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllGageCalibMethod()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["gage_calib_metho"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["gage_calib_metho"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllGageCalibMethod = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllGageCalibMethod " + ee.Message);
            }

            return al;
        }

        public static ArrayList getAllGageLocations()
        {
            ArrayList al = new ArrayList();
            string sql = "select gage_location from t_gagues group by gage_location order by gage_location asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllGageLocations()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["gage_location"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["gage_location"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllGageLocations = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllGageLocations " + ee.Message);
            }

            return al;
        }

        public static ArrayList getAllGageCalibAgency()
        {
            ArrayList al = new ArrayList();
            string sql = "select clib_agency from t_gagues group by clib_agency order by clib_agency asc";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAllGageCalibAgency()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if ((reader["clib_agency"]) != DBNull.Value)
                                    {
                                        al.Add((string)reader["clib_agency"]);
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAllGageCalibAgency = " + ee.Message);
                                    continue;
                                }
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAllGageCalibAgency " + ee.Message);
            }

            return al;
        }


        public static GaguesDao getGageForGageId(int id, string gageid)
        {
            GaguesDao dao = null;
            string sql = string.Empty;
            if (id > 0)
            {
                sql = "select * from t_gagues where id="+id;
            }
            else
            {
                sql = "select * from t_gagues where gage_id='"+ gageid + "'";
            }

            log.Info("getGageForGageId sql = " + sql);

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getGageForGageId()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dao = new GaguesDao();
                                try
                                {

                                    dao.Id = (int) reader["id"];

                                    if ((reader["gage_id"]) != DBNull.Value)
                                    {
                                        dao.GageId = ((string)reader["gage_id"]);
                                    }

                                    if ((reader["gage_desc"]) != DBNull.Value)
                                    {
                                        dao.GageDesc = ((string)reader["gage_desc"]);
                                    }

                                    if ((reader["gage_brand"]) != DBNull.Value)
                                    {
                                        dao.GageBrand = ((string)reader["gage_brand"]);
                                    }


                                    if ((reader["gage_rance"]) != DBNull.Value)
                                    {
                                        dao.GageRance = ((string)reader["gage_rance"]);
                                    }

                                    if ((reader["gage_slno"]) != DBNull.Value)
                                    {
                                        dao.GageSlNo = ((string)reader["gage_slno"]);
                                    }

                                    if ((reader["gage_calib_metho"]) != DBNull.Value)
                                    {
                                        dao.GageCalibMethod = ((string)reader["gage_calib_metho"]);
                                    }

                                    if ((reader["tolerance"]) != DBNull.Value)
                                    {
                                        dao.Tolerance = ((string)reader["tolerance"]);
                                    }

                                   

                                    try
                                    {
                                        if ((reader["calib_date"]) != DBNull.Value)
                                        {
                                            MySqlDateTime my = ((MySqlDateTime)reader["calib_date"]);
                                            dao.CalibDate = my.GetDateTime();
                                            //dao.CalibDate = ((DateTime)reader["calib_date"]);
                                        }
                                    }catch(Exception ee)
                                    {
                                        log.Error(" " + ee.Message);
                                    }

                                    if ((reader["calib_interval"]) != DBNull.Value)
                                    {
                                        dao.CalibInterval = ((int)reader["calib_interval"]);
                                    }

                                    if ((reader["calb_interval_unit"]) != DBNull.Value)
                                    {
                                        dao.CalibIntervalUnit = ((string)reader["calb_interval_unit"]);
                                    }

                                    try { 
                                        if ((reader["calib_due_date"]) != DBNull.Value)
                                        {
                                            MySqlDateTime my = ((MySqlDateTime)reader["calib_due_date"]);
                                            dao.CalibDueDate = my.GetDateTime();
                                           // dao.CalibDueDate = ((DateTime)reader["calib_due_date"]);
                                        }
                                    }
                                    catch (Exception ee)
                                    {
                                        log.Error(" " + ee.Message);
                                    }

                                    if ((reader["clib_agency"]) != DBNull.Value)
                                    {
                                        dao.CalibAgency = ((string)reader["clib_agency"]);
                                    }

                                    if ((reader["calib_cert_no"]) != DBNull.Value)
                                    {
                                        dao.CalibCertNo = ((string)reader["calib_cert_no"]);
                                    }

                                    if ((reader["gage_location"]) != DBNull.Value)
                                    {
                                        dao.GageLocation = ((string)reader["gage_location"]);
                                    }

                                    if ((reader["remarks"]) != DBNull.Value)
                                    {
                                        dao.Remarks = ((string)reader["remarks"]);
                                    }

                                    if ((reader["comments"]) != DBNull.Value)
                                    {
                                        dao.Comments = ((string)reader["comments"]);
                                    }

                                    if ((reader["master_gage_slno"]) != DBNull.Value)
                                    {
                                        dao.MasterGageSlNo = ((string)reader["master_gage_slno"]);
                                    }

                                    if ((reader["master_gage_cert_no"]) != DBNull.Value)
                                    {
                                        dao.MasterGageCertNo = ((string)reader["master_gage_cert_no"]);
                                    }

                                    try
                                    {
                                        if ((reader["master_gage_valid_date"]) != DBNull.Value)
                                        {
                                            MySqlDateTime my = ((MySqlDateTime)reader["master_gage_valid_date"]);
                                            if (my.Year>2000)
                                            {
                                                dao.MasterGageValidDate = my.GetDateTime();
                                            }
                                           

                                            //dao.MasterGageValidDate = ((DateTime)reader["master_gage_valid_date"]);
                                        }
                                    }catch(Exception ee)
                                    {
                                        log.Info("Error " + ee.Message);
                                    }

                                    if ((reader["gage_status"]) != DBNull.Value)
                                    {
                                        dao.GageStatus = ((string)reader["gage_status"]);
                                    }


                                    if ((reader["qty"]) != DBNull.Value)
                                    {
                                        dao.Qty = ((int)reader["qty"]);
                                    }

                                    if ((reader["avail_qty"]) != DBNull.Value)
                                    {
                                        dao.AvailQty = ((int)reader["avail_qty"]);
                                    }


                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getGagueForTagId = " + ee.Message);
                                    continue;
                                }

                            }
                        }
                       
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getGageForGageId " + ee.Message);
            }

            return dao;
        }

        public static bool doUpdateGagues(GaguesDao gdao)
        {
            try
            {
                String sql = "update t_gagues set gage_id=@gage_id, gage_desc=@gage_desc, gage_brand=@gage_brand, gage_rance=@gage_rance, " +
                    " gage_slno=@gage_slno,gage_calib_metho=@gage_calib_metho, tolerance=@tolerance, calib_date=@calib_date, " +
                    " calib_interval=@calib_interval, calb_interval_unit=@calb_interval_unit, calib_due_date=@calib_due_date, clib_agency=@clib_agency," +
                    " calib_cert_no=@calib_cert_no, gage_location=@gage_location, remarks=@remarks, comments=@comments, master_gage_slno=@master_gage_slno, " +
                    " master_gage_cert_no=@master_gage_cert_no," +
                    " master_gage_valid_date=@master_gage_valid_date, gage_status=@gage_status, " +
                    "   updated_by=@updated_by, updated_on=@updated_on  " +
                    " where id=@id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateGagues()  GageId = " + gdao.GageId);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@gage_id", gdao.GageId);
                        cmd.Parameters.AddWithValue("@gage_desc", gdao.GageDesc);
                        cmd.Parameters.AddWithValue("@gage_brand", gdao.GageBrand);
                        cmd.Parameters.AddWithValue("@gage_rance", gdao.GageRance);
                        cmd.Parameters.AddWithValue("@gage_slno", gdao.GageSlNo);
                        cmd.Parameters.AddWithValue("@gage_calib_metho", gdao.GageCalibMethod);
                        cmd.Parameters.AddWithValue("@tolerance", gdao.Tolerance);                       
                        cmd.Parameters.AddWithValue("@calib_date", gdao.CalibDate);
                        cmd.Parameters.AddWithValue("@calib_interval", gdao.CalibInterval);
                        cmd.Parameters.AddWithValue("@calb_interval_unit", gdao.CalibIntervalUnit);
                        cmd.Parameters.AddWithValue("@calib_due_date", gdao.CalibDueDate);
                        cmd.Parameters.AddWithValue("@clib_agency", gdao.CalibAgency);
                        cmd.Parameters.AddWithValue("@calib_cert_no", gdao.CalibCertNo);
                        cmd.Parameters.AddWithValue("@gage_location", gdao.GageLocation);                       
                        cmd.Parameters.AddWithValue("@remarks", gdao.Remarks);
                        cmd.Parameters.AddWithValue("@comments", gdao.Comments);
                        cmd.Parameters.AddWithValue("@master_gage_slno", gdao.MasterGageSlNo);
                        cmd.Parameters.AddWithValue("@master_gage_cert_no", gdao.MasterGageCertNo);
                        cmd.Parameters.AddWithValue("@master_gage_valid_date", gdao.MasterGageValidDate);
                        cmd.Parameters.AddWithValue("@gage_status", gdao.GageStatus);
                        cmd.Parameters.AddWithValue("@updated_by", gdao.AddedBy);
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", gdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipment() :" + ee.Message);
                return false;
            }
        }

        public static bool doUpdateExcelGagues(GaguesDao gdao)
        {
            try
            {
                String sql = "update t_gagues set gage_desc=@gage_desc, gage_brand=@gage_brand, gage_rance=@gage_rance, " +
                    " gage_slno=@gage_slno,gage_calib_metho=@gage_calib_metho, tolerance=@tolerance, calib_date=@calib_date, " +
                    " calib_interval=@calib_interval, calb_interval_unit=@calb_interval_unit, calib_due_date=@calib_due_date, clib_agency=@clib_agency," +
                    " calib_cert_no=@calib_cert_no, gage_location=@gage_location, remarks=@remarks, master_gage_slno=@master_gage_slno, " +
                    " master_gage_cert_no=@master_gage_cert_no," +
                    " master_gage_valid_date=@master_gage_valid_date, gage_status=@gage_status, " +
                    "   updated_by=@updated_by, updated_on=@updated_on,avail_qty=avail_qty+@Aqty,qty=qty+@Aqty  " +
                    " where gage_id=gage_id";

                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateGagues()  GageId = " + gdao.GageId);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@gage_id", gdao.GageId);
                        cmd.Parameters.AddWithValue("@gage_desc", gdao.GageDesc);
                        cmd.Parameters.AddWithValue("@gage_brand", gdao.GageBrand);
                        cmd.Parameters.AddWithValue("@gage_rance", gdao.GageRance);
                        cmd.Parameters.AddWithValue("@gage_slno", gdao.GageSlNo);
                        cmd.Parameters.AddWithValue("@gage_calib_metho", gdao.GageCalibMethod);
                        cmd.Parameters.AddWithValue("@tolerance", gdao.Tolerance);
                        cmd.Parameters.AddWithValue("@calib_date", gdao.CalibDate);
                        cmd.Parameters.AddWithValue("@calib_interval", gdao.CalibInterval);
                        cmd.Parameters.AddWithValue("@calb_interval_unit", gdao.CalibIntervalUnit);
                        cmd.Parameters.AddWithValue("@calib_due_date", gdao.CalibDueDate);
                        cmd.Parameters.AddWithValue("@clib_agency", gdao.CalibAgency);
                        cmd.Parameters.AddWithValue("@calib_cert_no", gdao.CalibCertNo);
                        cmd.Parameters.AddWithValue("@gage_location", gdao.GageLocation);
                        cmd.Parameters.AddWithValue("@remarks", gdao.Remarks);
                        cmd.Parameters.AddWithValue("@comments", gdao.Comments);
                        cmd.Parameters.AddWithValue("@master_gage_slno", gdao.MasterGageSlNo);
                        cmd.Parameters.AddWithValue("@master_gage_cert_no", gdao.MasterGageCertNo);
                        cmd.Parameters.AddWithValue("@master_gage_valid_date", gdao.MasterGageValidDate);
                        cmd.Parameters.AddWithValue("@gage_status", gdao.GageStatus);
                        cmd.Parameters.AddWithValue("@updated_by", gdao.AddedBy);
                        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Aqty", gdao.AvailQty);
                        cmd.Parameters.AddWithValue("@qty", gdao.Qty);
                        cmd.Parameters.AddWithValue("@id", gdao.Id);


                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateEquipment() :" + ee.Message);
                return false;
            }
        }


        public static bool doAddGaguges(GaguesDao gdao)
        {
            try
            {
                String sql = "insert into t_gagues (gage_id, gage_desc, gage_brand, gage_rance, " +
                    " gage_slno, gage_calib_metho, tolerance, calib_date,  " +
                    "   calib_interval, calb_interval_unit , calib_due_date, clib_agency, calib_cert_no, gage_location, " +
                    "remarks, comments, master_gage_slno,  master_gage_cert_no, master_gage_valid_date, gage_status," +
                    " added_by, added_on, qty, avail_qty)  values(@gage_id, @gage_desc, @gage_brand, @gage_rance, @gage_slno, @gage_calib_metho, @tolerance, @calib_date," +
                    "@calib_interval, @calb_interval_unit , @calib_due_date, @clib_agency, @calib_cert_no, @gage_location," +
                    "@remarks, @comments, @master_gage_slno,  @master_gage_cert_no, @master_gage_valid_date, @gage_status, @added_by, @added_on," +
                    " @qty, @avail_qty)  ";


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doAddGaguges()  gage_id = " + gdao.GageId + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@gage_id", gdao.GageId);
                        cmd.Parameters.AddWithValue("@gage_desc", gdao.GageDesc);
                        cmd.Parameters.AddWithValue("@gage_brand", gdao.GageBrand);
                        cmd.Parameters.AddWithValue("@gage_rance", gdao.GageRance);
                        cmd.Parameters.AddWithValue("@gage_slno", gdao.GageSlNo);
                        cmd.Parameters.AddWithValue("@gage_calib_metho", gdao.GageCalibMethod);
                        cmd.Parameters.AddWithValue("@tolerance", gdao.Tolerance);
                        cmd.Parameters.AddWithValue("@remarks", gdao.Remarks);
                        cmd.Parameters.AddWithValue("@calib_date", gdao.CalibDate);
                        cmd.Parameters.AddWithValue("@calib_interval", gdao.CalibInterval);

                        cmd.Parameters.AddWithValue("@calb_interval_unit", gdao.CalibIntervalUnit);
                        cmd.Parameters.AddWithValue("@calib_due_date", gdao.CalibDueDate);
                        cmd.Parameters.AddWithValue("@clib_agency", gdao.CalibAgency);
                        cmd.Parameters.AddWithValue("@calib_cert_no", gdao.CalibCertNo);
                        cmd.Parameters.AddWithValue("@gage_location", gdao.GageLocation);
                        //@remarks, @comments, @master_gage_slno,  @master_gage_cert_no, @master_gage_valid_date, @gage_status,                        
                        cmd.Parameters.AddWithValue("@comments", string.IsNullOrEmpty(gdao.Comments)?"": gdao.Comments);
                        cmd.Parameters.AddWithValue("@master_gage_slno", gdao.MasterGageSlNo);
                        cmd.Parameters.AddWithValue("@master_gage_cert_no", gdao.MasterGageCertNo);
                        cmd.Parameters.AddWithValue("@master_gage_valid_date", gdao.MasterGageValidDate);
                        cmd.Parameters.AddWithValue("@gage_status", gdao.GageStatus);

                        cmd.Parameters.AddWithValue("@added_by", gdao.AddedBy);
                        cmd.Parameters.AddWithValue("@added_on", DateTime.Now);
                        cmd.Parameters.AddWithValue("@qty",gdao.Qty); 
                        //cmd.Parameters.AddWithValue("@id", gdao.Id);
                         cmd.Parameters.AddWithValue("@avail_qty", gdao.AvailQty);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doAddGaguges() :" + ee.Message);
                return false;
            }
        }


        public static bool doDeleteGaguges(int id)
        {
            try
            {
                String sql = "delete from t_gagues where id=@id ";


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doDeleteGaguges()  id = " + id + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id", id);

                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doDeleteGaguges() :" + ee.Message);
                return false;
            }
        }

        public static bool doCheckExsist(string  id)
        {
            try
            {
                String sql = "Select 1   from t_gagues where gage_id=@id ";
                bool al = false;
                    using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                    {
                        sqlCon.Open();
                        log.Info(" getAllDepts()  sql = " + sql);
                        using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                        {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                al = true;
                                }
                            }
                            return al;
                        }
                    }
                
               
            }
            catch (Exception ee)
            {

                log.Info("Error doDeleteGaguges() :" + ee.Message);
                return false;
            }
        }


        public static bool doCheckExsistEqupment(string id)
        {
            try
            {
                String sql = "Select 1   from t_equipments where tag_no=@id ";
                bool al = false;
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" doCheckExsistEqupment()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                al = true;
                            }
                        }
                        return al;
                    }
                }


            }
            catch (Exception ee)
            {

                log.Info("Error doDeleteGaguges() :" + ee.Message);
                return false;
            }
        }




        public static ArrayList getAGagueTransHistory(string equiptag)
        {
            ArrayList al = new ArrayList();
            string sql = "select * from t_gague_trans where equip_tag='" + equiptag + "' and status=0";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();
                    log.Info(" getAGagueTransHistory()  sql = " + sql);
                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GagueTransHistoryDao dao = new GagueTransHistoryDao();
                                dao.Id = (int)reader["id"];
                                try
                                {
                                    if ((reader["borrow_comments"]) != DBNull.Value)
                                    {
                                        dao.BorrowComments = (string)reader["borrow_comments"];
                                    }
                                }
                                catch (Exception ee)
                                {
                                    log.Error("Exception in getting   getAGagueTransHistory = " + ee.Message);
                                    continue;
                                }

                                al.Add(dao);
                            }
                        }
                        return al;
                    }
                }
            }
            catch (Exception ee)
            {
                log.Info("Error getAGagueTransHistory " + ee.Message);
            }

            return al;
        }


        public static bool doAddGaugeTransHistory(GagueTransHistoryDao tpdao)
        {
            String sql = string.Empty;
            try
            {
                if (tpdao.BorrowedBy > 0)
                {
                    sql = "insert into t_gague_trans (equip_tag, borrowed_by,   borrowed_on, borrow_comments " +
                        "  )  values( @equip_tag, @borrowed_by,  @borrowed_on, @borrow_comments" +
                        " )  ";
                }
                else
                {
                    sql = "insert into t_gague_trans (equip_tag,  returned_by,  " +
                        "   returned_on, return_comments )  values( @equip_tag, @returned_by, " +
                        " @returned_on, @return_comments)  ";
                }


                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doAddGaugeTransHistory()  materialNum = " + tpdao.EquipTag + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@equip_tag", tpdao.EquipTag);
                        cmd.Parameters.AddWithValue("@borrowed_by", tpdao.BorrowedBy);
                        cmd.Parameters.AddWithValue("@returned_by", tpdao.ReturnedBy);
                        if (tpdao.BorrowedBy > 0)
                        {
                            cmd.Parameters.AddWithValue("@borrowed_on", tpdao.BorrowedOn);
                            cmd.Parameters.AddWithValue("@borrow_comments", tpdao.BorrowComments);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@returned_on", tpdao.RequrnedOn);
                            cmd.Parameters.AddWithValue("@return_comments", tpdao.ReturnedComments);
                        }




                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doAddGaugeTransHistory() :" + ee.Message);
                return false;
            }
        }


        public static bool doUpdateGagueTransHistory(GagueTransHistoryDao tpdao)
        {
            string sql = string.Empty;

            try
            {
                if (tpdao.ReturnedBy > 0)
                {
                    sql = "update t_gauge_trans set   returned_by=@returned_by, " +
                                       "   returned_on=@returned_on, return_comments=@return_comments , status=@status where id=@Id";
                }
                else
                {
                    sql = "update t_gauge_trans set borrowed_by=@borrowed_by,   borrowed_on=@borrowed_on," +
                   " borrow_comments=@borrow_comments , status=@status where id=@Id";
                }



                using (MySqlConnection sqlCon = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    sqlCon.Open();

                    log.Info(" doUpdateGagueTransHistory()  materialNum = " + tpdao.EquipTag + ", sql = " + sql);

                    using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", tpdao.Id);
                        cmd.Parameters.AddWithValue("@status", tpdao.Status);

                        if (tpdao.ReturnedBy > 0)
                        {
                            cmd.Parameters.AddWithValue("@returned_on", tpdao.RequrnedOn);
                            cmd.Parameters.AddWithValue("@returned_by", tpdao.ReturnedBy);
                            cmd.Parameters.AddWithValue("@return_comments", tpdao.ReturnedComments);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@borrowed_by", tpdao.BorrowedBy);
                            cmd.Parameters.AddWithValue("@borrowed_on", tpdao.BorrowedOn);
                            cmd.Parameters.AddWithValue("@borrow_comments", tpdao.BorrowComments);
                        }




                        int res = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ee)
            {

                log.Info("Error doUpdateGagueTransHistory() :" + ee.Message);
                return false;
            }
        }


    }
}
