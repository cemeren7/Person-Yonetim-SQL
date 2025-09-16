
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
   public static class main
    {
        public static List<Person> Personeller = new List<Person>();        
        public static List<Models.LogModel> Logs = new List<Models.LogModel>();
        public static string JsonLog = Path.Combine(Application.StartupPath, "Logs.json");
        public static DapperService SqlService { get; set; }
        public static DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 { get; set; }
    }
}
