using System;
using System.ComponentModel.DataAnnotations;

namespace Usuarios.Aplicacao.Modelo
{
    public class UsuarioModelo
    {
        [Key]
        public int Id { get;  set; }

        [Required(ErrorMessage = "Por favor preencha o campo Nome")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Nome { get;  set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [EmailAddress]
        [DisplayName("E-mail")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor preencha a data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get;  set; }

        public int Escolaridade { get;  set; }
    }
}
