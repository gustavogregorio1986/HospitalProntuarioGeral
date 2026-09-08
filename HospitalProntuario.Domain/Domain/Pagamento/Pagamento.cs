using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProntuario.Domain.Domain;

namespace HospitalProntuario.Domain.Domain
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; }

        // Status do pagamento (Pendente, Confirmado, Cancelado)
        public StatusPagamento Status { get; set; }

        // Relacionamento
        public int PacienteId { get; set; }

        // Relacionamentos
        public Paciente Paciente { get; set; }
    }
}
