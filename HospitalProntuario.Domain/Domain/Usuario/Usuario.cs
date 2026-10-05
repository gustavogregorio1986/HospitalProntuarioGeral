using HospitalProntuario.Domain.Domain.Usuario.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain.Usuario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public PerfilUsuario Perfil { get; set; }
        public bool Ativo { get; private set; }
        public int? MedicoId { get; set; }
        public int? RecepcionistaId { get;  set; }
        public DateTime DataCriacao { get; private set; }

    }
}
