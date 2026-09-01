using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Services.DTOs
{
    public class InternacaoDTO
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Quarto { get; set; }

        // Relacionamento simplificado
        public int PacienteId { get; set; }

        // Opcional: usado apenas para saída (não obrigatório)
        public string PacienteNome { get; set; }
    }
}
