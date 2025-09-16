
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public partial class LogLıst : XtraForm
    {
        public LogLıst()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        public int Logid;
        List<Models.LogModel> LogsList = new List<Models.LogModel>();
        private void LogLıst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
        private void LogLıst_FormClosing(object sender, FormClosingEventArgs e)
        {
            toolscs.GridLogsSave(gridView1);
        }
        private void LogLıst_Load(object sender, EventArgs e)
        {
            if (Logid >=0)
            {
                LogsList = main.Logs.Where(i => i.FieldId == Logid).ToList();
                if (LogsList.Any())
                {
                    var desc = LogsList.OrderByDescending(i => i.Id).ToList();
                    gridControl1.DataSource = logModelBindingSource.DataSource = desc;
                    gridView1.FocusedRowHandle = 0;
                    gridView1.PopulateColumns();
                    gridView1.Columns["ChangeDate"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
                    gridView1.OptionsBehavior.Editable = false;
                    toolscs.GridLogsGet(gridView1);
                }
                else
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        XtraMessageBox.Show("Log Kaydı Bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }));                               
                }
            }
            else
            {
                this.Close();
            }
        }
        private void LogLıst_Shown(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                gridView1.Columns["Id"].Visible = false;
                gridView1.OptionsView.ColumnAutoWidth = false;
                gridView1.BestFitMaxRowCount = -1;
                gridView1.BestFitColumns();
                gridView1.OptionsView.ShowAutoFilterRow = true;   
            }));
        }
    }
}