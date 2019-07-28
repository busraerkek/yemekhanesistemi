using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class HESAP : Form
    {
       
        public HESAP()
        {
            InitializeComponent();
        }

       private void HESAP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            HESAP.ActiveForm.Hide();
            SOĞUK frm = new SOĞUK();
            frm.ShowDialog();
            HESAP frm2 = new HESAP();
            frm2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           HESAP.ActiveForm.Hide();
            sıcaklar frm = new sıcaklar();
            frm.ShowDialog();
            HESAP frm2 = new HESAP();
            frm2.Visible = true; 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekle_Silme_Güncelleme frm = new Ekle_Silme_Güncelleme();
            frm.Show();
            this.Hide();
        }
    }
}
