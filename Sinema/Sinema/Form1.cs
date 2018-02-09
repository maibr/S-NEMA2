using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form1 : Form
    {
        public Form1()

        {



            InitializeComponent();

            comboBox1.Items.Add("Ayla");
            comboBox1.Items.Add("Yanlış Anlama");
            checkedListBox1.Items.Add("A1");
            checkedListBox1.Items.Add("A2");
            checkedListBox1.Items.Add("A3");
            checkedListBox1.Items.Add("A4");
            checkedListBox1.Items.Add("A5");
            checkedListBox1.Items.Add("A6");
            checkedListBox1.Items.Add("A7");
            checkedListBox1.Items.Add("A8");
            checkedListBox1.Items.Add("B1");
            checkedListBox1.Items.Add("B2");
            checkedListBox1.Items.Add("B3");
            checkedListBox1.Items.Add("B4");
            checkedListBox1.Items.Add("B5");
            checkedListBox1.Items.Add("B6");
            checkedListBox1.Items.Add("B7");
            checkedListBox1.Items.Add("B8");
        }
        public static string film, koltuk, koltuksayisi;
      

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          koltuksayisi = checkedListBox1.CheckedItems.Count.ToString();
           
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            film = comboBox1.Text;
            string koltuklar = checkedListBox1.Text;
            
            if (comboBox1.Text != null && checkedListBox1.Text !=null)
            {
             Bilet form2 = new Bilet();
            form2.Show();
            }

            else
            {
                MessageBox.Show("Seçim yapınız...");
               
            }

           
        }

    }
}
