﻿using JP_Desenvolvimento.Domain.Core.Models;
using System;

namespace JP_Desevolvimento.Domain.Models
{
    public class Cliente : Entity
    {
        public Cliente(Guid id, string nome, string email, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        // Empty constructor for EF
        protected Cliente() { }
        public string Nome { get; private set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
