using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório!")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

    }
}
