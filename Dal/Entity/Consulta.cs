using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Consulta
    {
        public int IdConsulta { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }    
        public Double ValorPago { get; set; }
        public int IdFuncionario { get; set; }
        public int IdMedicio { get; set; }
        public int IdPaciente { get; set; }
        public string Receita { get; set; }

        
    }
}
