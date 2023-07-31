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
    public partial class FormEmployee : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            var degerler = from p in db.TBLPERSONELs
                           select new
                           {
                               p.ID,
                               p.AD,
                               p.SOYAD,
                               p.MAIL,
                               p.TELEFON
                           };
            gridList.DataSource = degerler.ToList();

            cmbDeparment.Properties.DataSource = (from x in db.TBLDEPARTMen
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
            cmbDeparment.Properties.NullText = "Departman Seçiniz";
            cmbDeparment.Properties.DisplayMember = "AD";
            cmbDeparment.Properties.ValueMember = "ID";

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;

            //1. Personel
            ad1 = db.TBLPERSONELs.First(x => x.ID == 2).AD;
            soyad1 = db.TBLPERSONELs.First(x => x.ID == 2).SOYAD;
            labelControl8.Text = ad1 + " " + soyad1;
            labelControl9.Text = db.TBLPERSONELs.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl10.Text = db.TBLPERSONELs.First(x => x.ID == 2).MAIL;

            //2.Personel
            ad2 = db.TBLPERSONELs.First(x => x.ID == 1).AD;
            soyad2 = db.TBLPERSONELs.First(x => x.ID == 1).SOYAD;
            labelControl13.Text = ad2 + " " + soyad2;
            labelControl12.Text = db.TBLPERSONELs.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl11.Text = db.TBLPERSONELs.First(x => x.ID == 1).MAIL;

            //3. Personel
            ad3 = db.TBLPERSONELs.First(x => x.ID == 4).AD;
            soyad3 = db.TBLPERSONELs.First(x => x.ID == 4).SOYAD;
            labelControl19.Text = ad3 + " " + soyad3;
            labelControl18.Text = db.TBLPERSONELs.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl17.Text = db.TBLPERSONELs.First(x => x.ID == 4).MAIL;

            //4.Personel
            ad4 = db.TBLPERSONELs.First(x => x.ID == 3).AD;
            soyad4 = db.TBLPERSONELs.First(x => x.ID == 3).SOYAD;
            labelControl25.Text = ad4 + " " + soyad4;
            labelControl24.Text = db.TBLPERSONELs.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl23.Text = db.TBLPERSONELs.First(x => x.ID == 3).MAIL;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLPERSONEL p = new TBLPERSONEL();
            p.AD = txtName.Text;
            p.SOYAD = txtSurname.Text;
            p.FOTOGRAF = txtPhoto.Text;
            p.MAIL = txtMail.Text;
            p.TELEFON = txtPhone.Text;
            p.DEPARTMAN = byte.Parse(cmbDeparment.Properties.ValueMember);
            db.TBLPERSONELs.Add(p);
            db.SaveChanges();
            ClearForm();
        }
        private void ClearForm()
        {
            txtID.Text = null;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            cmbDeparment.Properties.ValueMember = null;
            txtPhoto.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtMail.Text = string.Empty;
        }
        private void GetListCategory()
        {
            var personal = from p in db.TBLPERSONELs
                             select new
                             {
                                 p.ID,
                                 p.AD,
                                 p.SOYAD,
                                 p.DEPARTMAN,
                                 p.MAIL,
                                 p.TELEFON,
                                 p.FOTOGRAF
                             };
            gridList.DataSource = personal.ToList();
        }
    }
}
