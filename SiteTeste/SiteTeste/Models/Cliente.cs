using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteTeste.Models
{
    public class Cliente
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string endereço { get; set; }
        public string sexo { get; set; }
    }
}
