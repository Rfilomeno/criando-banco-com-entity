using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Manha02.Sabado.Presentation.ConsoleApp
{
    class Program
    {

        static ContextoDB contexto = new ContextoDB();

        static void Main(string[] args)
        {
            var aluno = new Aluno()
            {
                AlunoId = Guid.NewGuid(),
                Nome = "Rodrigo Filomeno",
                DataDeNascimento = new DateTime(1980, 10, 12),
                Ativo = true
            };

            contexto.Alunos.Add(aluno);
            Console.WriteLine("Criando banco!");
            contexto.SaveChanges();

            var a = contexto.Alunos.Where(p => p.Nome == "Rodrigo Filomeno").FirstOrDefault();

            Console.WriteLine(a.DataDeNascimento.ToString());
            Console.ReadKey();
        }
    }
}
