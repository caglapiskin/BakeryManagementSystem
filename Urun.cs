using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; // Veritabanı kuralları için bu kütüphane şart

namespace FirinMatikPro
{
    public class Urun
    {
        [Key] // Bu alanın otomatik artan birincil anahtar (ID) olduğunu belirtir
        public int UrunId { get; set; }

        [Required] // Ürün adının boş geçilemeyeceğini belirtir
        public string UrunAdi { get; set; }

        public string Barkod { get; set; }

        public decimal SatisFiyati { get; set; }
    }
}