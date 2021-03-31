using Microsoft.EntityFrameworkCore.Migrations;

namespace GrumpyClay.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Original", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cartoon", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Video Game", null });

            migrationBuilder.InsertData(
                table: "Sculptures",
                columns: new[] { "SculptureId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsSculptureOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, 1, "https://i.etsystatic.com/27116147/r/il/27a5b5/2928270607/il_794xN.2928270607_5jlb.jpg", "https://i.etsystatic.com/27116147/r/il/27a5b5/2928270607/il_794xN.2928270607_5jlb.jpg", true, true, "Made from high quality resin and hand painted.", "Tentacle Holding a Rose", 30.00m, "Original tentacle holding a rose" });

            migrationBuilder.InsertData(
                table: "Sculptures",
                columns: new[] { "SculptureId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsSculptureOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, "https://i.etsystatic.com/27116147/r/il/08bb82/2864918839/il_794xN.2864918839_dxl2.jpg", "https://i.etsystatic.com/27116147/r/il/08bb82/2864918839/il_794xN.2864918839_dxl2.jpg", true, false, "Apple inspired by Snow White and the Seven Dwarves. Don’t eat it! ;)", "Poison Apple", 15.00m, "Apple inspired by Snow White and the Seven Dwarves" });

            migrationBuilder.InsertData(
                table: "Sculptures",
                columns: new[] { "SculptureId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsSculptureOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 3, "https://i.etsystatic.com/27116147/r/il/39622e/2872265535/il_794xN.2872265535_r2ij.jpg", "https://i.etsystatic.com/27116147/r/il/39622e/2872265535/il_794xN.2872265535_r2ij.jpg", true, false, "I created the sculpture by shaping clay, then I copied the clay sculpture into plastic. Next, I hand painted the plastic copy and added a protective coating to keep it looking nice. This sculpture was built to last!", "Handmade Sackboy", 65.00m, "Sackboy from Little Big Planet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sculptures",
                keyColumn: "SculptureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sculptures",
                keyColumn: "SculptureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sculptures",
                keyColumn: "SculptureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
