using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Medico
    {
        public int IdMedico{ get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Descricao { get; set; }
    }
}
