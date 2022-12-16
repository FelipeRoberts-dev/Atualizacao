using VendasWeb.Models.Enums;

namespace VendasWeb.Models
{
    public class RecordeVendedor
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusVendedor Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RecordeVendedor()
        {

        }

        public RecordeVendedor(int id, DateTime data, double quantia, StatusVendedor status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
