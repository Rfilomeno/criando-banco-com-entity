using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Manha02.Sabado.Presentation.ConsoleApp
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
