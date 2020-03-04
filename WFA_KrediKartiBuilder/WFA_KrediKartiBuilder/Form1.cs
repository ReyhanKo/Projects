using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KrediKartiBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var tip in kartTipi)
            {
                cmbKartTip.Items.Add(tip);
            }
        }
        string[] bankalar = {"Garanti Bankası", "Türkiye İş Bankası" };
        string[] kartTipi = {"Master","Visa" };
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtBankaAdi.Text;
            lvi.SubItems.Add(cmbKartTip.Text);
            lvi.SubItems.Add(nudKartLimit.Value.ToString());
            lvi.SubItems.Add(rbTaksit.Checked.ToString());

            listView1.Items.Add(lvi);
        }

        
    }
}
