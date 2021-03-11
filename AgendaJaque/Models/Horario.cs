using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaJaque.Models
{
    public class Horario : Entity
    {
        public Guid PacienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data { get; set; }

        public Paciente Paciente { get; set; }
    }
}
