
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
namespace Kişi_Kayıt_Sistemi
{
    public static class toolscs
    {
        public static void ShowLoad(this System.Windows.Forms.Form value, string caption)
        {
            if (main.splashScreenManager1.IsSplashFormVisible)
            {
                main.splashScreenManager1.CloseWaitForm();
            }
            main.splashScreenManager1.ShowWaitForm();
            main.splashScreenManager1.SetWaitFormCaption(caption);
        }
        public static void CloseLoad(this System.Windows.Forms.Form value)
        {
            if (main.splashScreenManager1.IsSplashFormVisible)
            {
                main.splashScreenManager1.CloseWaitForm();
            }
        }  
        public static int GetValueInt(this GridView view, int cell = 0)
        {
            int rowHandle = view.FocusedRowHandle; 
            string column = view.Columns[cell].FieldName; 
            var value = view.GetRowCellValue(rowHandle, column); 
            return Convert.ToInt32(value);
        }
        public static void showDialog(this KısıEdıt form, int id = 0)
        {
            form.id = id;
            form.ShowDialog();
        }
        public static void showDialogLog(this LogLıst form, int id = 0)
        {
            form.Logid = id; 
            form.ShowDialog();
        }
        public static void DataLogLoad()
        {
            string json = File.ReadAllText(main.JsonLog);
            main.Logs = JsonConvert.DeserializeObject<List<Models.LogModel>>(json);
        }
        public static void DataLogSave(this List<Models.LogModel> value)
        {
            string jsonsave = JsonConvert.SerializeObject(main.Logs, Formatting.Indented);
            File.WriteAllText(main.JsonLog, jsonsave);
        }
        public static void GridViewSave(this GridView View)
        {
            View.SaveLayoutToXml("grid_layout.xml");
        }
        public static void GridViewGet(this GridView getview)
        {
            getview.RestoreLayoutFromXml("grid_layout.xml");
        }
        public static void GridLogsSave(this GridView getlogssave)
        {
        getlogssave.SaveLayoutToXml("Log-List.xml");        
        }
        public static void GridLogsGet(this GridView getlogs)
        {
        getlogs.RestoreLayoutFromXml("Log-List.xml");
        }
    }
}
