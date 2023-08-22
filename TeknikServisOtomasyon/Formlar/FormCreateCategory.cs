using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormCreateCategory : Form
    {
        public FormCreateCategory()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text))
            {
                TBLKATEGORI table = new TBLKATEGORI();
                table.AD = txtCategoryName.Text;
                db.TBLKATEGORI.Add(table);
                db.SaveChanges();
                MessageBox.Show("Kategori Kaydedildi !");
            }
            else
            {
                MessageBox.Show("Boş geçilemez","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Close();
            }

        }
    }
}
