namespace VendasWeb.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departament> Departaments { get; set; }

        public string Departamentos { get; set; }
    }
}
