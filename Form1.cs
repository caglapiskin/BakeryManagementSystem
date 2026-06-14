using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirinMatikPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // --- SİHİRLİ MANUEL BAĞLANTI BURASI ---
            // Tasarımcı bağlayamadıysa, biz kodla zorla kelepçeliyoruz!
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // --------------------------------------
        }

        // Program ilk açıldığında çalışacak olan yer
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        // 1. BUTON: "Ürünü Fırına Kaydet" Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var yeniUrun = new Urun
                    {
                        UrunAdi = txtUrunAdi.Text,
                        SatisFiyati = Convert.ToDecimal(txtFiy.Text),
                        Barkod = txtBarkod.Text
                    };

                    db.Urunler.Add(yeniUrun);
                    db.SaveChanges();
                }

                MessageBox.Show($"{txtUrunAdi.Text} başarıyla fırın sistemine kaydedildi!");
                Temizle();
                UrunleriListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen fiyat alanına sadece sayısal bir değer giriniz!");
            }
        }

        // 2. BUTON: "Seçili Ürünü Sil" Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunId"].Value);

                using (var db = new AppDbContext())
                {
                    var silinecekUrun = db.Urunler.Find(secilenId);
                    if (silinecekUrun != null)
                    {
                        db.Urunler.Remove(silinecekUrun);
                        db.SaveChanges();
                        MessageBox.Show("Ürün başarıyla silindi!");
                        Temizle();
                        UrunleriListele();
                    }
                }
            }
        }

        // 3. BUTON: "Fiyatı Güncelle" Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunId"].Value);

                using (var db = new AppDbContext())
                {
                    var guncellenecekUrun = db.Urunler.Find(secilenId);
                    if (guncellenecekUrun != null)
                    {
                        guncellenecekUrun.UrunAdi = txtUrunAdi.Text;
                        guncellenecekUrun.SatisFiyati = Convert.ToDecimal(txtFiy.Text);
                        guncellenecekUrun.Barkod = txtBarkod.Text;

                        db.SaveChanges();
                        MessageBox.Show("Ürün bilgileri güncellendi!");
                        Temizle();
                        UrunleriListele();
                    }
                }
            }
        }

        // TABLO: Satıra tıklandığında kutuları dolduran yer
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value?.ToString();
                txtFiy.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value?.ToString();
                txtBarkod.Text = dataGridView1.CurrentRow.Cells["Barkod"].Value?.ToString();
            }
        }

        // Veritabanındaki ürünleri çekip DataGridView'e dolduran yardımcı metot
        private void UrunleriListele()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    dataGridView1.DataSource = db.Urunler.ToList();
                }
            }
            catch (Exception) { }
        }

        // Kutuları temizleme fonksiyonu
        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtFiy.Clear();
            txtBarkod.Clear();
        }
    }
}