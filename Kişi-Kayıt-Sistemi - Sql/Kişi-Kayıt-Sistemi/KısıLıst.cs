using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.Drawing;
namespace Kişi_Kayıt_Sistemi
{
    public partial class KısıLıst : XtraForm
    {
        public KısıLıst()
        {
            InitializeComponent();
            main.splashScreenManager1 =  new DevExpress.XtraSplashScreen.SplashScreenManager(Application.OpenForms["KısıLıst"], typeof(global::Kişi_Kayıt_Sistemi.WaitForm1), false, false);
            CheckForIllegalCrossThreadCalls = false;
            KeyPreview = true;
        }
        bool sql = false;
        public void RefreshDataList()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = bindingSource1.DataSource = main.Personeller;
        }
        public void RefreshData()
        {
            main.Personeller = main.SqlService.GetAll<Person>("Person").ToList();
            gridControl1.DataSource = bindingSource1.DataSource = main.Personeller;
            gridView1.PopulateColumns();
            gridView1.Columns["KayitTarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            gridView1.Columns["DuzeltTarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            toolscs.GridViewGet(gridView1);
            gridView1.BestFitColumns();
        }
        private void KısıLıst_FormClosing(object sender, FormClosingEventArgs e) 
        {
            toolscs.GridViewSave(gridView1);
        }
        private void KısıLıst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnEkle.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                BtnYenile.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                BtnDuzenle.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Delete)
            {
                BtnSil.PerformClick();
            }
            if (e.Shift && e.KeyCode == Keys.Tab)
            {
                BtnLog.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.Add)
            {
                DataControl df = new DataControl();
                df.ShowDialog();
            }
            if (e.Shift && e.KeyCode==Keys.Home)
            {
                btnselect.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.A)
            {
                btnselectall.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.X)
            {
                Excel.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.P)
            {
                Pdf.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.H)
            {
                btnhtml.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.W)
            {
                btnword.PerformClick();
            }
        }
        private async void KısıLıst_Shown(object sender, EventArgs e)
        {
            string conndappar;
            var key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
            .OpenSubKey(@"SOFTWARE\PersonelYonetim");
            if (key!=null)
            {
                conndappar = $@"Data Source ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("ServerName")?.ToString()))}; Initial Catalog ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Db")?.ToString()))}; User ID ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("User Id")?.ToString()))}; Password ={Encoding.UTF8.GetString(Convert.FromBase64String(key.GetValue("Password")?.ToString()))};";
                main.SqlService = new DapperService(conndappar);
                sql = main.SqlService.Test();
                if (sql==true)
                {
                    Kişi_Kayıt_Sistemi.ControlData.DataUpdateTable(conndappar);
                }
                else
                {
                    DataControl dt = new DataControl();
                    dt.ShowDialog();
                }
            }
            else
            {   
                DataControl dt = new DataControl();
                dt.ShowDialog();
            }
        this.ShowLoad("Yükleniyor");
        await Task.Run(() =>
        {
        firstload();
        });
        }
        private void firstload()
        {
        this.SuspendLayout();
        gridControl1.SuspendLayout();
        gridControl1.BeginUpdate();
        gridControl1.DataSource = null;
        toolscs.DataLogLoad();
        RefreshData();
        gridView1.OptionsBehavior.Editable = false; 
        gridView1.OptionsView.ColumnAutoWidth = false;
        gridView1.BestFitMaxRowCount = -1;
        gridView1.BestFitColumns();
        gridControl1.EndUpdate();
        this.CloseLoad();
        this.ResumeLayout();
        gridControl1.ResumeLayout();
        }
        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var view = gridView1;
                var hit = view.CalcHitInfo(e.Location);
                if (hit.InRow || hit.InRowCell)
                {
                    view.FocusedRowHandle = hit.RowHandle;
                    view.ClearSelection();
                    view.SelectRow(hit.RowHandle);
                    Point ps = gridControl1.PointToScreen(e.Location);
                    popupMenu2.ShowPopup(ps);
                }
            }
        }       
        private void BtnData_Click(object sender, EventArgs e)
        {
            DataControl dt = new DataControl();
            dt.ShowDialog();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            new KısıEdıt().showDialog();
            RefreshData();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0) 
            {
                int rowId = gridView1.GetValueInt();
                if (rowId >= 0)
                {
                    DialogResult cevap = XtraMessageBox.Show("Silmek İstediginize Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.OK)
                    {
                        var resp = main.SqlService.Delete("Person", rowId);
                        main.Logs.RemoveAll(c => c.FieldId == rowId);
                        main.Logs.DataLogSave();
                        if (!string.IsNullOrEmpty(resp.msg))
                        {
                            XtraMessageBox.Show(resp.msg);
                        }
                        else
                        {
                            main.Personeller.RemoveAll(c => c.Id == rowId);
                            RefreshDataList();
                        } 
                    }
                }
                else
                {
                    XtraMessageBox.Show("Silinecek Kayıt Bulunamadı ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Silinecek Veri Bulunmadı ");
            }
        }
        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            new KısıEdıt().showDialog(gridView1.GetValueInt());
            gridView1.RefreshData();
            gridView1.BestFitColumns();
        }
        private async void BtnYenile_Click(object sender, EventArgs e)
        {
            this.ShowLoad("Yükleniyor...");
            await Task.Run(() =>
            {
                firstload();
            });
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDuzenle.PerformClick();
                e.Handled = true;
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            BtnDuzenle.PerformClick();
        }
        private void BtnLog_Click(object sender, EventArgs e)
        {
            new LogLıst().showDialogLog(gridView1.GetValueInt());
        }
        private void Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveone = new SaveFileDialog();
            saveone.FileName = "Person.xlsx";
            saveone.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveone.Title = "Excel Dosyası Kaydet";
            if (saveone.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;   
                gridView1.Columns["DuzeltTarih"].Width = 111; 
                var ec = new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    SheetName = $"Person",
                    TextExportMode = TextExportMode.Value,
                };
                gridView1.ExportToXlsx(saveone.FileName, ec);
            }
        }
        private void Pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveone = new SaveFileDialog();
            saveone.FileName = "Person.pdf";
            saveone.Filter = "Pdf Files (*.pdf)|*.pdf";
            saveone.Title = "Pdf Dosyası Kaydet";
            if (saveone.ShowDialog() == DialogResult.OK)
            {
                PrintingSystem print = new PrintingSystem();
                print.PageSettings.Landscape = true;
                PrintableComponentLink lin = new PrintableComponentLink(print) 
                {
                    Component = gridView1.GridControl,
                    Landscape = true, 
                    PaperKind = System.Drawing.Printing.PaperKind.A3,
                };
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false; 
                var pdf = new PdfExportOptions 
                {
                    DocumentOptions =
                    {
                       Title = "Person Raporu", 
                       Subject = "Person Verileri", 
                       Author = Environment.MachineName, 
                       Producer = "Visual Studio 2019", 
                       Application = "Kişi Kayıt Sistemi",
                       Keywords = "Person,Pdf,Devexpress,Windows Form", 
                    },
                    ImageQuality = PdfJpegImageQuality.High,
                };
                lin.CreateDocument();
                lin.ExportToPdf(saveone.FileName, pdf);
            }
        }
        private void Ekleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnEkle.PerformClick();
        }
        private void Güncelleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnDuzenle.PerformClick();
        }
        private void Silme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnSil.PerformClick();
        }
        private void Log_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnLog.PerformClick();
        }
        private void btnselectall_Click(object sender, EventArgs e)
        {
          gridView1.OptionsSelection.MultiSelect = true;
          gridView1.SelectAll();
          gridView1.CopyToClipboard();
        }
        private void btnselect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CopyToClipboard();
        }
        private void btnhtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Html Dosyası Kaydet";
            savehmtl.FileName = "Person.html";
            savehmtl.Filter = "HTML Dosyaları (*.html)|*.html|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.OptionsPrint.AutoWidth = false;    
                gridView1.BestFitColumns();
                var optionshtml = new HtmlExportOptions
                {
                    Title = "Person Verileri",
                    ExportMode = HtmlExportMode.SingleFile,
                    CharacterSet = "UTF-8",
                };
                gridView1.ExportToHtml(savehmtl.FileName, optionshtml);
            }
        }
        private void btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Word Dosyası Kaydet";
            savehmtl.FileName = "Person.docx";
            savehmtl.Filter = "WORD Dosyaları (*.docx)|*.docx|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.OptionsPrint.AutoWidth = false;
                gridView1.BestFitColumns();
                var Op = new DocxExportOptions()
                {
                    DocumentOptions = { Author = Environment.MachineName, Title = "Person Verileri" },
                    ExportMode = DocxExportMode.SingleFilePageByPage,
                };
                gridView1.ExportToDocx(savehmtl.FileName, Op);
            }
        }
        private void KısıLıst_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
