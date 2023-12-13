using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication04.Models.Entities
{
    public class TipoUsuario
    {  
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}