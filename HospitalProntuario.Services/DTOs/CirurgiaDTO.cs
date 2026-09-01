using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HospitalProntuario.Services.DTOs
{
        public class Internacao
        {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoCirurgia Tipo { get; set; }

        // Relacionamentos simplificados
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }

        // Campos opcionais para saída (não obrigatórios)
        public string PacienteNome { get; set; }
        public string MedicoNome { get; set; }
    }

}
