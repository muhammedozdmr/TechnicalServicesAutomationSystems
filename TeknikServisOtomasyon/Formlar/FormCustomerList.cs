using DevExpress.Skins.XtraForm;
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
    public partial class FormCustomerList : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            gridList.DataSource = db.TBLCARIs.ToList();
        }
    }
}
