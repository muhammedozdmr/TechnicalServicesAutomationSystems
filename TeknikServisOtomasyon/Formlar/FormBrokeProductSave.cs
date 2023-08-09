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
    public partial class FormBrokeProductSave : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormBrokeProductSave()
        {
            InitializeComponent();
        }
        private void btnFillCustomer_Click(object sender, EventArgs e)
        {
            var serialNumber = txtSeriNo.Text;
            var serinoToPersonal = db.TBLURUNHAREKETs.Where(x => x.URUNSERINO == serialNumber).ToList();
            var data = (from u in serinoToPersonal
                        select new
                        {
                            CustomerID = u.MUSTERI,
                            Müşteri = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD
                        }).ToList();
            if (string.IsNullOrEmpty(txtSeriNo.Text))
            {
                return;
            }
            if (data.Count != 0)
            {
                cmbCustomer.DataSource = data;
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.DisplayMember = "Müşteri";
            }
            else
            {
                cmbCustomer.Text = "Bu Seri numarasına ait müşteri yok !";
            }
        }

        private void FormBrokeProductSave_Load(object sender, EventArgs e)
        {
            var customer = db.TBLCARIs.ToList();
            var dataCustomer = (from u in customer
                                select new
                                {
                                    CustomerID = u.ID,
                                    Müşteri = u.AD + " " + u.SOYAD
                                }).ToList();
            cmbCustomer.DataSource = dataCustomer;
            cmbCustomer.DisplayMember = "Müşteri";
            cmbCustomer.ValueMember = "CustomerID";
            var personal = db.TBLPERSONELs.ToList();
            var dataPersonal = (from u in personal
                                select new
                                {
                                    IdPersonal = u.ID,
                                    NamePersonal = u.AD + " " + u.SOYAD
                                }).ToList();
            cmbPersonal.DataSource = dataPersonal;
            cmbPersonal.DisplayMember = "NamePersonal";
            cmbPersonal.ValueMember = "IdPersonal";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = (int)cmbCustomer.SelectedValue;
            t.GELISTARIHI = dateProduct.Value;
            t.PERSONEL = (short)cmbPersonal.SelectedValue;
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNKABULs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün arıza girişi yapıldı.");
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