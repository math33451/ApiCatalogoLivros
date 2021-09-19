using System;

namespace ApiCatalogoLivros.Exceptions
{
    public class LivroJaCadastradoException : Exception
    {
        public LivroJaCadastradoException()
            : base("Este livro já está cadastrado")
        { }
    }
}