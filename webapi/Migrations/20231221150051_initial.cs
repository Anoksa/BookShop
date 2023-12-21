using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Детективы" },
                    { 2, "Романы" },
                    { 3, "Приключения" },
                    { 4, "Романтика" },
                    { 5, "Юмор" },
                    { 6, "Ужасы" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Лоран Гунель", 2, "Книга \"Бог всегда путешествует инкогнито\" Лорана Гунеля, входящего в пятерку самых популярных беллетристов Франции, стала всемирным бестселлером, несколько лет возглавляла топ-листы продаж во Франции и была переведена на множество языков.Представьте себе: вы на краю пропасти. И в этот судьбоносный момент некий человек спасает вашу жизнь. Взамен вы даете ему обязательство следовать всем его указаниям. Это должно изменить вашу жизнь, сделав ее более радостной и счастливой. Это больше, чем роман, это размышление о себе, которое должно побудить вас взять судьбу в собственные руки.", "https://s2-goods.ozstatic.by/2000/592/756/10/10756592_0.jpg", 17.0, "Бог всегда путешествует инкогнито" },
                    { 2, "Мосян Тунсю", 4, "В незапамятные времена Се Лянь был наследным принцем государства Сяньлэ. Судьба одарила его всем: прекрасным ликом, чистыми помыслами и бесконечной любовью своих подданных. И если уж кому-то и было предначертано стать Божеством, то именно Его Высочеству.", "https://s4-goods.ozstatic.by/2000/97/93/101/101093097_0.jpg", 34.0, "Благословение небожителей. Том 1" },
                    { 3, "Николас Спаркс", 2, "Это – не \"любовный роман\", а роман о любви. О любви обычных мужчины и женщины – таких как мы.\r\n\r\nПочему же книга эта стала абсолютным бестселлером в США? Почему она трогает душу читателей самого разного возраста и интеллектуального уровня? Объяснить это невозможно.\r\n\r\nПрочитайте \"Дневник памяти\" – и поймете сами!", "https://s3-goods.ozstatic.by/2000/94/60/1/1060094_0.jpg", 11.0, "Дневник памяти" },
                    { 4, "Артур Хейли", 6, "Вечеринка \"золотой молодёжи\" закончилась большой бедой...\r\n\r\nТитулованный иностранец случайно совершил преступление – и ищет возможность уйти от ответа...\r\n\r\nДочь миллионера, спасённая из рук насильников, влюбляется в своего спасителя...\r\n\r\nНет, это не детектив. Это – просто повседневная жизнь гигантского, роскошного отеля. Здесь делаются карьеры. Здесь разбиваются сердца. Здесь совершаются сделки и зарабатываются деньги.\r\n\r\nЗдесь просто живут...", "https://s3-goods.ozstatic.by/2000/344/38/1/1038344_0.jpg", 15.0, "Отель" },
                    { 5, "Колин Маккалоу", 2, "Любовный роман, поднятый на уровень настоящей литературы. Трогательная история взаимоотношений влюбленных, завораживающая читателя своей искренностью, чистотой и глубиной...", "https://s1-goods.ozstatic.by/2000/100/141/10/10141100_0.jpg", 14.0, "Поющие в терновнике" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
