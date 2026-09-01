using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class Internacao
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Quarto { get; set; }

        public int PacienteId { get; set; }

        // Relacionamentos
        [JsonIgnore]
        public Paciente Paciente { get; set; }
    }
}
