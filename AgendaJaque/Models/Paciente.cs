using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaJaque.Models
{
    public class Paciente : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        public string Apelido { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Idade { get; set; }

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Celular { get; set; }

        public string Email { get; set; }

        [Display(Name = "Celular de um familiar")]
        public string  CelularFamiliar { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Valor Mensal")]
        public decimal ValorMensal { get; set; }

        public Endereco Endereco { get; set; }

        public IEnumerable<Horario> Horarios { get; set; }
    }
}
