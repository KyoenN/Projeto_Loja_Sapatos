﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteTeste.Models
{
    public class VendasViewModel
    {
        public string codProduto { get; set; }
        public string nome_fornecedor { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }

    }
}