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
    public partial class FormCreateDepartment : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormCreateDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length <= 50 && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(textEdit1.Text))
            {
                TBLDEPARTMAN table = new TBLDEPARTMAN();
                table.AD = txtName.Text;
                table.ACIKLAMA = textEdit1.Text;
                db.TBLDEPARTMen.Add(table);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman adı 50 karakteri geçemez ! Açıklama boş geçilemez","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearForm();
            }
        }
        private void ClearForm()
        {
            txtName.Text = string.Empty;
            textEdit1.Text = string.Empty;
        }

        private void FormCreateDepartment_Load(object sender, EventArgs e)
        {
            btnCancel.Click += btnCancel_Click;
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
