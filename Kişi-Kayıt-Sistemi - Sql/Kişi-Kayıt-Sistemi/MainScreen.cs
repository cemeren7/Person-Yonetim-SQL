using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public partial class MainScreen : XtraForm
    {
        public MainScreen()
        {
            InitializeComponent();
            KeyPreview = true;
            UserLookAndFeel.Default.StyleChanged += default_style;
        }
        private void default_style(object sender, EventArgs e)
        {
            string defaultstyle = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Theme = defaultstyle;
            Properties.Settings.Default.Save();
        }
        private void BtnPersonLıst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var controlForm = documentManager1.View.Documents.FirstOrDefault(c => c.Form is KısıLıst);
            if (controlForm != null)
            {
                documentManager1.View.ActivateDocument(controlForm.Form);
            }
            else
            {
                KısıLıst person = new KısıLıst();
                person.MdiParent = this;
                person.Show();
            }
        }
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = XtraMessageBox.Show("Çıkış Yapmak İstediginize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F11)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (e.Alt && e.KeyCode == Keys.F11)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (e.Control && e.KeyCode==Keys.K)
            {
                BtnPersonLıst.PerformClick();
            }
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {   
            this.WindowState = FormWindowState.Maximized;
            ToolTipController tt = new ToolTipController();
            tt.ShowBeak = true; 
            tt.AutoPopDelay = 3000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowShadow = true;
            tt.Rounded = true;
            int x = this.Width - 220;
            int y = 10;
            tt.ShowHint("Tam ekran: F11, Normal ekran: ALT + F11,Programdan çıkmak için: ESC", new System.Drawing.Point(x,y));
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            SkinHelper.InitSkinPopupMenu(BtnColorSettings);
            UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.Theme);
        }
    }
}