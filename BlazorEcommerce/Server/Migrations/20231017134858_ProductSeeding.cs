using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "ProductPrice", "Title" },
                values: new object[,]
                {
                    { 1, "Neste livro você encontra 1.001 questões – 900 de provas passadas e 101 novas – para praticar e testar seus conhecimentos.", "https://m.media-amazon.com/images/I/71LwLOXe6aL._SY466_.jpg", 75.98m, "1001 Questões para Fazer Antes de Passar no ENEM Espiral" },
                    { 2, "Passar em uma boa universidade é o sonho de muitos, mas o vestibular tende a ser um momento cheio de tensão e nervosismo para os alunos.", "https://m.media-amazon.com/images/I/81cbf9eKBBL._SY466_.jpg", 34.98m, "Redação infalível: E outras dicas para você arrasar nas provas" },
                    { 3, "Neste livro, inédito no Brasil, você vai descobrir, após 75 anos de segredo, por meio dessa entrevista exclusiva que Napoleon Hill fez, quebrando o código secreto da mente do Diabo.", "https://m.media-amazon.com/images/I/819ERrDHRcL._SY466_.jpg", 25.90m, "Mais esperto que o Diabo: O mistério revelado da liberdade e do sucesso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
