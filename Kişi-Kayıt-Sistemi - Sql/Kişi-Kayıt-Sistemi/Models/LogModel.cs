using System;
namespace Kişi_Kayıt_Sistemi.Models
{
    public class LogModel
    {
        public int Id { get; set; }
        public DateTime ChangeDate { get; set; }
        public string PC { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public int FieldId { get; set; }
        public string OldValueFieldId { get; set; }
        public string NewValueFieldId { get; set; }
        public string LocalIp { get; set; }
    }
}
