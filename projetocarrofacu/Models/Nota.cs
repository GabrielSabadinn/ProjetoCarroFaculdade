using System;
using System.Collections.Generic;

namespace projetocarrofacu.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public decimal ValorVenda { get; set; }
        public Cliente Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public Carro Carro { get; set; }
    }
}
