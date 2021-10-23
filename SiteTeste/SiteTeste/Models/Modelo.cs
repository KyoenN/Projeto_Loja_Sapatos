using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteTeste.Models
{
    public class Modelo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int id_fornecedor { get; set; }
        public string nome { get; set; }
        public string codReferencia { get; set; }
        public string cor { get; set; }
        public int tamanho { get; set; }
    }
}
