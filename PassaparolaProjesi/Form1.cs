using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparolaProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "CEVAPLA";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmında ki kıyı bölgesi ?";
                BTNA.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara İlimiz ?";
                BTNB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                BTNC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla Ünlü ilimiz ?";
                BTND.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                BTNE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                BTNF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                BTNG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Su kaç derecede kaynar ?";
                BTNH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne ?";
                BTNI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                BTNII.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Mersin'in diğer adı ?";
                BTNJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                BTNK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi ?";
                BTNL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali ?";
                BTNM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Yılın 3. ayı ?";
                BTNN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Üflemeli müzik aleti ney ?";
                BTNO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Halk şairi ?";
                BTNP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Çocukların pek sevmediği prinç havuç gibi sebzeler ile yapılan yemek ?";
                BTNR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "11 Ayın Sultanı ?";
                BTNS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "İngilizcede yılan ne demek ?";
                BTNT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                BTNU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkiye'nin megastarı ?";
                BTNV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                BTNY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "congratulations ne demek ?";
                BTNZ.BackColor = Color.Yellow;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            BTNA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNA.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            BTNB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNB.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            BTNC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNC.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            BTND.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTND.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            BTNE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNE.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            BTNF.BackColor = Color.Green;
                             dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNF.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            BTNG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNG.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 8:
                        if (textBox1.Text == "yüz")
                        {
                            BTNH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNH.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 9:
                        if (textBox1.Text == "halı")
                        {
                            BTNI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNI.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 10:
                        if (textBox1.Text == "ısparta")
                        {
                            BTNII.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNII.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 11:
                        if (textBox1.Text == "içel")
                        {
                            BTNJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNJ.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 12:
                        if (textBox1.Text == "jandarma")
                        {
                            BTNK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNK.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 13:
                        if (textBox1.Text == "kayısı")
                        {
                            BTNL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNL.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 14:
                        if (textBox1.Text == "lale")
                        {
                            BTNM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNM.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 15:
                        if (textBox1.Text == "mart")
                        {
                            BTNN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNN.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ney")
                        {
                            BTNO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNO.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 17:
                        if (textBox1.Text == "ozan")
                        {
                            BTNP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNP.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 18:
                        if (textBox1.Text == "pırasa")
                        {
                            BTNR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNR.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 19:
                        if (textBox1.Text == "ramazan")
                        {
                            BTNS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNS.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 20:
                        if (textBox1.Text == "snake")
                        {
                            BTNT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNT.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            BTNU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNU.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 22:
                        if (textBox1.Text == "tarkan")
                        {
                            BTNV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNV.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 23:
                        if (textBox1.Text == "van")
                        {
                            BTNY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNY.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;
                    case 24:
                        if (textBox1.Text == "tebrikler")
                        {
                            BTNZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            BTNZ.BackColor = Color.Red;
                            yanlis++;
                            labelcasa.Text = yanlis.ToString();

                        }
                        break;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
