using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteTeste.Models
{
    public class VendaViewModel
    {
        public int Id { get; set; }
        public int Id_modelo { get; set; }
        public int Id_cliente { get; set; }
        public int Quantidade { get; set; }
        public float Valor { get; set; }
    }
}
