using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormCustomerCity : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        SqlConnection conn = new SqlConnection(@"Data Source=OZDEMIR;Initial Catalog=DbTeknikServis;Integrated Security=True");
        public FormCustomerCity()
        {
            InitializeComponent();
        }
        private void FormCustomerCity_Load(object sender, EventArgs e)
        {
            gridList.DataSource = db.TBLCARIs.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();
            conn.Open();
            SqlCommand command = new SqlCommand("select IL,count(*) from TBLCARI group by IL", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));
            }
            conn.Close();
        }
    }
}
