using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Services.DTOs
{
    public class PagamentoDTO
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; }

        // Relacionamento simplificado
        public int PacienteId { get; set; }

        // Opcional: usado apenas para saída
        public string PacienteNome { get; set; }
    }
}
