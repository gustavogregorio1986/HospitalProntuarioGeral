using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; }

        // Relacionamento
        public int PacienteId { get; set; }

        // Relacionamentos
        public Paciente Paciente { get; set; }
    }
}
