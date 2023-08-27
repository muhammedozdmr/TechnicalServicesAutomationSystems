using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormArizaDetaylar : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormArizaDetaylar()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = txtDetails.Text;
            t.TARIH = dateCreate.Value;
            t.SERINO = txtSerialNumber.Text;
            
            db.TBLURUNTAKIP.Add(t);
            MessageBox.Show("Ürün arıza detayları eklendi");

            //DURUM GÜNCELLEME
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunId = int.Parse(id);
            var deger = db.TBLURUNKABUL.Find(urunId);
            deger.URUNDURUMDETAY = cmbStatus.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları güncellendi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }

        public string id, serino;
        private void FormArizaDetaylar_Load(object sender, EventArgs e)
        {
            txtSerialNumber.Text = serino;
        }
    }
}
