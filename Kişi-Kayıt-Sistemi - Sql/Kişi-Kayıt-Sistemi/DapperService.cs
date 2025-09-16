using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public class DapperService
    {
        protected string constring { get; set; }
        public DapperService(string constring_)
        {
            constring = constring_;
        }
        public IEnumerable<T> GetAll<T>(string Table)
        {
            using (IDbConnection conn = new SqlConnection(constring))
            {
                return conn.Query<T>($"SELECT * FROM {Table} WITH(NOLOCK) ORDER BY Id DESC").AsEnumerable();
            }
        }
            public Models.response Insert(object Table)
            {
            Models.response response = new Models.response();
            try
            {
                var tablename = (Table.GetType().Name);
                string insertstring = $"INSERT INTO {tablename}(";
                string paramstring = "VALUES(";
                var properties = Table.GetType().GetProperties();

                for (int i = 0; i < properties.Count(); i++)
                {
                    if(properties[i].Name != "Id")
                    {
                        insertstring += $"{properties[i].Name},"; 
                        paramstring += $"@{properties[i].Name},"; 
                    }
                }
                insertstring = insertstring.TrimEnd(',');
                paramstring = paramstring.TrimEnd(',');
                insertstring += ")";
                paramstring += $")select  IDENT_CURRENT( '{tablename}' )";
                insertstring += paramstring;
                using (IDbConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    response.Id = Convert.ToInt32(conn.ExecuteScalar(insertstring, Table));
                    conn.Close();
                    if (response.Id ==0)
                    {
                        response.msg = $"Kayıt Edilemedi";
                    }
                }
            }
            catch (Exception ex)
            {
            response.msg = ex.Message;
            response.msgdetail = ex.StackTrace.ToString();
            }
            return response;
            }
            public Models.response Delete(string Table,int id)
            {
            Models.response response = new Models.response();
            try
            {
                using (IDbConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    var sqldelete = $"DELETE FROM {Table} Where Id=@Id";
                    response.Id = conn.Execute(sqldelete, new { Id = id });
                    conn.Close();

                    if (response.Id == 0)
                    {
                        response.msg = $"{id} Nolu Kayıt Silinemedi";
                    }
                }
            }
            catch (Exception ex)
            {
                response.msg = ex.Message;
                response.msgdetail = ex.StackTrace.ToString();
            }
            return response;
            }
             public Models.response UpdateSql(string Table, Person person)
             {
                Models.response response = new Models.response();
                try
                {                  
                using (IDbConnection conn = new SqlConnection(constring))
                {
                   conn.Open();
                   var sqlUpdate = $"UPDATE {Table} SET Fullname=@Fullname,Phone=@Phone,Email=@Email,Aciklama=@Aciklama,DuzeltTarih=@DuzeltTarih,Duzelten=@Duzelten WHERE Id=@Id";
                   response.Id = conn.Execute(sqlUpdate, person);
                   conn.Close();

                   if (response.Id==0)
                   {
                      MessageBox.Show("Kayıt Güncellenemedi");
                   }
                }
                }
                catch(Exception ex)
                {
                response.msg = ex.Message;
                response.msgdetail = ex.StackTrace.ToString();
                }
                return response;
             }
             public bool Test()
             {
                using(var conn = new SqlConnection(constring))
                {
                try
                {
                    conn.Open();
                    return true;
                }
                catch(Exception ddd)
                {
                    return false;
                }
                }
             }
    }
}
