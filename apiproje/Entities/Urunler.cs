using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiproje.Entities
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }

        public string UrunAd { get; set; }

        public string UrunAciklama { get; set; }

        public int UrunYas { get; set; }

        public string UrunBeden { get; set; }
    }
}
