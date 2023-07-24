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
            t.IL = txtCity.Text;
            t.ILCE = txtTown.Text;
            t.ADRES = txtAddress.Text;
            t.BANKA = txtBank.Text;

            db.TBLCARIs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni cari kaydedildi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void FormCreateCustomer_Load(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancel_Click;
            cancelButton.Click += btnCancel_Click;
        }

        private void cancelButton_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
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
            txtCity.Text = string.Empty;
            txtTown.Text = string.Empty;
        }
    }
}
