
namespace Kişi_Kayıt_Sistemi
{
    partial class KısıLıst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KısıLıst));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnselectall = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.Excel = new DevExpress.XtraBars.BarButtonItem();
            this.Pdf = new DevExpress.XtraBars.BarButtonItem();
            this.btnhtml = new DevExpress.XtraBars.BarButtonItem();
            this.btnword = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Ekleme = new DevExpress.XtraBars.BarButtonItem();
            this.Güncelleme = new DevExpress.XtraBars.BarButtonItem();
            this.Silme = new DevExpress.XtraBars.BarButtonItem();
            this.Log = new DevExpress.XtraBars.BarButtonItem();
            this.btnselect = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLog = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.BtnData = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitEden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuzeltTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuzelten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Kişi_Kayıt_Sistemi.Person);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnselectall);
            this.panel1.Controls.Add(this.dropDownButton1);
            this.panel1.Controls.Add(this.BtnDuzenle);
            this.panel1.Controls.Add(this.BtnLog);
            this.panel1.Controls.Add(this.BtnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 642);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnselectall
            // 
            this.btnselectall.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnselectall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnselectall.ImageOptions.Image")));
            this.btnselectall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnselectall.Location = new System.Drawing.Point(391, 0);
            this.btnselectall.Name = "btnselectall";
            this.btnselectall.Size = new System.Drawing.Size(84, 37);
            this.btnselectall.TabIndex = 7;
            this.btnselectall.ToolTip = "Tüm Verileri Kopyala CTRL+A";
            this.btnselectall.ToolTipController = this.toolTipController1;
            this.btnselectall.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnselectall.ToolTipTitle = "Bilgilendirme";
            this.btnselectall.Click += new System.EventHandler(this.btnselectall_Click);
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.RoundRadius = 4;
            this.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopCenter;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Standard;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.dropDownButton1.Location = new System.Drawing.Point(300, 0);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(91, 37);
            this.dropDownButton1.TabIndex = 6;
            this.dropDownButton1.ToolTip = "Verileri Dışarı Aktar";
            this.dropDownButton1.ToolTipController = this.toolTipController1;
            this.dropDownButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.dropDownButton1.ToolTipTitle = "Bilgilendirme";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Excel),
            new DevExpress.XtraBars.LinkPersistInfo(this.Pdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnhtml),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnword)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // Excel
            // 
            this.Excel.Caption = "Excel";
            this.Excel.Id = 0;
            this.Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Excel.ImageOptions.Image")));
            this.Excel.Name = "Excel";
            this.Excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Excel_ItemClick);
            // 
            // Pdf
            // 
            this.Pdf.Caption = "Pdf";
            this.Pdf.Id = 1;
            this.Pdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Pdf.ImageOptions.Image")));
            this.Pdf.Name = "Pdf";
            this.Pdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Pdf_ItemClick);
            // 
            // btnhtml
            // 
            this.btnhtml.Caption = "Html";
            this.btnhtml.Id = 18;
            this.btnhtml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhtml.ImageOptions.Image")));
            this.btnhtml.Name = "btnhtml";
            this.btnhtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhtml_ItemClick);
            // 
            // btnword
            // 
            this.btnword.Caption = "Word";
            this.btnword.Id = 19;
            this.btnword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnword.ImageOptions.Image")));
            this.btnword.Name = "btnword";
            this.btnword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnword_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Excel,
            this.Pdf,
            this.Ekleme,
            this.Güncelleme,
            this.Silme,
            this.Log,
            this.btnhtml,
            this.btnword,
            this.btnselect});
            this.barManager1.MaxItemId = 21;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1257, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 679);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1257, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 679);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1257, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 679);
            // 
            // Ekleme
            // 
            this.Ekleme.Caption = "Ekle";
            this.Ekleme.Id = 14;
            this.Ekleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ekleme.ImageOptions.Image")));
            this.Ekleme.Name = "Ekleme";
            this.Ekleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Ekleme_ItemClick);
            // 
            // Güncelleme
            // 
            this.Güncelleme.Caption = "Güncelle";
            this.Güncelleme.Id = 15;
            this.Güncelleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Güncelleme.ImageOptions.Image")));
            this.Güncelleme.Name = "Güncelleme";
            this.Güncelleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Güncelleme_ItemClick);
            // 
            // Silme
            // 
            this.Silme.Caption = "Sil";
            this.Silme.Id = 16;
            this.Silme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Silme.ImageOptions.Image")));
            this.Silme.Name = "Silme";
            this.Silme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Silme_ItemClick);
            // 
            // Log
            // 
            this.Log.Caption = "Log Kaydı Görüntüle";
            this.Log.Id = 17;
            this.Log.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Log.ImageOptions.Image")));
            this.Log.Name = "Log";
            this.Log.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Log_ItemClick);
            // 
            // btnselect
            // 
            this.btnselect.Caption = "Satırı Kopyala";
            this.btnselect.Id = 20;
            this.btnselect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnselect.ImageOptions.Image")));
            this.btnselect.Name = "btnselect";
            this.btnselect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnselect_ItemClick);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDuzenle.ImageOptions.Image")));
            this.BtnDuzenle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnDuzenle.Location = new System.Drawing.Point(225, 0);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(75, 37);
            this.BtnDuzenle.TabIndex = 5;
            this.BtnDuzenle.ToolTip = "Kaydı Düzenle  F4";
            this.BtnDuzenle.ToolTipController = this.toolTipController1;
            this.BtnDuzenle.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnDuzenle.ToolTipTitle = "Bilgilendirme";
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnLog
            // 
            this.BtnLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLog.ImageOptions.Image")));
            this.BtnLog.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.BtnLog.Location = new System.Drawing.Point(150, 0);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(75, 37);
            this.BtnLog.TabIndex = 4;
            this.BtnLog.ToolTip = "Log Kaydını Görüntüle SHIFT+TAB";
            this.BtnLog.ToolTipController = this.toolTipController1;
            this.BtnLog.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnLog.ToolTipTitle = "Bilgilendirme";
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.BtnSil.Location = new System.Drawing.Point(75, 0);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 37);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.ToolTip = "Kaydı Sil Delete ";
            this.BtnSil.ToolTipController = this.toolTipController1;
            this.BtnSil.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnSil.ToolTipTitle = "Bilgilendirme ";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnEkle.Location = new System.Drawing.Point(0, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.ToolTip = "Kayıt Ekle F2";
            this.btnEkle.ToolTipController = this.toolTipController1;
            this.btnEkle.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnEkle.ToolTipTitle = "Bilgilendirme";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnYenile
            // 
            this.BtnYenile.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYenile.ImageOptions.Image")));
            this.BtnYenile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.BtnYenile.Location = new System.Drawing.Point(0, 0);
            this.BtnYenile.Name = "BtnYenile";
            this.BtnYenile.Size = new System.Drawing.Size(75, 40);
            this.BtnYenile.TabIndex = 7;
            this.BtnYenile.ToolTip = "Yenile F5";
            this.BtnYenile.ToolTipController = this.toolTipController1;
            this.BtnYenile.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnYenile.ToolTipTitle = "Bilgilendirme";
            this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            // 
            // BtnData
            // 
            this.BtnData.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnData.ImageOptions.Image")));
            this.BtnData.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.BtnData.Location = new System.Drawing.Point(75, 0);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(75, 40);
            this.BtnData.TabIndex = 8;
            this.BtnData.ToolTip = "Veri Tabanına Baglan CRTL+";
            this.BtnData.ToolTipController = this.toolTipController1;
            this.BtnData.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.BtnData.ToolTipTitle = "Bilgilendirme";
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnData);
            this.panel2.Controls.Add(this.BtnYenile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 40);
            this.panel2.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullName,
            this.colPhone,
            this.colEmail,
            this.colKayitTarih,
            this.colKayitEden,
            this.colAciklama,
            this.colDuzeltTarih,
            this.colDuzelten});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colEmail;
            gridFormatRule1.ColumnApplyTo = this.colEmail;
            gridFormatRule1.Name = "gmail";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "Contains([Email], \'gmail\')";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colEmail;
            gridFormatRule2.Name = "outlook";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "Contains([Email], \'outlook\')";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.colEmail;
            gridFormatRule3.Name = "Hotmail";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "Contains([Email], \'hotmail\')";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = this.colEmail;
            gridFormatRule4.Name = "San";
            formatConditionRuleExpression4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Blue;
            formatConditionRuleExpression4.Appearance.Options.UseFont = true;
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression4.Expression = "Contains([Email], \'santsg\')";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colKayitTarih
            // 
            this.colKayitTarih.FieldName = "KayitTarih";
            this.colKayitTarih.Name = "colKayitTarih";
            this.colKayitTarih.Visible = true;
            this.colKayitTarih.VisibleIndex = 4;
            // 
            // colKayitEden
            // 
            this.colKayitEden.FieldName = "KayitEden";
            this.colKayitEden.Name = "colKayitEden";
            this.colKayitEden.OptionsColumn.ReadOnly = true;
            this.colKayitEden.Visible = true;
            this.colKayitEden.VisibleIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            // 
            // colDuzeltTarih
            // 
            this.colDuzeltTarih.FieldName = "DuzeltTarih";
            this.colDuzeltTarih.Name = "colDuzeltTarih";
            this.colDuzeltTarih.Visible = true;
            this.colDuzeltTarih.VisibleIndex = 7;
            // 
            // colDuzelten
            // 
            this.colDuzelten.FieldName = "Duzelten";
            this.colDuzelten.Name = "colDuzelten";
            this.colDuzelten.Visible = true;
            this.colDuzelten.VisibleIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1257, 602);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Ekleme),
            new DevExpress.XtraBars.LinkPersistInfo(this.Güncelleme),
            new DevExpress.XtraBars.LinkPersistInfo(this.Silme),
            new DevExpress.XtraBars.LinkPersistInfo(this.Log),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnselect)});
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // KısıLıst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 679);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KısıLıst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KısıLıst_FormClosing);
            this.Load += new System.EventHandler(this.KısıLıst_Load);
            this.Shown += new System.EventHandler(this.KısıLıst_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KısıLıst_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnLog;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.SimpleButton BtnYenile;
        private DevExpress.XtraEditors.SimpleButton BtnData;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnDuzenle;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem Excel;
        private DevExpress.XtraBars.BarButtonItem Pdf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitEden;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDuzeltTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDuzelten;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarButtonItem Ekleme;
        private DevExpress.XtraBars.BarButtonItem Güncelleme;
        private DevExpress.XtraBars.BarButtonItem Silme;
        private DevExpress.XtraBars.BarButtonItem Log;
        private DevExpress.XtraBars.BarButtonItem btnhtml;
        private DevExpress.XtraBars.BarButtonItem btnword;
        private DevExpress.XtraEditors.SimpleButton btnselectall;
        private DevExpress.XtraBars.BarButtonItem btnselect;
    }
}

