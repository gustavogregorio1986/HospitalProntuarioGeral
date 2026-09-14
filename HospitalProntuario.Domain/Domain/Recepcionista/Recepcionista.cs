using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Recepcionista
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Relacionamento: Uma recepcionista pode fazer vários agendamentos
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }

}
