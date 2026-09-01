using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain
{
    public enum TipoCirurgia
    {
        Tipo1,   // Emergência imediata
        Tipo2,   // Urgência (até 24h)
        Eletiva, // Programada
        Urgente  // Não pode esperar muito
    }
}
