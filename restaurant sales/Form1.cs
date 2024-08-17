using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_2023
{
    public partial class Form1 : Form
    {
        private int yemeklerCount = 0;
        private int salataCount = 0;
        private int pastaCount = 0;
        private int tatliCount = 0;
        private int drinkCount = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeCheckedListBox();
        }
        public ListBox GetListBox()
        {
            return gizList;
        }
        public void InitializeCheckedListBox()
        {
            Yemekler.Click += CheckedListBox1_Click;
            Salatalar.Click += CheckedListBox1_Click;
        }
        public void CheckedListBox1_Click(object sender, EventArgs e)
        {           
            yemeklerCount++;
            salataCount++;
            drinkCount++;
            pastaCount++;
            tatliCount++;   
            UpdateClickCount();
        }
        public void UpdateClickCount()
        {
            Makarna makarna = new Makarna();
            makarna.stok = 25;

            Salata salad = new Salata();
            salad.stok = 25;

            Yemek food = new Yemek();
            food.stok = 25;

            Tatli dessert = new Tatli();
            dessert.stok = 25;

            İcecek drink = new İcecek();
            drink.stok = 100;


            int yemek, salata, pasta, tatli, icecek;

            yemek = food.stok - yemeklerCount;
            gizList.Items.Add("YEMEK Yapılan Satış: " + yemeklerCount.ToString()+" | " + "Kalan Stok: " + yemek.ToString());
            gizList.Items.Add("\n");
            salata = salad.stok - salataCount;
            gizList.Items.Add("SALATA Yapılan Satış: " + salataCount.ToString()+" | " + "Kalan Stok: " + salata.ToString());
            gizList.Items.Add("\n");
            pasta =makarna.stok- pastaCount;
            gizList.Items.Add("MAKARNA Yapılan Satış: " + pastaCount.ToString()+" | " + "Kalan Stok: " + pasta.ToString());
            gizList.Items.Add("\n");
            tatli =dessert.stok- tatliCount;
            gizList.Items.Add("TATLI Yapılan Satış: " + tatliCount.ToString()+" | " + "Kalan Stok: " + tatli.ToString());
            gizList.Items.Add("\n");
            icecek =drink.stok- drinkCount;
            gizList.Items.Add("İÇECEK Yapılan Satış: " + drinkCount.ToString()+" | " + "Kalan Stok: " + icecek.ToString());
            gizList.Items.Add("\n");
        }

        public void button1_Click(object sender, EventArgs e)
        {

            foreach (var checkedItem in Yemekler.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
            }

            foreach (var checkedItem in Makarnalar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
            }

            foreach (var checkedItem in Salatalar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
            }

            foreach (var checkedItem in Tatlılar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
            }

            foreach (var checkedItem in İçecekler.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            gizList.Visible = false;

            Siparis orders = new Siparis();
            orders.ActivateListBox();

            Yemek food = new Yemek();
            food.adi = "Zeytinyağlı Dolmalar ve Sarma";
            food.fiyati = 180;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            food.adi = "Şarküteri Tabağı";
            food.fiyati = 210;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            food.adi = "Nar Soslu İmam Bayıldı";
            food.fiyati = 200;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            food.adi = "Mantar Soslu Bonfile";
            food.fiyati = 180;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            food.adi = "Köri Soslu Tavuk";
            food.fiyati = 180;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            food.adi = "Izgara Köfte";
            food.fiyati = 180;
            food.kdvOrani = 2;
            food.cins = "Yemek";
            Yemekler.Items.Add(food.adi + " : " + food.fiyati + " ₺");

            Makarna pasta = new Makarna();
            pasta.adi = "Fettucini Alfredo";
            pasta.fiyati = 110;
            pasta.kdvOrani = 3;
            pasta.cins = "Makarna";
            Makarnalar.Items.Add(pasta.adi + " : " + pasta.fiyati + " ₺");

            pasta.adi = "Acı Soslu Penne";
            pasta.fiyati = 110;
            pasta.kdvOrani = 3;
            pasta.cins = "Makarna";
            Makarnalar.Items.Add(pasta.adi + " : " + pasta.fiyati + " ₺");

            pasta.adi = "Tavuklu Mantarlı Fettuccine";
            pasta.fiyati = 120;
            pasta.kdvOrani = 3;
            pasta.cins = "Makarna";
            Makarnalar.Items.Add(pasta.adi + " : " + pasta.fiyati + " ₺");

            pasta.adi = "Spaghetti Bolognese";
            pasta.fiyati = 110;
            pasta.kdvOrani = 3;
            pasta.cins = "Makarna";
            Makarnalar.Items.Add(pasta.adi + " : " + pasta.fiyati + " ₺");

            pasta.adi = "Dört Peynirli Ravioli";
            pasta.fiyati = 120;
            pasta.kdvOrani = 3;
            pasta.cins = "Makarna";
            Makarnalar.Items.Add(pasta.adi + " : " + pasta.fiyati + " ₺");

            Salata salad = new Salata();
            salad.adi = "Hardal Soslu Bonfile Salatası";
            salad.fiyati = 130;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            salad.adi = "Ton Balıklı Salata";
            salad.fiyati = 130;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            salad.adi = "Avakado ve Tulum Peynirli Salata";
            salad.fiyati = 100;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            salad.adi = "Sezar Salata";
            salad.fiyati = 80;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            salad.adi = "Keçi Peynirli Ahir Dağı Salatası";
            salad.fiyati = 120;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            salad.adi = "Çıtır Kinoalı Yedikule Salatası";
            salad.fiyati = 80;
            salad.kdvOrani = 2;
            salad.cins = "Salata";
            Salatalar.Items.Add(salad.adi + " : " + salad.fiyati + " ₺");

            Tatli dessert = new Tatli();
            dessert.adi = "Tiramisu";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "San Sebastian";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Fırın Cheescake";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Muzlu Malaga";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Geleneksel Türk Tatlı Tabağı";
            dessert.fiyati = 120;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Elmalı Tarte Tatin";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Baklava";
            dessert.fiyati = 150;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            dessert.adi = "Kahveli Ganaj";
            dessert.fiyati = 80;
            dessert.kdvOrani = 1;
            dessert.cins = "Tatlı";
            Tatlılar.Items.Add(dessert.adi + " : " + dessert.fiyati + " ₺");

            İcecek drink = new İcecek();
            drink.adi = "Demeleme Çay";
            drink.fiyati = 5;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Türk Kahvesi";
            drink.fiyati = 30;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Limonata";
            drink.fiyati = 45;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Sıkma Elma Suyu";
            drink.fiyati = 45;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Americano";
            drink.fiyati = 55;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Latte";
            drink.fiyati = 65;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Milkshake";
            drink.fiyati = 50;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Su";
            drink.fiyati = 5;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Ayran";
            drink.fiyati = 10;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");

            drink.adi = "Espresso";
            drink.fiyati = 10;
            drink.kdvOrani = 0;
            drink.cins = "İçecek";
            İçecekler.Items.Add(drink.adi + " : " + drink.fiyati + " ₺");
        }
        public void button2_Click(object sender, EventArgs e)
        {
        
            listBox1.Items.Clear(); 
            label9.Text = string.Empty;

            for (int i = 0; i < Makarnalar.Items.Count; i++)
            {
                Makarnalar.SetItemChecked(i, false);
            }
           
            for (int i = 0; i < Salatalar.Items.Count; i++)
            {
                Salatalar.SetItemChecked(i, false);
            }

            for (int i = 0; i < İçecekler.Items.Count; i++)
            {
                İçecekler.SetItemChecked(i, false);
            }

            for (int i = 0; i < Tatlılar.Items.Count; i++)
            {
                Tatlılar.SetItemChecked(i, false);
            }

            for (int i = 0; i < Yemekler.Items.Count; i++)
            {
                Yemekler.SetItemChecked(i, false);
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            decimal toplamFiyat = 0;

            listBox1.Items.Clear();
            label9.Text = string.Empty;

            foreach (var checkedItem in Yemekler.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());
   
                string[] itemParts = checkedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (itemParts.Length == 2 && decimal.TryParse(itemParts[1].Trim().Split(' ')[0], out decimal fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }

            foreach (var checkedItem in Makarnalar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());

                string[] itemParts = checkedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (itemParts.Length == 2 && decimal.TryParse(itemParts[1].Trim().Split(' ')[0], out decimal fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }

            foreach (var checkedItem in İçecekler.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());

                string[] itemParts = checkedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (itemParts.Length == 2 && decimal.TryParse(itemParts[1].Trim().Split(' ')[0], out decimal fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }

            foreach (var checkedItem in Salatalar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());

                string[] itemParts = checkedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (itemParts.Length == 2 && decimal.TryParse(itemParts[1].Trim().Split(' ')[0], out decimal fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }

            foreach (var checkedItem in Tatlılar.CheckedItems)
            {
                listBox1.Items.Add(checkedItem.ToString());

                string[] itemParts = checkedItem.ToString().Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (itemParts.Length == 2 && decimal.TryParse(itemParts[1].Trim().Split(' ')[0], out decimal fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }

            label9.Text=toplamFiyat.ToString("C2");
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            Form2 form2 = new Form2(gizList.Items);
            form2.ShowDialog();
        }

       
    }
}

