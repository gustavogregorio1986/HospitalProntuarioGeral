using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public string CPF{ get; set; }

        public PlanoSaude? PlanoSaude { get; set; } // navegação

        public int? PlanoSaudeId { get; set; }   // chave estrangeira

        public int PacienteId { get; set; }

        // Relacionamentos
        public PlanoSaude? Plano { get; set; }
        [JsonIgnore]
        public ICollection<Agendamento> Agendamentos { get; set; }
        [JsonIgnore]
        public List<Internacao> Internacoes { get; set; }
        [JsonIgnore]
        public List<Pagamento> Pagamentos { get; set; }
        [JsonIgnore]
        public List<Cirurgia> Cirurgias { get; set; }
    }
}
