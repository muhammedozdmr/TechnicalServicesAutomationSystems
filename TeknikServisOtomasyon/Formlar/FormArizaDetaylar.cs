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
            db.TBLURUNTAKIPs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları eklendi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
    }
}
