using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Services.DTOs
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }

        // Relacionamento simplificado
        public int? PlanoSaudeId { get; set; }

        // Opcional: usado apenas para saída
        public string PlanoSaudeNome { get; set; }
    }
}
