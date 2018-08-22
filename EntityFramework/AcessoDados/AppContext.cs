using EntityFramework.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class AppContext : DbContext 
    {
        // Install-Package Pomelo.EntityFrameworkCore.MySql -> instalação do MySql no Nuget

        //Update-Database para conectar ao Mysql no Nuget

        //Add-Migration EntityFramework habilita recurso de mapeamento no banco de dados

        private DbSet<Produto> produtos;
        private DbSet<Pedido> pedidos;
        private DbSet<ItemPedido> itens;

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public DbSet<ItemPedido> Itens { get => itens; set => itens = value; }
        public DbSet<Produto> Produtos { get => produtos; set => produtos = value; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
