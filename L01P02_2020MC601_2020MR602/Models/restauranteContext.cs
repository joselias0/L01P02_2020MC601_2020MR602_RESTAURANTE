using Microsoft.EntityFrameworkCore;
using L01P02_2020MC601_2020MR602.Models;

namespace L01P02_2020MC601_2020MR602.Models
{
    public class restauranteContext:DbContext
    {
        public restauranteContext(DbContextOptions<restauranteContext> options): base(options)
        {

        }
        public DbSet<pedidos> pedidos { get; set;}
        public DbSet<platos> platos { get; set; }
        public DbSet<L01P02_2020MC601_2020MR602.Models.clientes>? clientes { get; set; }
        public DbSet<L01P02_2020MC601_2020MR602.Models.motoristas>? motoristas { get; set; }


    }
}
