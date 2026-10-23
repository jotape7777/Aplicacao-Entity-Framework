using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.entities
{
    public class aplicação_financeira
    {
        private string v1;
        private int v2;
        private bool v3;

        public int Id { get; set; }

        public string? Nome { get; set; } = "";
        
        public decimal Valor { get; set; }
        public bool isFinalizado { get; set; }

        public aplicação_financeira()
        {
            Id = 0;
            Nome = "";
            Valor = 0;
            isFinalizado = true;
        }

        public aplicação_financeira(int id, string nome, decimal valor, bool isFinalizado)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            this.isFinalizado = isFinalizado;
        }

        public aplicação_financeira(string v1, int v2, bool v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
