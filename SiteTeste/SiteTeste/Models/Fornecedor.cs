using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteTeste.Models
{
    public class Fornecedor
    {
        //o id incrementa automaticamente e o "identity" além disso identifica o campo como PK (data annotation)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
    }
}
