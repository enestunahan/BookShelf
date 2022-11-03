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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DateOfDeath", "FirstName", "IsDeleted", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1c6447ef-86a2-49e2-b092-cd605942e899"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1889, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reşat Nuri", false, "Güntekin", null },
                    { new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1907, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1948, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabahattin", false, "Ali", null },
                    { new Guid("5123cef2-1f48-4a06-9d80-2190835194a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joanne", false, "Rowling", null },
                    { new Guid("5c8c320b-f8aa-4fa9-b776-2dda1c7f2fab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert Cecil", false, "Martin", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Roman", null },
                    { (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Edebiyat", null },
                    { (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fantastik", null },
                    { (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Akademik", null },
                    { (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Yazılım", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), new Guid("5123cef2-1f48-4a06-9d80-2190835194a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Harry Potter Sırlar Odası", null },
                    { new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kuyucaklı Yusuf", null },
                    { new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), new Guid("406578b9-d472-40a3-893f-3cf067a8d576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Acımak", null },
                    { new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), new Guid("1c6447ef-86a2-49e2-b092-cd605942e899"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Çalıkuşu", null },
                    { new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), new Guid("5c8c320b-f8aa-4fa9-b776-2dda1c7f2fab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Clean Code", null }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "BookId", "CategoryId", "CreatedDate", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0804be5c-55ba-47a3-a114-859cb9839006"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("4a417840-eea5-489e-9b23-ee8a89377a83"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("647caf0e-0b5f-42a5-ae41-11f6c47ad5d2"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("7138ddf9-50b5-4b58-87e7-2a91e39c3b84"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("740e9092-8bee-4f65-82bc-72134ebc0aa0"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("91ed6e02-013c-46fe-b683-1338f2eb2b39"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("957c82e5-51e6-413d-8e41-150fe97839d2"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("a83907ab-5deb-4bab-8a37-a90c43b1ff53"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("bba9cce3-412a-4e51-ae65-1190955e9470"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { new Guid("cea1cc07-3059-4d1e-a1c3-cf6233d45dc2"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null }
                });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "Country", "CreatedDate", "ISBN", "IsDeleted", "Pages", "ReleaseYear", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("14a41b6b-1087-4ede-88e0-5cfabafb27bd"), new Guid("7740c465-3549-40e8-8a34-1ede6b02bfff"), "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789751026569", false, (short)160, (short)1928, null },
                    { new Guid("20012823-a83c-4836-96d3-5cd5b36100e3"), new Guid("2f01b12b-e101-4bef-ac48-6477cd922512"), "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786051215877", false, (short)222, (short)1937, null },
                    { new Guid("3dead5ee-44d5-4a08-82a2-8685942fc193"), new Guid("ef074b57-3699-47d6-a22c-7c6e7725a2b3"), "Amerika", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-0132350884", false, (short)464, (short)2008, null },
                    { new Guid("8f2fca36-4141-413b-aeee-a568446d671f"), new Guid("8f5ff94d-95e5-403b-87a1-772d4f92d389"), "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9785486037986", false, (short)409, (short)1922, null },
                    { new Guid("bff5e8e6-3fa2-4ca6-91d1-f201f7ea3186"), new Guid("160fbeaf-7685-41be-b0ad-151cbd357909"), "İngiltere", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9781408855669", false, (short)314, (short)1998, null }
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
