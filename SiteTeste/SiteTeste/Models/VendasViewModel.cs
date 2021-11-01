using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteTeste.Models
{
    public class VendasViewModel
    {
        public List<string> codProduto { get; set; }
        public List<string> nome_fornecedor { get; set; }
        public List<float> preco { get; set; }
        public List<int> quantidade { get; set; }
        public DateTime dtVenda { get; set;}

    }
}
