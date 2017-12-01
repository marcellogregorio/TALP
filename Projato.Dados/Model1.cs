namespace Projato.Dados
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.DescricaoCategoria)
                .IsUnicode(false);



            modelBuilder.Entity<Login>()
                .Property(e => e.EmailLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.SenhaLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.IdSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.NomeLogin)
                .IsUnicode(false);

            //modelBuilder.Entity<Login>()
            //    .HasMany(e => e.Perfil_Acesso)
            //    .WithMany(e => e.Login)
            //    .Map(m => m.ToTable("Login_Perfil_Acesso").MapLeftKey("LoginIdLogin").MapRightKey("Perfil_AcessoIdPerfilAcesso"));

            //modelBuilder.Entity<Perfil_Acesso>()
            //    .Property(e => e.DescricaoAcesso)
            //    .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.NomeProduto)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.DescricaoProduto)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.IndicadorVitrine)
                .IsUnicode(false);




        }
    }
}
