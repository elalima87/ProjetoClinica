using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string NomePac { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public int NumeroTel { get; set; }
        public string TipoTel { get; set; }

        public Endereco Endereco { get; set; }
        

        

    }
}
