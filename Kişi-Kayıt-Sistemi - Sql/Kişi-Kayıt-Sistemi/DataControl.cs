using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using DevExpress.XtraEditors;
namespace Kişi_Kayıt_Sistemi
{
    public partial class DataControl : XtraForm
    {
        public DataControl()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        bool sql;  
        private void DataControl_Shown(object sender, EventArgs e)
        {
            var key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
            .OpenSubKey(@"SOFTWARE\PersonelYonetim");
            if (key!=null)
            {
                txtServer.Text = Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("ServerName")?.ToString()));
                txtDb.Text =  Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Db")?.ToString()));
                txtUser.Text = Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("User Id")?.ToString()));
                txtPass.Text =  Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Password")?.ToString()));
            }
            else
            {
                txtServer.Text = "";
                txtDb.Text = "";
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
        private void DataControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnBaglan.PerformClick();
            }
        }
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string conn;
            var key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
            .CreateSubKey(@"SOFTWARE\PersonelYonetim");
            if (key != null)
            {
                key.SetValue("ServerName", $@"{Convert.ToBase64String(Encoding.UTF8.GetBytes(txtServer.Text))}");
                key.SetValue("Db", $"{Convert.ToBase64String(Encoding.UTF8.GetBytes(txtDb.Text))}");
                key.SetValue("User Id", $"{Convert.ToBase64String(Encoding.UTF8.GetBytes(txtUser.Text))}");
                key.SetValue("Password", $"{Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPass.Text))}");
                conn = $@"Data Source ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("ServerName")?.ToString()))}; Initial Catalog ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Db")?.ToString()))}; User ID ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("User Id")?.ToString()))}; Password ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Password")?.ToString()))};";
                main.SqlService = new DapperService(conn);
                sql = main.SqlService.Test();
                if (sql == true)
                {
                    this.Close();
                    XtraMessageBox.Show("Veri Tabanı Baglantısı Başarılı");
                    Kişi_Kayıt_Sistemi.ControlData.DataUpdateTable(conn);
                }
                else
                {
                    XtraMessageBox.Show("Veri Tabanı Baglantısı Saglanamadı");
                }
            }
            else
            {
                XtraMessageBox.Show("PersonelYonetim Anahtarı Oluşturmada Hata Oluştu Tekrar Deneyin");
            }
        }
    }
}
