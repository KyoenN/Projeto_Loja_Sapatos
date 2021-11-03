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
        public int Id { get; set; }
        public int Id_Fornecedor { get; set; }
        public string Nome { get; set; }
        public string CodReferencia { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }
    }
}
