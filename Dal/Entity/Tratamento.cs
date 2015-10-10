using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Tratamento
    {
            public int      IdTratamento { get; set; }
            public string   Descricao { get; set; }
            public int      IdConsulta { get; set; }
            public int      IdMedicacao { get; set; }
                  

    }
}


