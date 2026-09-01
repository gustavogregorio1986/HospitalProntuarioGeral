using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Cirurgia
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoCirurgia Tipo { get; set; }

        // Relacionamentos
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
    }
}
