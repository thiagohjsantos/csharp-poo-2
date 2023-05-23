namespace DesafioLivro
{
    public class Livro
    {
        public string? Titulo { get; private set; }
        public string? Autor { get; set; }
        public string? Isbn { get; private set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public string? PaisPublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
        }
    }
}
