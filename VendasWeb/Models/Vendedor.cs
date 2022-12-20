namespace VendasWeb.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double BaseSalario { get; set; }
        public int DepartamentoId { get; set; }
        public Departament Departamento { get; set; }


        public string Aniversario { get; set; }
        public string Salário { get; set; }



        public ICollection<RecordeVendedor> Vendas { get; set; } = new List<RecordeVendedor>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double baseSalario, Departament departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        //Metodo de adicionar uma venda na lista do vendedor.

        public void AddVenda(RecordeVendedor venda)
        {
            Vendas.Add(venda);
        }
        //Metodo de remover uma venda na lista do vendedor.

        public void RemoverVenda(RecordeVendedor venda)
        {
            Vendas.Remove(venda);
        }

        //Metodo de retornar o total de venda a partir da minha lista de vendas.

        public double TotalVenda(DateTime inicio, DateTime final)
        {
            return Vendas.Where(vendas => vendas.Data >= inicio && vendas.Data <= final).Sum(vendas => vendas.Quantia);
        }
    }
}
