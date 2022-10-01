using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {

        }

        public ChapterContext(DbContextOptions<ChapterContext> options): base(options)
        {

        }
        //Método a seguir para configurar o BANCO DE DADOS

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DENISE-SOUZA\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
                    //Se estivesse usando Nuvem aqui eu colocaria o Conection strip algo assim
                    //Cada provedor term sua sintaxe, trocou de banco tem que mudar essa linha
            }
        }
        //DbSet representa as entidades que serão utilizadas nas operações do Crud
        public DbSet <Livro> Livros { get; set; }
    }


}


