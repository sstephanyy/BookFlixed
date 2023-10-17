namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                    {
                        Id = 1,
                        Title = "1001 Questões para Fazer Antes de Passar no ENEM Espiral",
                        Description = "Neste livro você encontra 1.001 questões – 900 de provas passadas e 101 novas – para praticar e testar seus conhecimentos.",
                        ImageUrl = "https://m.media-amazon.com/images/I/71LwLOXe6aL._SY466_.jpg",
                        ProductPrice = 75.98M
                    },

                new Product
                    {
                        Id = 2,
                        Title = "Redação infalível: E outras dicas para você arrasar nas provas",
                        Description = "Passar em uma boa universidade é o sonho de muitos, mas o vestibular tende a ser um momento cheio de tensão e nervosismo para os alunos.",
                        ImageUrl = "https://m.media-amazon.com/images/I/81cbf9eKBBL._SY466_.jpg",
                        ProductPrice = 34.98M
                    },

                 new Product
                     {
                         Id = 3,
                         Title = "Mais esperto que o Diabo: O mistério revelado da liberdade e do sucesso",
                         Description = "Neste livro, inédito no Brasil, você vai descobrir, após 75 anos de segredo, por meio dessa entrevista exclusiva que Napoleon Hill fez, quebrando o código secreto da mente do Diabo.",
                         ImageUrl = "https://m.media-amazon.com/images/I/819ERrDHRcL._SY466_.jpg",
                         ProductPrice = 25.90M
                     }
           );
        }


        public DbSet<Product> Products { get; set; } //DbSet -> add a table iin the  databse 

    }
}

