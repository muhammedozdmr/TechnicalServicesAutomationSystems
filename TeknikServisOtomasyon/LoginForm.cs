using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon
{
    public partial class LoginForm : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == txtUserName.Text & x.SIFRE == txtPassword.Text select x;
            if (sorgu.Any())
            {
                TeknikServisForm anaForm = new TeknikServisForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
