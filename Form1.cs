using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button2.Text;

            label8.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;

            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;

            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text=button1.Text;
            if(label7.Text== label8.Text)
            {
                dogru++;
                label5.Text=dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }


        int soruno = 0, dogru = 0, yanlis = 0;

        private void button5_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible= false;
            pictureBox2.Visible = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            soruno++;
            label4.Text= soruno.ToString();
        
            if(soruno==1)
            {
                richTextBox1.Text = "Kıvılcım hangi kolejin müdürüdür?";
                button1.Text="Ataberk Koleji";
                button2.Text="Milenyum Koleji";
                button3.Text="Rönesans Koleji";
                button4.Text="Mef Koleji";

                label7.Text ="Milenyum Koleji";
     
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Mustafa kiminle restoran açmıştır?";
                button1.Text ="Pembe Hanım";
                button2.Text ="Kıvılcımın eski eşi Kayhan ";
                button3.Text ="Sönmez Anne";
                button4.Text ="Nilay";

                label7.Text ="Sönmez Anne";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Pembe Hanım hangi hayvan yüzünden duvar kağıdını Nilay ile bırlikte parçalamıştır? ";
                button1.Text ="Domuz";
                button2.Text ="Geyik";
                button3.Text ="Timsah";
                button4.Text ="Tavşan";

                label7.Text ="Domuz";
            }



            if (soruno == 4)
            {
                richTextBox1.Text = "Metehan Ünal , Ömer Ünal'ın biyolojik babası mıdır?";
                button1.Text ="Evet";
                button2.Text ="Hayır";
                button3.Text ="Kalben öyledir.";
                button4.Text ="Banane ya daha çok kıvılcım ömer sahnesi gelsin";

                label7.Text ="Kalben öyledir.";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Kıvılcımın Ömer için söylediği şarkı aşağıdakilerden hangisidir?";
                button1.Text ="Rüyamda Buluttum";
                button2.Text ="Bırak Kadının Olayım";
                button3.Text ="Gaz Pedal";
                button4.Text ="Bir Tek Ben Anlarım";

                label7.Text ="Rüyamda Buluttum";

                button5.Text ="Sonuçlar: ";
            }

            if (soruno == 6)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış" + yanlis);
            }



        }
    }
}
