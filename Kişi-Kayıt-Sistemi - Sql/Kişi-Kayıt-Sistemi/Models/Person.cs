using System;
namespace Kişi_Kayıt_Sistemi
{
    public class Person 
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime KayitTarih { get; set; } = DateTime.Now; 
        public string KayitEden { get; } = Environment.MachineName; 
        public string Aciklama { get; set;}
        public DateTime DuzeltTarih { get; set; } = DateTime.Now;
        public string Duzelten { get; set; } = Environment.MachineName;
    }
}
