using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Venda
    {
        public Venda () => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}