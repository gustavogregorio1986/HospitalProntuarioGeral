namespace HospitalProntuario.Models
{
    public class RecepcionistaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}