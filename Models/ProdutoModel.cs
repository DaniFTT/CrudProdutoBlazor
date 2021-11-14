using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProdutoBlazor.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int QuantidadeVendida { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeAlteracao { get; set; }
    }
}
