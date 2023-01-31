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

namespace Pastane_Ürün_Maliyetlendirme_Sistemi
{
    //Data Source=LAPTOP-9MADQ7Q9\SQLEXPRESS01;Initial Catalog="Test_Maliyet";Integrated Security=True
    //Data Source=LAPTOP-9MADQ7Q9\SQLEXPRESS01;Initial Catalog="Film Arşivim";Integrated Security=True


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        void MalzemeListesi()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select*From TBLMALZEMELER",baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select*from TBLURUNLER", baglantı);
            DataTable dt2=new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select*from TBLKASA", baglantı);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Urunler()
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*From TBLURUNLER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "URUNID"; //Arka planda hangi veriyi alacağı belirlendi
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = dt;
            baglantı.Close();
        }
        void Malzemeler() //Combobox ögesine değerleri ataması yapıldı
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*From TBLMALZEMELER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.ValueMember = "MALZEMEID";
            comboBox2.DisplayMember = "AD";
            comboBox2.DataSource = dt;
            baglantı.Close();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=LAPTOP-9MADQ7Q9\SQLEXPRESS01;Initial Catalog=Test_Maliyet;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListesi();
            Urunler();

            Malzemeler();
            
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void BtnMalzeme_Click(object sender, EventArgs e)
        {
            MalzemeListesi();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void BtnÇıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values(@p1,@p2,@p3,@p4)", baglantı);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",decimal.Parse( TxtStok.Text));
            komut.Parameters.AddWithValue("@p3",decimal.Parse(TxtFıyat.Text));
            komut.Parameters.AddWithValue("@p4",TxtNotlar.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListesi();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut=new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALİYET) values(@p1,@p2,@p3,@p4)",baglantı);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(textBox13.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(textBox14.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Malzeme Eklendi");

            listBox1.Items.Add(comboBox2.Text + "-" + textBox14.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select*From TBLMALZEMELER where MALZEMEID=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox14.Text = dr[3].ToString();

            }
            maliyet= Convert.ToDouble(textBox14.Text)/1000*Convert.ToDouble(textBox13.Text);

            textBox14.Text=maliyet.ToString();  
            baglantı.Close();
        }
    }
}
