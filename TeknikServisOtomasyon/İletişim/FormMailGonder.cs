using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DevExpress.XtraMap;

namespace TeknikServisOtomasyon.İletişim
{
    public partial class FormMailGonder : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormMailGonder()
        {
            InitializeComponent();
        }

        private void FormMailGonder_Load(object sender, EventArgs e)
        {
            cmbCari.Properties.DataSource = (from x in db.TBLILETISIM
                                             select new
                                             {
                                                 x.ID,
                                                 x.ADSOYAD,
                                                 x.MAIL
                                             }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gonderici@mail.com";
            string sifre = "mail_adresi_sifresi";
            string alici = cmbCari.Text;
            string konu = txtKonu.Text;
            string icerik = txtİcerik.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            //kullanılan mail platfomunun smtpsi yazılır microsoftsa değiştir.
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("E-Posta gönderildi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
