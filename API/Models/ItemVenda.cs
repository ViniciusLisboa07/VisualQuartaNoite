using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ItemVenda
    {
        public ItemVenda () => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}