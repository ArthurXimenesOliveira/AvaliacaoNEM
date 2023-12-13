using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication04.Models.Entities
{
    public class Utensilio
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public int FkIdTipoUtensilio { get; set; }
        public TipoUtensilio? TipoUtensilio { get; set; }
    }
}