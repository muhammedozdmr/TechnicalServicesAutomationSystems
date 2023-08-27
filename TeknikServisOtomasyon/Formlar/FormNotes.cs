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
    public partial class FormNotes : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormNotes()
        {
            InitializeComponent();
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            gridList.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl1.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = txtTitle.Text;
            t.ICERIK = txtInfo.Text;
            t.TARIH = dateCreate.Value;
            t.DURUM = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            gridList.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl1.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (chkStatus.Checked == true)
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not durumu güncelleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID").ToString() == null)
            {
                txtID.Text = string.Empty;
                txtInfo.Text = string.Empty;
                txtTitle.Text = string.Empty;
            }
            else
            {
                txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtTitle.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
                txtInfo.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            }
        }
    }
}
