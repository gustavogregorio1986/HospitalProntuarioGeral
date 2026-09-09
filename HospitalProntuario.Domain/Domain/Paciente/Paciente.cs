using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HospitalProntuario.Domain.Domain
{
    
    public class Paciente
    {
        [Key] // Define como Chave Primária
        public int Id { get; set; }

        [Required] // Define que o campo não pode ser nulo no banco
        [MaxLength(150)] // Define limite de caracteres
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        
        public string CPF { get; set; }

        // --- RELACIONAMENTO: Plano de Saúde ---
        // FK (Foreign Key)
        public int PlanoSaudeId { get; set; }

        
        public PlanoSaude PlanoSaude { get; set; }

        // --- RELACIONAMENTOS: One-to-Many ---
        [JsonIgnore]
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();

        [JsonIgnore]
        public ICollection<Internacao> Internacoes { get; set; } = new List<Internacao>();

        [JsonIgnore]
        public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public int CirurgiaId { get; set; }
        public ICollection<Cirurgia> Cirurgias { get; set; } = new List<Cirurgia>();
    }
}
