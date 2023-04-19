using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8_bgt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nesnelerin özelliklerini ve olaylarını etkili şekilde kullanbilir. ");

            MessageBox.Show("İstenilen Kullanıcı Arayünü, Form üzerinde tasarlayabilir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Değişken

            // Değişken türlerini bilir.
            string ad;
            int sayi;
            bool yetki;
            double ortalama;

            // Değişken isimlendirme
            // Doğru          string ogrenciSoyadi; 
            // Yanlış         string ogr soyadi;
            // Yanlış         string 1ogrSoyadi;
            // Yanlış         string ogr.Soyadi;

            // Değişkene atama yapma
            int s1 = 15;
            int s2;
            s2 = s1 + 3;
            s2++;
            s1 *= 3;
            s1 = s1 + 3; //  -> s+=3;
            s2 = s2 / 4; //  -> s2/=4
            string isim;
            isim = "Ali";
            isim += " Veli";
            isim = "Ahmet";

            MessageBox.Show("Değişken Türlerini Bilir");
            MessageBox.Show("Değişken İsimlendirme kurallarını bilir ve dogru şekilde isimlendirir");
            MessageBox.Show("Değişken atamaları yapar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanicidan Bilgi Alma
            string gelenBilgi;
            gelenBilgi = textBox1.Text;
            MessageBox.Show("(String Ifade) Merhaba " + gelenBilgi);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Değişken Dönüşümü
            int dogumTarihi;
            int yas;
            dogumTarihi = Convert.ToInt32(textBox2.Text);
            yas = 2023 - dogumTarihi;
            MessageBox.Show("(Int Ifade) Yaşınız" + yas.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koşul cümlesini uygun bir şekilde yazabilir.");
            MessageBox.Show("Mantık hatası olmadan koşul ifadesi doğru çalışır.");
            MessageBox.Show("Eğer koşulunu doğru kurar IF");
            MessageBox.Show("Değilse koşulu doğru kurar ELSE");
            MessageBox.Show("Bağlaçları doğru kullanır. VE VEYA");
            MessageBox.Show("Mantıksal oparatörleri bilir");
            MessageBox.Show("Switch Case yapısını bilir");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.=>"+ (15 < 4).ToString() );
            int a = 10;
            int b = 10;
            bool c;
            c = a == b;
            MessageBox.Show("2.=>"+c.ToString());
            // == , != , && , || , > , < , >= , <=
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // IF Koşul İfadesi
            int a, b;
            a = 3;
            b = 2;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // IF ELSE Koşul İfadesi
            int a, b;
            a = 10;
            b = 70;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
            else
            {
                MessageBox.Show("a sayısı büyük değildir.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // IF ELSE IF Koşul İfadesi
            int a, b;
            a = 10;
            b = 70;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
            else if (a == b)
            {
                MessageBox.Show("a sayısı eşittir b'ye.");
            }
            else
            {
                MessageBox.Show("b sayısı büyüktür");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox2.Text);
            switch (sayi)
            {
                case 2000:
                    MessageBox.Show("2000 girilmiş");
                    break;
                case 2001:
                    MessageBox.Show("2001 girilmiş");
                    break;
                case 2002:
                    MessageBox.Show("2002 girilmiş");
                    break;
                case 2003:
                    MessageBox.Show("2003 girilmiş");
                    break;
                default:
                    MessageBox.Show("Default");
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("döngü cümlesini uygun bir şekilde yazabilir.");
            MessageBox.Show("döngü hatası olmadan doğru çalışır.");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                listBox1.Items.Add("Merhaba");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // 10 dan 50 ye kadar olan çift sayıları yazdır.
            for(int i = 10; i <= 50; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // 50 den 342 ye kadar olan sayıların toplamı kaçtır?
            int toplam=0;
            for (int i = 50; i<=342; i++)
            {
                toplam = toplam + i;
            }
            listBox1.Items.Add(toplam);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // 50 den 342 ye kadar 3 ve 8 e tam bölünebilen sayıları yazdır
            for (int i = 50; i <= 342; i++)
            {
                if( i % 3 == 0 && i % 8 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // 50 den 342 ye kadar 3 ve 8 e tam bölünebilen sayıların toplamı kaçtır?
            int toplam = 0;
            for (int i = 50; i <= 342; i++)
            {
                if (i % 3 == 0 && i % 8 == 0)
                {
                    toplam += i;
                }
            }
            listBox1.Items.Add(toplam);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // 13 ile 24 arasındaki sayıların çarpımı kaçtır?
            int carpim = 1;
            for(int i = 13; i <= 24; i++)
            {
                carpim = carpim * i;
            }
            listBox1.Items.Add(carpim);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // 7 sayısının faktöriyelini bulan programı yazınız.
            // 7! = 7.6.5.4.3.2.1

            int sonuc=1;
            for(int i = 7; i >= 1; i--)
            {
                sonuc *= i;
            }
            listBox1.Items.Add(sonuc);
        }
    }
}
