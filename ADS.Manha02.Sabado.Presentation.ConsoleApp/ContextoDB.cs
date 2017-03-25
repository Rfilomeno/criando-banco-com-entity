using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Manha02.Sabado.Presentation.ConsoleApp
{
    public class ContextoDB : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}
