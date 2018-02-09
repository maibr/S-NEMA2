using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sinema
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        
        }
        OleDbConnection adres = new OleDbConnection("providier-Microsoft.ACE.OLEDB.32.0;Data Source=database2.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        private void btngetir_Click(object sender, EventArgs e)
        {
          
           
       
            

        }

        private void kayit_Click(object sender, EventArgs e)
        {
             sayi.Text = Form1.koltuksayisi;
           
            string adsoyad = ads.Text;
            int hesap = Convert.ToInt32(sayi.Text);
            int tutar;

            if (tamsecim != null)
            {

                tutar = 25 * hesap;
                ttr.Text = Convert.ToString(tutar);


            }

            else if (ogrencisecim != null)
            {

                tutar = 15 * hesap;
                ttr.Text = Convert.ToString(tutar);

            }
            else
            {
                Hesapla.Enabled = false;

                MessageBox.Show("Sinema Bileti için seçim yapınız. Tam & Öğrenci", "Bilgilendirme Penceresi", MessageBoxButtons.RetryCancel);

            }



        }

        private void tamsecim_CheckedChanged(object sender, EventArgs e)
        {

            
                fyt.Text = "25";
                ogrencisecim.Enabled = false;
             

            
        }

        private void ogrencisecim_CheckedChanged(object sender, EventArgs e)
        {
            fyt.Text = "15";
            tamsecim.Enabled = false;
        }

        private void kayit_Click_1(object sender, EventArgs e)
        {
            if (ads.Text != "" && Form1.film != "" && Form1.koltuk != "")
            {
                komut.Connection = adres;
                komut.CommandText = "Insert Into Liste(Ad Soyad,Koltuk Sayısı,Film) Values (" + ads.Text + "" + Form1.koltuksayisi + "" + Form1.film);
                adres.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                adres.Close();
                MessageBox.Show("Kayıt Tamamlandı");
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Eksik bilgi");
            }
           
        }

        void listele ()
        {
            adres.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Liste", adres);
            adtr.Fill(ds, "Liste");
            dataGridView1.DataSource = ds.Tables["Liste"];
            adtr.Dispose();
            adres.Close();
                
            
        }
    }

}
