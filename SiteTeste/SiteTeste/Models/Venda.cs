﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteTeste.Models
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int id_modelo { get; set; }
        public int id_cliente { get; set; }
        public int quantidade { get; set; }
        public DateTime data_vendas { get; set; }
    }
}
