using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWeb.Models;

namespace VendasWeb.Data
{
    public class T_DEPARTAMENTODadContext : DbContext
    {
        public T_DEPARTAMENTODadContext (DbContextOptions<T_DEPARTAMENTODadContext> options)
            : base(options)
        {
        }

        public DbSet<VendasWeb.Models.Departament> Departament { get; set; } = default!;
    }
}
