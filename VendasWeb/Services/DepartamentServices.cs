using VendasWeb.Data;
using VendasWeb.Models;
namespace VendasWeb.Services
{
    public class DepartamentServices
    {
        private readonly T_DEPARTAMENTODadContext _context;

        public DepartamentServices(T_DEPARTAMENTODadContext context)
        {
            _context = context;
        }

        //Criação da lista para selecionar o tipo de Departamento na hora do cadastro de um Vendedor.

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

     

    }
}
