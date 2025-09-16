using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
namespace Kişi_Kayıt_Sistemi
{
    public partial class KısıEdıt : XtraForm
    {
        public KısıEdıt()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        // LOCAL IP GET
        string LocalIpGet = Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(c => c.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString();
        public int Idadd()
        {
            if (main.Logs.Any())
                return main.Logs.Max(x => x.Id) + 1;
            else
                return 0;
        }
        public int id;
        List<Person> Kişiler = new List<Person>();
        private void KısıEdıt_Shown(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var temp = main.Personeller.Where(c => c.Id == id).ToList();
                Kişiler = new List<Person>
                { new Person
                {
                     Id = temp.FirstOrDefault().Id,
                     FullName = temp[0].FullName,
                     Phone = temp[0].Phone,
                     Email = temp[0].Email,
                     Aciklama = temp[0].Aciklama,
                     KayitTarih = temp[0].KayitTarih,
                     DuzeltTarih = temp[0].DuzeltTarih,
                }
                };
            }
            else
            {
                Kişiler.Add(new Person
                {
                    Id = 0,
                });
            }
            bindingSource1.DataSource = Kişiler;
        }
        private void KısıEdıt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BtnSave.PerformClick();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            if (TxtAdSoyad.Text.Trim() == "")
            {
                XtraMessageBox.Show("Ad Soyad Alanı Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (id > 0)
                {
                    var index = main.Personeller.FindIndex(c => c.Id == id);
                    if (index >= 0)
                    {
                        Kişiler[0].DuzeltTarih = DateTime.Now;
                        Kişiler[0].Duzelten = Environment.MachineName;
                        if (Kişiler[0].FullName != main.Personeller[index].FullName)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].FullName;
                            logModel.NewValueFieldId = Kişiler[0].FullName;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "FullName";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = LocalIpGet;
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Phone != main.Personeller[index].Phone)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Phone;
                            logModel.NewValueFieldId = Kişiler[0].Phone;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Phone";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = LocalIpGet;
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Email != main.Personeller[index].Email)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Email;
                            logModel.NewValueFieldId = Kişiler[0].Email;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Email";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = LocalIpGet;
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Aciklama != main.Personeller[index].Aciklama)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Aciklama;
                            logModel.NewValueFieldId = Kişiler[0].Aciklama;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Aciklama";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = LocalIpGet;
                            main.Logs.Add(logModel);
                        }
                        main.Logs.DataLogSave();
                        main.SqlService.UpdateSql("Person", Kişiler[0]);
                        main.Personeller[index] = Kişiler[0];
                    }
                }
                else
                {
                    var resp = main.SqlService.Insert(Kişiler[0]);
                    if (!string.IsNullOrEmpty(resp.msg))
                    {
                        XtraMessageBox.Show(resp.msg);
                    }
                    else
                    {
                        Kişiler[0].Id = resp.Id;
                        main.Personeller.Add(Kişiler[0]);
                    }
                }
                this.Close();
            }
        }
    }
}
