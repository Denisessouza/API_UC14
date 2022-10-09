using ExoApi.Contexts;
using ExoApi.Models;


namespace ExoApi.Repositories
{
        public class ProjetoRepository
        {
            private readonly dbExoApi_Context _context;

            public ProjetoRepository(dbExoApi_Context context)
        {

            _context = context;

        }

        public List <Projeto> Listar ()
        {

            return _context.Projeto.ToList ();
        }
    }
}
