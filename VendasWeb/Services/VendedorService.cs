using VendasWeb.Data;
using VendasWeb.Models;
namespace VendasWeb.Services
{
    public class VendedorService
    {
        //Injenção de depedencia da minha conexão.
        private readonly T_DEPARTAMENTODadContext _context;

        public VendedorService(T_DEPARTAMENTODadContext context)
        {
            _context = context;
        }
        //Criação da minha lista de vendedores
        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
