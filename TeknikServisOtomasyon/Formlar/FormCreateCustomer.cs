using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.RichTextBox;
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
    public partial class FormCreateCustomer : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtName.Text;
            t.SOYAD = txtSurname.Text;
            t.IL = cmbCity.Text;
            t.ILCE = cmbTown.Text;
            t.ADRES = txtAddress.Text;
            t.BANKA = txtBank.Text;

            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni cari kaydedildi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void FormCreateCustomer_Load(object sender, EventArgs e)
        {
            cmbCity.Properties.DataSource = (from x in db.TBLILLER
                                             select new
                                             {
                                                 x.il_no,
                                                 x.isim
                                             }).ToList();
            
            btnCancel.Click += btnCancel_Click;
            cancelButton.Click += btnCancel_Click;
        }
        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtStatu.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtBank.Text = string.Empty;
            txtTaxDepartment.Text = string.Empty;
            txtTaxNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbCity.Properties.DataSource = (from x in db.TBLILLER
                                             select new
                                             {
                                                 x.il_no,
                                                 x.isim
                                             }).ToList();
            cmbTown.Properties.DataSource = (from x in db.TBLILCELER
                                             select new
                                             {
                                                 x.ilce_no,
                                                 x.isim,
                                                 x.il_no
                                             }).ToList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCity_EditValueChanged(object sender, EventArgs e)
        {
            var secilen = int.Parse(cmbCity.EditValue.ToString());
            cmbTown.Properties.DataSource = (from x in db.TBLILCELER
                                                 select new
                                                 {
                                                     x.ilce_no,
                                                     x.isim,
                                                     x.il_no
                                                 }).Where(y => y.il_no == secilen).ToList();
        }
    }
}
