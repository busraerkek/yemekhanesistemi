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
    public partial class SOĞUK : Form
    {
        SqlConnection bağlanti = new SqlConnection("Data Source=.; Initial Catalog=yemekhane;Integrated Security=True");
        SqlCommand komut;
       
        public SOĞUK()
        {
            InitializeComponent();

        }
        HESAP form1 = new HESAP();
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            komut = new SqlCommand("Select *from ymkhne where ürünler='meyve suyu' and fiyatlar=0.7500 ", bağlanti);
       if(bağlanti.State==ConnectionState.Closed)
               bağlanti.Open();
                    SqlDataReader dr=komut.ExecuteReader();
                    while (dr.Read())
                    {
                       form1.listBox1.Items.Add(dr[1]);
                       form1.listBox1.Items.Add(dr[2]);
                     
                        //form1.Show();//atadığımız ismi yazdık buraya
                    }
                        bağlanti.Close();

                    
        }

        private void SOĞUK_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            sıcaklar frm = new sıcaklar();
            frm.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            HESAP frm = new HESAP();
            frm.Show();
            this.Hide();
            //form1.Show();//atadığımız ismi yazdık buraya
        }
    }
}

