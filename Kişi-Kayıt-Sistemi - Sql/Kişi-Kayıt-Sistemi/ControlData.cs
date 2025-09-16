using Dapper;
using System.Data.SqlClient;
namespace Kişi_Kayıt_Sistemi
{
    public static class ControlData
    {
        public static void DataUpdateTable(string connect)
        {
            using (var conn = new SqlConnection(connect))
            {
                conn.Open();
                var exitperson = conn.ExecuteScalar<int>(@"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Person'");
                if (exitperson == 0) // Yoksa
                {
                    conn.Execute(@"CREATE TABLE [dbo].[Person](
                        [Id] [int] IDENTITY(1,1) NOT NULL,
                        [FullName] [nvarchar](50) NULL,
                        [Phone] [nvarchar](50) NULL,
                        [Email] [nvarchar](100) NULL,
                        [KayitTarih] [datetime2](7) NULL,
                        [KayitEden] [nvarchar](50) NULL,
                        [Aciklama] [nvarchar](100) NULL,
                        [DuzeltTarih] [datetime2](7) NULL,
                        [Duzelten] [nvarchar](50) NULL,
                        [BDate] [datetime] NULL,
                        CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
                    ) ON [PRIMARY]");
                }
            }
        }
    }
}
