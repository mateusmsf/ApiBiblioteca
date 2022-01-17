namespace biblioteca.WEBAPI.Models
{
    public class Livro
    {
        public Livro(int id, string nome, string tema, int qtd_pg, string autor, string status)
        {
            this.id = id;
            this.nome = nome;
            this.tema = tema;
            this.qtd_pg = qtd_pg;
            this.autor = autor;
            this.status = status;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string tema { get; set; }
        public int qtd_pg { get; set; }
        public string autor { get; set; }
        public string status { get; set; }
    }
}