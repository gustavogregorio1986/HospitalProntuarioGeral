using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }

        // Relacionamentos
        [JsonIgnore]
        public List<Agendamento>? Agendamentos { get; set; }
        [JsonIgnore]
        public List<Cirurgia>? Cirurgias { get; set; }
    }
}
