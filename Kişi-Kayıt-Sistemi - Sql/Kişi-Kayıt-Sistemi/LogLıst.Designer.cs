
namespace Kişi_Kayıt_Sistemi
{
    partial class LogLıst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogLıst));
            this.colOldValueFieldId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.logModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValueFieldId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colOldValueFieldId
            // 
            this.colOldValueFieldId.FieldName = "OldValueFieldId";
            this.colOldValueFieldId.Name = "colOldValueFieldId";
            this.colOldValueFieldId.Visible = true;
            this.colOldValueFieldId.VisibleIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.logModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(841, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // logModelBindingSource
            // 
            this.logModelBindingSource.DataSource = typeof(Kişi_Kayıt_Sistemi.Models.LogModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colChangeDate,
            this.colPC,
            this.colTableName,
            this.colFieldName,
            this.colFieldId,
            this.colOldValueFieldId,
            this.colNewValueFieldId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colChangeDate
            // 
            this.colChangeDate.FieldName = "ChangeDate";
            this.colChangeDate.Name = "colChangeDate";
            this.colChangeDate.Visible = true;
            this.colChangeDate.VisibleIndex = 1;
            // 
            // colPC
            // 
            this.colPC.FieldName = "PC";
            this.colPC.Name = "colPC";
            this.colPC.Visible = true;
            this.colPC.VisibleIndex = 2;
            // 
            // colTableName
            // 
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 3;
            // 
            // colFieldName
            // 
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 4;
            // 
            // colFieldId
            // 
            this.colFieldId.FieldName = "FieldId";
            this.colFieldId.Name = "colFieldId";
            this.colFieldId.Visible = true;
            this.colFieldId.VisibleIndex = 5;
            // 
            // colNewValueFieldId
            // 
            this.colNewValueFieldId.FieldName = "NewValueFieldId";
            this.colNewValueFieldId.Name = "colNewValueFieldId";
            this.colNewValueFieldId.Visible = true;
            this.colNewValueFieldId.VisibleIndex = 7;
            // 
            // LogLıst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 427);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogLıst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Kayıtları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogLıst_FormClosing);
            this.Load += new System.EventHandler(this.LogLıst_Load);
            this.Shown += new System.EventHandler(this.LogLıst_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogLıst_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource logModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldId;
        private DevExpress.XtraGrid.Columns.GridColumn colOldValueFieldId;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValueFieldId;
    }
}