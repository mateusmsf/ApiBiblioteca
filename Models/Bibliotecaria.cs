using System;

namespace biblioteca.WEBAPI.Models
{
    public class Bibliotecaria
    {
        public Bibliotecaria(int id, string nome, int idade, DateTime dt_admissao)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.dt_admissao = dt_admissao;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public DateTime dt_admissao { get; set; }
    }
}