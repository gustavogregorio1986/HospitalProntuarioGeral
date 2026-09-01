using System;

namespace HospitalProntuario.Domain.Domain
{
    public class Agendamento
    {
        public int Id { get; set; }

        // Nome ajustado para coincidir com o mapeamento
        public DateTime Data { get; set; }

        public TipoAgendamento Tipo { get; set; }

        // Relacionamentos
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
}
