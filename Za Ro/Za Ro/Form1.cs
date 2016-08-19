using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Za_Ro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaziPoruku_Click(object sender, EventArgs e)
        {
            btnPrikaziPoruku.Enabled = false;
            List<volim> listaPoruka = null;
            using (var db = new voljenjeEntities())
            {
                listaPoruka = new List<volim>(db.volim.ToList());
            }
            foreach (volim v in listaPoruka)
            {
                if (v.datum == DateTime.Now.Date) lblLjubavnaPoruka.Text = v.poruka.ToString();
            }
            lblSutra.Visible = true;
        }
    }
}
