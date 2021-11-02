using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteTeste.Models
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_modelo { get; set; }
        public int Id_cliente { get; set; }
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
    }
}
