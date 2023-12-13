using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication04.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int FkIdTipoUsuario { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }

        

      

    }
}