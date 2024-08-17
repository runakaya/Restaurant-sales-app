using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Collections;

namespace Proje_2023
{
    public partial class Form2 : Form
    {
        public Form2(IEnumerable items)
        {
            InitializeComponent();

            foreach (var item in items)
            {
                raporList.Items.Add(item);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(kapat1, "Kapat");
            toolTip.SetToolTip(kapat2, "Kapat");
            toolTip.SetToolTip(kapat3, "Kapat");

            Depo.Visible = false;
            kapat1.Visible = false;
            AddText.Visible = false;
            Kaydet.Visible = false;
            raporList.Visible = false;
            kapat2.Visible = false;
            kapat3.Visible = false;

            Urun urun = new Urun();

            urun.urunAdi = "Fettucini";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 100;
            urun.stok = 10;
            urun.fiyat = 100;
            string dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            string veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;
         
            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Krema";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 20;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Mantar";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 20;
            urun.stok = 15;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Sarımsak";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 2;
            urun.stok = 20;
            urun.fiyat = 90;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Parmesan Peyniri";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 20;
            urun.fiyat = 150;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Tavuk GÖğsü";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 10;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Maydonoz";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 0.8;
            urun.stok = 20;
            urun.fiyat =30;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Penne Makarna";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 70;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Domates";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 3;
            urun.stok = 20;
            urun.fiyat = 10;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Acılı Sos";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Ağustos 2023";
            urun.kalori = 10;
            urun.stok = 10;
            urun.fiyat = 10;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Tereyağı";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 100;
            urun.stok = 10;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Baharatlar";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 50;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Sıvıyağ";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 884;
            urun.stok = 20;
            urun.fiyat = 180;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Spagetti";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 250;
            urun.stok = 5;
            urun.fiyat = 40;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kıyma";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Havuç";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 5;
            urun.fiyat = 25;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Soğan";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Sarımsak";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Un";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 60;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Yumurta";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 20;
            urun.fiyat = 80;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Bonfile";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 150;
            urun.stok = 10;
            urun.fiyat = 300;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Reyhan";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 30;
            urun.stok = 5;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Ton Balığı";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 150;
            urun.stok = 5;
            urun.fiyat = 240;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Yeşillikler";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 10;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Göbek Marul";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 40;
            urun.stok = 5;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Konserve Mısır";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 30;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Avakado";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 5;
            urun.fiyat = 39;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Labne";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 127;
            urun.stok = 5;
            urun.fiyat = 45;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Gravyer Peyniri";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 80;
            urun.stok = 5;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kornişon Turşu";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 350;
            urun.stok = 5;
            urun.fiyat = 60;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Ceviz";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 5;
            urun.fiyat = 200;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Tulum Peyniri";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 90;
            urun.stok = 5;
            urun.fiyat = 110;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Rofkor";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Keçi Peyniri";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Salata";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 2;
            urun.stok = 5;
            urun.fiyat = 3;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kaşar";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 150;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Tost Ekmeği";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 110;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Göbek Salata";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 5;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Keçi Peyniri";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 150;
            urun.stok = 5;
            urun.fiyat = 200;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = " Çıtır Yedikule Marulu";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Nohut";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 60;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Soslar";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Pirinç";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 20;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Dolmalık Biber";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 60;
            urun.stok = 5;
            urun.fiyat = 15;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kuş Üzümü";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 25;
            urun.stok = 5;
            urun.fiyat = 80;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Salam";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat =100;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Sosis";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Pastırma";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 200;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Dana Jambon";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Ağustos 2023";
            urun.kalori = 1000;
            urun.stok = 5;
            urun.fiyat = 350;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Hindi Füme";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Ağustos 2023";
            urun.kalori = 700;
            urun.stok = 5;
            urun.fiyat = 300;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Patlıcan";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Ağustos 2023";
            urun.kalori = 100;
            urun.stok = 5;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Biber";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Ağustos 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kakao";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 10;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Şeker";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 1500;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Yulaf";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Margarin";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 800;
            urun.stok = 5;
            urun.fiyat = 80;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Muz";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 50;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Çikolata";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 500;
            urun.stok = 20;
            urun.fiyat = 500;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Elma";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 30;
            urun.stok = 5;
            urun.fiyat = 30;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Yoğurt";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 100;
            urun.stok = 5;
            urun.fiyat = 120;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Kahve";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 40;
            urun.stok = 5;
            urun.fiyat = 70;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Çay";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 10;
            urun.fiyat = 12;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Türk Kahvesi";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 5;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Limon";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 45;
            urun.stok = 5;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda açar
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); //yukarıda girdiğim veriyi dosyaya yazdırır.
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Espresso";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 5;
            urun.fiyat = 50;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Süt";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "5 Eylül 2023";
            urun.kalori = 10;
            urun.stok = 10;
            urun.fiyat = 20;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            urun.urunAdi = "Ayran";
            urun.uretimTarihi = "5 Ağustos 2023";
            urun.sonKullanmaTarihi = "12 EYlül 2023";
            urun.kalori = 10;
            urun.stok = 10;
            urun.fiyat = 15;
            dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            veri = urun.urunAdi + " | " + "Son Tüketim Tarihi: " + urun.sonKullanmaTarihi + ",  " + "Stok Durumu: " + urun.stok + ",  " + "Adet Fiyatı: " + urun.fiyat;

            try
            {
                // Dosyayı belirtilen yolda varsa açar, yoksa oluşturur
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(veri); // Kullanıcının girdiği veriyi dosyaya yazar
                    Console.WriteLine("Veri dosyaya eklendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Depo.Visible = true;
            kapat1.Visible = true;
            DepoView.Enabled = false;
            KayitGuncelleme.Enabled = false;
            Rapor.Enabled = false;
            string depo = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            
            try
            {
                using (StreamReader reader = new StreamReader(depo))
                {
                    string satir;
                    while ((satir = reader.ReadLine()) != null)
                    {
                        Depo.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            kapat1.Visible = false;
            Depo.Visible = false;
            DepoView.Enabled = true;
            KayitGuncelleme.Enabled=true;
            Rapor.Enabled = true;

            string filePath = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitGuncelleme.Enabled = false;
            AddText.Visible = true;
            Kaydet.Visible = true;
            kapat3.Visible = true;
            DepoView.Enabled = false;
            Rapor.Enabled = false;

            AddText.Clear();
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
                try
                {
                    string dosyaYolu = @"C:\Users\RANA\OneDrive\Masaüstü\Depo.txt.txt";
                    string kayitEkle = AddText.Text;
                    using (StreamWriter writer = File.AppendText(dosyaYolu))
                    {
                        writer.WriteLine(kayitEkle);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
              DepoView.Enabled = true;
              AddText.Visible=false; 
              Kaydet.Visible=false;
              KayitGuncelleme.Enabled = true;
              kapat3.Visible = false;
              Rapor.Enabled = true;
              MessageBox.Show("Kayıt Başarılı!");
        }
        private void Rapor_Click(object sender, EventArgs e)
        {
            raporList.Visible = true;
            Rapor.Enabled = false;
            kapat2.Visible = true;
            DepoView.Enabled = false;
            KayitGuncelleme.Enabled = false;
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Rapor.Enabled = true;
            raporList.Visible = false;
            kapat2.Visible = false;
            DepoView.Enabled = true;
            KayitGuncelleme.Enabled = true;
           
        }
        private void kapat3_Click(object sender, EventArgs e)
        {
            Kaydet.Visible = false;
            KayitGuncelleme.Enabled = true;
            kapat3.Visible = false;
            AddText.Visible = false;
            DepoView.Enabled = true;
            Rapor.Enabled = true;
        }
    }
}

