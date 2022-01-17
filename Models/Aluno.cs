namespace biblioteca.WEBAPI.Models
{
    public class Aluno
    {
        public Aluno(int id, string nome, string curso, int periodo, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.curso = curso;
            this.periodo = periodo;
            this.idade = idade;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string curso { get; set; }
        public int periodo { get; set; }
        public int idade { get; set; }
    }
}