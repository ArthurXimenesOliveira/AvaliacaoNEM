using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication04.Models.Entities
{
    public class TipoUtensilio
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Utensilio> Utensilios { get; set; }
    }
}