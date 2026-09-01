using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public class PlanoSaude
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RegistroANS { get; set; }


        // Relacionamentos
        [JsonIgnore]
        public List<Paciente>? Pacientes { get; set; }
    }
}
