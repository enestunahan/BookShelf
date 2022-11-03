using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShelf.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<short>(type: "smallint", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseYear = table.Column<short>(type: "smallint", nullable: false),
                    Pages = table.Column<short>(type: "smallint", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "DateOfDeath", "FirstName", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1c6447ef-86a2-49e2-b092-cd605942e899"), new DateTime(1889, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reşat Nuri", "Güntekin", null },
                    { new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), new DateTime(1907, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1948, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabahattin", "Ali", null },
                    { new Guid("5123cef2-1f48-4a06-9d80-2190835194a3"), new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joanne", "Rowling", null },
                    { new Guid("5c8c320b-f8aa-4fa9-b776-2dda1c7f2fab"), new DateTime(1952, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert Cecil", "Martin", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { (short)1, null, "Roman", null },
                    { (short)2, null, "Edebiyat", null },
                    { (short)3, null, "Fantastik", null },
                    { (short)4, null, "Akademik", null },
                    { (short)5, null, "Yazılım", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), new Guid("5123cef2-1f48-4a06-9d80-2190835194a3"), "Harry Potter Sırlar Odası", null },
                    { new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), "Kuyucaklı Yusuf", null },
                    { new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), "Acımak", null },
                    { new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), new Guid("1c6447ef-86a2-49e2-b092-cd605942e899"), "Çalıkuşu", null },
                    { new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), new Guid("5c8c320b-f8aa-4fa9-b776-2dda1c7f2fab"), "Clean Code", null }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "BookId", "CategoryId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("01fa3733-6bdc-4c48-a282-ce5149a15a95"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), (short)1, null },
                    { new Guid("0dd5dc24-fdd3-40db-a54c-93fae3b6e263"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), (short)4, null },
                    { new Guid("20baeb6b-a8b1-4ae8-81cb-d2c74adc2de5"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), (short)1, null },
                    { new Guid("2b07aec1-1ed5-4352-af88-7aee940ab16d"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), (short)2, null },
                    { new Guid("5fdb7cc9-ecc1-4b95-8a6e-f268915ebe03"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), (short)2, null },
                    { new Guid("8ad54afa-1ab7-4701-b39a-e3d6e8a029fe"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), (short)2, null },
                    { new Guid("d82f02f0-f892-404b-9e26-1a871d180477"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), (short)1, null },
                    { new Guid("e20d4216-fb30-4069-892e-edb2bcf62a4d"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), (short)1, null },
                    { new Guid("eae5138d-8368-42a9-8afe-9ebf67780ee8"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), (short)3, null },
                    { new Guid("eca7b9a6-f11c-4640-bfcd-8cef21a4853a"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), (short)5, null }
                });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "Country", "ISBN", "Pages", "ReleaseYear", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7b80d2e0-245a-49e6-a601-cad3abba5487"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), "Türkiye", "9786051215877", (short)222, (short)1937, null },
                    { new Guid("7d184446-424e-40a6-9413-b53e6fcb0385"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), "Türkiye", "9785486037986", (short)409, (short)1922, null },
                    { new Guid("a412ac71-a741-4ce9-9150-b95bdb12e82b"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), "İngiltere", "9781408855669", (short)314, (short)1998, null },
                    { new Guid("cc5930ad-834d-4863-9cdf-5a4ac602059a"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), "Türkiye", "9789751026569", (short)160, (short)1928, null },
                    { new Guid("dcf930d9-465a-46ad-b068-8a8b22a887c7"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), "Amerika", "978-0132350884", (short)464, (short)2008, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_BookId",
                table: "BookCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
