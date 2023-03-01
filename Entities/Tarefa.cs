using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_at_cs_api_aula1.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Tarefa(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}