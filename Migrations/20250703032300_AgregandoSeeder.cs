using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIpeliculas.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 10, "Accion" },
                    { 20, "Aventura" },
                    { 30, "Comedia" },
                    { 40, "Drama" },
                    { 50, "Fantasia" },
                    { 60, "Ciencia Ficcion" },
                    { 70, "Terror" },
                    { 80, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duracion", "Estreno", "GeneroId", "Rating", "Titulo" },
                values: new object[,]
                {
                    { 1, "En un futuro postapocalíptico, Max se une a una misteriosa mujer para huir de un tirano.", "George Miller", 120, 2015, 10, 0.0, "Mad Max: Fury Road" },
                    { 2, "El arqueólogo Indiana Jones busca el Arca de la Alianza antes que los nazis.", "Steven Spielberg", 130, 1981, 20, 8.4000000000000004, "Indiana Jones y los cazadores del arca perdida" },
                    { 3, "Dos amigos intentan disfrutar su última fiesta antes de graduarse.", "Greg Mottola", 100, 2007, 30, 7.5999999999999996, "Superbad" },
                    { 4, "La historia de la familia mafiosa Corleone.", "Francis Ford Coppola", 180, 1972, 40, 9.1999999999999993, "El Padrino" },
                    { 5, "Un hobbit debe destruir un anillo para salvar la Tierra Media.", "Peter Jackson", 187, 2001, 50, 8.8000000000000007, "El Señor de los Anillos: La Comunidad del Anillo" },
                    { 6, "Un grupo de astronautas viaja a través de un agujero de gusano en busca de un nuevo hogar para la humanidad.", "Christopher Nolan", 180, 2014, 60, 8.5999999999999996, "Interestelar" },
                    { 7, "Investigadores paranormales ayudan a una familia aterrorizada por una presencia oscura.", "James Wan", 120, 2013, 70, 7.5, "El Conjuro" },
                    { 8, "Una historia de amor a bordo del trágico Titanic.", "James Cameron", 160, 1997, 80, 7.7999999999999998, "Titanic" },
                    { 9, "Un grupo de inadaptados se une para salvar la galaxia.", "James Gunn", 140, 2014, 10, 8.0, "Guardianes de la Galaxia" },
                    { 10, "Un pianista y una actriz persiguen sus sueños en Los Ángeles.", "Damien Chazelle", 120, 2016, 40, 8.0, "La La Land" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 80);
        }
    }
}
