using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiproje.Entities
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }

        public string KategoriAd { get; set; }

        public string KategoriAciklama { get; set; }

        public int UrunID { get; set; }  //Bir kategorinin birden fazla ürünü olabilir
        [ForeignKey("UrunID")]
        public Urunler Urunler { get; set; }

    }
}
