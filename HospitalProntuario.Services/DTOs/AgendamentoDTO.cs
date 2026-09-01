using HospitalProntuario.Domain.Domain;
using System;

namespace HospitalProntuario.Application.DTOs
{
    public class AgendamentoDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoAgendamento Tipo { get; set; }

        // Apenas os IDs para relacionamentos
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }

        // Campos opcionais para saída (se quiser mostrar nome do paciente/médico)
        public string PacienteNome { get; set; }
        public string MedicoNome { get; set; }
    }
}
