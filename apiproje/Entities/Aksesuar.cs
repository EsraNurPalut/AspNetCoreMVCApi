using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiproje.Entities
{
    public class Aksesuar
    {
        [Key]
        public int AksesuarID { get; set; }

        public string AksesuarAd { get; set; }

        public string AksesuarRenk { get; set; }


    }
}
