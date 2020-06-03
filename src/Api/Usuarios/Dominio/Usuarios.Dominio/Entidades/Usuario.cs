using System;

namespace Usuarios.Dominio.Entidades
{
    public class Usuario
    {
        #region Propriedades
        public int Id { get; protected set ; }
        public string Nome { get; protected set; }
        public string Email { get; set; }
        public string Sobrenome { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public int Escolaridade { get; protected set; }
        #endregion

        #region Construtores

        public Usuario(int id, string nome, string sobrenome, DateTime dataNascimento, int escolaridade)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = DataNascimento;
            Escolaridade = escolaridade;
        }

        public Usuario()
        {

        }

        #endregion
    }
}
