using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Services.DTOs
{
    public class MedicoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }

        // Campos opcionais para saída (não obrigatórios)
        public int TotalAgendamentos { get; set; }
        public int TotalCirurgias { get; set; }
    }
}
