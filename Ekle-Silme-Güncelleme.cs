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
    public partial class Ekle_Silme_Güncelleme : Form
    {
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        public Ekle_Silme_Güncelleme()
        {
            InitializeComponent();
        }

        String bağlanti = @"Data Source=.;Initial Catalog=yemekhane;Integrated Security=True";
        String komut = "Select *from ymkhne  ";
        //Form1 içerisinde methodlardan bağımsız kullanabilmek için SqlConnection, SqlDataAdapter ve Dataset nesnelerini tanımlıyoruz
        SqlConnection sqlCon;
        SqlDataAdapter da;
        DataSet ds;






        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Silme_Güncelleme_Load(object sender, EventArgs e)
        {

        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "mp3 dosyaları|*.mp3|MVA dosyaları|*.mva";

            OpenFileDialog1.FilterIndex = 0;
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Title = "Lütfen Müzik Seçiniz";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = OpenFileDialog1.FileName.ToString();
                String müzik_yol = textBox1.Text;
                player.URL = müzik_yol;
                player.Ctlcontrols.play();
            }



        }

        private void kayıtgetir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            kayıtgetir1.DataSource = null; //Her click de datasource u null a eşitleyip içeriğini temizliyoruz


            sqlCon = new SqlConnection(bağlanti);//Yukarıda tanımladığımız Sql nesnesini oluşturup sqlStr ile veritabanımıza bağlanıyoruz

            sqlCon.Open(); //bağlantıyı açıyoruz

            da = new SqlDataAdapter(komut, sqlCon);//dataapter nesnesini oluşturup sqlCmd sorgu cümlesini ve sqlCon veritabanı bağlantımızı yazıyoruz

            ds = new DataSet();//dataset nesnesini oluşturuyoruz

            da.Fill(ds,"ymkhne");//sqlCmd sorgusundan gelen veriyi dataset nesnesine ekliyoruz. 

            if (ds.Tables[0].Rows.Count == 0)// tabloda herhangi bir veri yoksa (boşsa) aşağıdaki blok çalışacak
            {
                return;//kayıt olmadığı için return ile bloğun dışına çıkıyoruz
            }

            else//kayıt varsa
            {

                kayıtgetir1.DefaultCellStyle.BackColor = Color.White;//Default hücre stilini rengini belirliyouz
                kayıtgetir1.AlternatingRowsDefaultCellStyle.BackColor = Color.DeepPink;//Alternatif satır default hücre stil rengini belirliyoruz
                kayıtgetir1.DataSource = ds.Tables["ymkhne"];//sqlCmd sorgusu ile çektiğimiz kayıtlar datagridview1 üzerinde gösteriliyor

            }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Hata : "+ex); //Veritabanına bağlantı sırasında alınan bir hata varsa burada gösteriliyor
            }
            finally //button1_Click olduğu sürece bu bloğa uğramadan uygulama sonlanmıyo
            {
                sqlCon.Close(); //Açık olan Sql bağlantısı sonlandırılıyor
                da.Dispose(); //SqlDataApter nesnesi dispose edili
            }           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HESAP frm = new HESAP();
            frm.Show();
            this.Hide();
        }
               
    }
}
      
    

