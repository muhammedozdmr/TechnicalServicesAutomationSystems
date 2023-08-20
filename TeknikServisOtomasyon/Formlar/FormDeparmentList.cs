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
    public partial class FormDeparmentList : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormDeparmentList()
        {
            InitializeComponent();
        }

        private void FormDeparmentList_Load(object sender, EventArgs e)
        {
            FormListRefresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (txtProductName.Text.Length <= 50 && !string.IsNullOrWhiteSpace(txtProductName.Text)
                && richTextBox1.Text.Length > 1 && richTextBox1.Text.Length <= 100)
            {
                t.AD = txtProductName.Text;
                t.ACIKLAMA = richTextBox1.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormListRefresh();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgilerde hata mevcut İsim 50 karakteri Açıklama 100 karakteri geçemez !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearForm();
            }
            
        }

        private void GetListCategory()
        {
            var department = from u in db.TBLDEPARTMAN
                             select new
                             {
                                 u.ID,
                                 u.AD,
                                 u.ACIKLAMA
                             };
            gridList.DataSource = department.ToList();
            lblCountDeparment.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl6.Text = db.TBLPERSONEL.Count().ToString();
        }
        private void FormListRefresh()
        {
            GetListCategory();
        }

        private void ClearForm()
        {
            txtProductID.Text = null;
            txtProductName.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtProductID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtProductName.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            richTextBox1.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman silindi !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            FormListRefresh();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = txtProductName.Text;
            deger.ACIKLAMA = richTextBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Departman başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormListRefresh();
            ClearForm();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormListRefresh();
            ClearForm();
        }
    }
}
