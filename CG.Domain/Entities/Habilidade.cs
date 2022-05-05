﻿using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class Habilidade : BaseDomain, IExibivel
    {
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
    }
}