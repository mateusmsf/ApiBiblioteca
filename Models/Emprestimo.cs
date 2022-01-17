using System;

namespace biblioteca.WEBAPI.Models
{
    public class Emprestimo
    {
        public Emprestimo(int id, DateTime data, DateTime devolucao, int alunoId,  int bibliotecaId)
        {
            this.id = id;
            this.data = data;
            this.devolucao = devolucao;
            this.alunoId = alunoId;
            this.bibliotecaId = bibliotecaId;

        }
        public int id { get; set; }
        public DateTime data { get; set; }
        public DateTime devolucao { get; set; }
        public Aluno aluno { get; set; }
        public int alunoId { get; set; }
        public Bibliotecaria bibliotecaria { get; set; }
        public int bibliotecaId { get; set; }

    }
}