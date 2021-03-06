﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Main.Domain.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string EnderecoEmail { get; set; }
        public Boolean Inativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}