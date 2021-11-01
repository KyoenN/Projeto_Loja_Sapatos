using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteTeste.Models
{
    public class VendasViewModel
    {
        public int id { get; set; }
        public int id_modelo { get; set; }
        public int id_cliente { get; set; }
        public int quantidade { get; set; }
        public DateTime data_vendas { get; set; }
    }
}
