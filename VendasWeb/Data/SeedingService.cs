using VendasWeb.Models;
using VendasWeb.Models.Enums;
namespace VendasWeb.Data
{
    public class SeedingService
    {
        private T_DEPARTAMENTODadContext _context;
        public SeedingService(T_DEPARTAMENTODadContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Vendedor.Any() || _context.RecordeVendedors.Any())
            {
                return; //Verificar se o banco de dados já foi Populado
            }


            //Populando minha base de dados e instanciando cada objeto e fazendo sua relação.

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronicos");
            Departament d3 = new Departament(3, "Moda");
            Departament d4 = new Departament(4, "Livros");

            Vendedor s1 = new Vendedor(1, "Marcia Ferreira", "Marcia@gmail.com", new DateTime(1998, 4, 21), 1200.0, d1);
            Vendedor s2 = new Vendedor(2, "Ana Guedes", "Ana@gmail.com", new DateTime(1979, 12, 31), 2800.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Santos", "Alex@gmail.com", new DateTime(1998, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Fernando Almeida", "Fernando@gmail.com", new DateTime(1993, 11, 30), 3200.0, d4);
            Vendedor s5 = new Vendedor(5, "Leticia Silva", "Leticia@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);
            Vendedor s6 = new Vendedor(6, "Ronaldo Ramos", "Ronaldo@gmail.com", new DateTime(200, 1, 9), 4000.0, d3);

            RecordeVendedor r1 = new RecordeVendedor(1, new DateTime(2018, 09, 25), 11000.0, StatusVendedor.Faturado, s1);
            RecordeVendedor r2 = new RecordeVendedor(2, new DateTime(2018, 09, 4), 7000.0, StatusVendedor.Faturado, s5);
            RecordeVendedor r3 = new RecordeVendedor(3, new DateTime(2018, 09, 13), 4000.0, StatusVendedor.Cancelado, s4);
            RecordeVendedor r4 = new RecordeVendedor(4, new DateTime(2018, 09, 1), 8000.0, StatusVendedor.Faturado, s1);
            RecordeVendedor r5 = new RecordeVendedor(5, new DateTime(2018, 09, 21), 3000.0, StatusVendedor.Faturado, s3);
            RecordeVendedor r6 = new RecordeVendedor(6, new DateTime(2018, 09, 15), 2000.0, StatusVendedor.Faturado, s1);
            RecordeVendedor r7 = new RecordeVendedor(7, new DateTime(2018, 09, 28), 13000.0, StatusVendedor.Faturado, s2);
            RecordeVendedor r8 = new RecordeVendedor(8, new DateTime(2018, 09, 11), 4000.0, StatusVendedor.Faturado, s4);
            RecordeVendedor r9 = new RecordeVendedor(9, new DateTime(2018, 09, 14), 11000.0, StatusVendedor.Pendente, s6);
            RecordeVendedor r10 = new RecordeVendedor(10, new DateTime(2018, 09, 7), 9000.0, StatusVendedor.Faturado, s6);
            RecordeVendedor r11 = new RecordeVendedor(11, new DateTime(2018, 09, 13), 6000.0, StatusVendedor.Faturado, s2);
            RecordeVendedor r12 = new RecordeVendedor(12, new DateTime(2018, 09, 25), 7000.0, StatusVendedor.Pendente, s3);
            RecordeVendedor r13 = new RecordeVendedor(13, new DateTime(2018, 09, 29), 10000.0, StatusVendedor.Faturado, s4);
            RecordeVendedor r14 = new RecordeVendedor(14, new DateTime(2018, 09, 4), 3000.0, StatusVendedor.Faturado, s5);
            RecordeVendedor r15 = new RecordeVendedor(15, new DateTime(2018, 09, 12), 4000.0, StatusVendedor.Faturado, s1);
            RecordeVendedor r16 = new RecordeVendedor(16, new DateTime(2018, 10, 5), 2000.0, StatusVendedor.Faturado, s4);
            RecordeVendedor r17 = new RecordeVendedor(17, new DateTime(2018, 10, 1), 12000.0, StatusVendedor.Faturado, s1);
            RecordeVendedor r18 = new RecordeVendedor(18, new DateTime(2018, 10, 24), 6000.0, StatusVendedor.Faturado, s3);
            RecordeVendedor r19 = new RecordeVendedor(19, new DateTime(2018, 10, 22), 8000.0, StatusVendedor.Faturado, s5);
            RecordeVendedor r20 = new RecordeVendedor(20, new DateTime(2018, 10, 15), 8000.0, StatusVendedor.Faturado, s6);
            RecordeVendedor r21 = new RecordeVendedor(21, new DateTime(2018, 10, 17), 9000.0, StatusVendedor.Faturado, s2);
            RecordeVendedor r22 = new RecordeVendedor(22, new DateTime(2018, 10, 24), 4000.0, StatusVendedor.Faturado, s4);
            RecordeVendedor r23 = new RecordeVendedor(23, new DateTime(2018, 10, 19), 11000.0, StatusVendedor.Cancelado, s2);
            RecordeVendedor r24 = new RecordeVendedor(24, new DateTime(2018, 10, 12), 8000.0, StatusVendedor.Faturado, s5);
            RecordeVendedor r25 = new RecordeVendedor(25, new DateTime(2018, 10, 31), 7000.0, StatusVendedor.Faturado, s3);
            RecordeVendedor r26 = new RecordeVendedor(26, new DateTime(2018, 10, 6), 5000.0, StatusVendedor.Faturado, s4);
            RecordeVendedor r27 = new RecordeVendedor(27, new DateTime(2018, 10, 13), 9000.0, StatusVendedor.Pendente, s1);
            RecordeVendedor r28 = new RecordeVendedor(28, new DateTime(2018, 10, 7), 4000.0, StatusVendedor.Faturado, s3);
            RecordeVendedor r29 = new RecordeVendedor(29, new DateTime(2018, 10, 23), 12000.0, StatusVendedor.Faturado, s5);
            RecordeVendedor r30 = new RecordeVendedor(30, new DateTime(2018, 10, 12), 5000.0, StatusVendedor.Faturado, s2);


            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);

            _context.RecordeVendedors.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30

                );

            _context.SaveChanges();
        }
    }
    
}
