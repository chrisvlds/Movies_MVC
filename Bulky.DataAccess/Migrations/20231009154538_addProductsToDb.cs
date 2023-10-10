using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Director", "ListPrice", "Price", "Price100", "Price50", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Set in a future where a failing Earth puts humanity on the brink of extinction, it sees an intrepid team of NASA scientists, engineers and pilots attempt to find a new habitable planet, via interstellar travel.\r\n\r\nVery cool movie. ", "Christopher Nolan", 99.0, 90.0, 80.0, 85.0, "2014", "Interstellar" },
                    { 2, "An action-packed, epic space adventure, Marvel's \"Guardians of the Galaxy,\" expands the Marvel Cinematic Universe into the cosmos, where brash adventurer Peter Quill finds himself the object of an unrelenting bounty hunt after stealing a mysterious orb coveted by Ronan, a powerful villain with ambitions that threaten the entire universe. To evade the ever-persistent Ronan, Quill is forced into an uneasy truce with a quartet of disparate misfits--Rocket, a gun-toting raccoon; Groot, a tree-like humanoid; the deadly and enigmatic Gamora; and the revenge-driven Drax the Destroyer. But when Quill discovers the true power of the orb and the menace it poses to the cosmos, he must do his best to rally his ragtag rivals for a last, desperate stand--with the galaxy's fate in the balance.\r\n\r\nVery cool movie. ", "James Gunn", 40.0, 30.0, 20.0, 25.0, "2014", "Guardians of the Galaxy" },
                    { 3, "When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts. When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts.\r\n\r\nVery cool movie. ", "Denis Villeneuve", 55.0, 50.0, 35.0, 40.0, "2013", "Prisoners" },
                    { 4, "Set one year after The Last Jedi, The Rise of Skywalker follows Rey, Finn, and Poe Dameron as they lead the Resistance's final stand against Supreme Leader Kylo Ren and the First Order, who are aided by the return of the Galactic Emperor, Palpatine.\r\n\r\nVery cool movie. ", "J. J. Abrams", 70.0, 65.0, 55.0, 60.0, "2019", "Star Wars: The Rise of Skywalker" },
                    { 5, "MidSommar shows us a group of friends going on what seems like an idyllic trip to the Midsummer festival in a village in Northern Sweden. But that quickly turns into a harrowing display of Pagan rituals and ceremonies.\r\n\r\nVery cool movie. ", "Ari Aster", 30.0, 27.0, 20.0, 25.0, "2019", "Midsommar" },
                    { 6, "Aftersun is a 2022 coming-of-age drama film written and directed by Charlotte Wells in her feature directorial debut. Starring Paul Mescal, Frankie Corio, and Celia Rowlson-Hall, the film follows an 11-year-old Scottish girl on holiday with her father at a Turkish resort on the eve of his 31st birthday..\r\n\r\nVery cool movie. ", "Charlotte Wells", 25.0, 23.0, 20.0, 22.0, "2022", "Aftersun" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
