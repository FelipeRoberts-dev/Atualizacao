
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWeb.Models;

public class Departament
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();


    public Departament()
    {

    }

    public Departament(int id, string nome)
    {
        Id = id;
        Name = nome;
    }
    
    //Metodo de Adicionar um vendedor

    public void  AddVendedor(Vendedor vendedor)
    {
        Vendedores.Add(vendedor);
    }

    //Metodo de retornar o total de vendas de um vendedor de tal departamento
    public double TotalVendas(DateTime inicio, DateTime fim)
    {
        return Vendedores.Sum(vendedor => vendedor.TotalVenda(inicio, fim));
    }
}
