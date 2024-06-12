using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumasSatis
{
    public class Musteriler
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
    }

    public class Kumaslar
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public double MetreFiyat { get; set; }
        public double StokMiktari { get; set; }
        public string Birim { get; set; }
        public string Aciklama { get; set; }
    }

    public class Satislar
    {
        public Guid ID { get; set; }
        public Musteriler Musteri { get; set; }
        public Kumaslar Kumas { get; set; }
        public DateTime Tarih { get; set; }
        public double MetreFiyat { get; set; }
    }

    public class Odemeler
    {
        public Guid ID { get; set; }
        public Musteriler Musteri { get; set; }
        public DateTime Tarih { get; set; }
        public double OdemeTutari { get; set; }
        public string OdemeTuru { get; set; }
        public string Aciklama { get; set; }
    }

    public class Tedarikciler
    {
        public Guid ID { get; set; }
        public string SirketAd { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
    }
}
