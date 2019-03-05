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

namespace RFID
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6HE2FV2\\SQLEXPRESS;Initial Catalog=rfid;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txt_ad.Clear();
            txt_id.Clear();
            txt_num.Clear();
            txt_soyad.Clear();
        }

        bool durum;

        void tekrarkontrol()
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select * from rfid_table where uid = @p1 OR numara=@p3 ", baglanti);

            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.Parameters.AddWithValue("@p3", txt_num.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            dr.Close();
            baglanti.Close();
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "select * from rfid_table";
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "rfid_table");
            dataGridView1.DataSource = ds.Tables["rfid_table"];
            dataGridView1.Columns[0].Visible = true;
            /* --TABLONUN İLK SÜTUNU OLAN ID KISMININ GÖZÜKMEMESİ İÇİN*/

            dataGridView1.ClearSelection();
            baglanti.Close();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;

                tekrarkontrol();
                if (durum == true)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string s1 = txt_ad.Text;
                    string s2 = txt_soyad.Text;
                    string s3 = txt_num.Text;
                    string s4 = txt_id.Text;
                    string s5 = s1.Trim() + " " + s2.Trim();
                    cmd.CommandText = "INSERT INTO rfid_table(uid,isim,numara) VALUES ('" + s4 + "','" + s5 + "' ,'" + s3 + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Tamamlandı !");
                    temizle();
                }
                else
                {

                    MessageBox.Show("Bu kayıt zaten var");
                }

            }
            catch
            {
                MessageBox.Show("HATA!");
            }




        }
        void oku()
        {

            serialPort1.Open();
            string giris = serialPort1.ReadLine();
            serialPort1.Close();
            txt_id.Text = giris;
        }
        private void btn_oku_Click(object sender, EventArgs e)
        {
            oku();
           
            
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            
            if (txt_dogrulama.Text == txt_id.Text)
            {
                MessageBox.Show("Kayıt Var!");
            }
            else
            {
                MessageBox.Show("Kayıt Yok!");
            }
 
        }
    }
}
