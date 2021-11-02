using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteTeste.Models
{
    public class ClienteViewModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string endereço { get; set; }
        public string sexo { get; set; }
    }
}
