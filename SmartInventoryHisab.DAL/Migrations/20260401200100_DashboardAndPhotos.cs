using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartInventoryHisab.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DashboardAndPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CurrentStock", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 26, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6139), 6, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 1", 80.4536491867405m },
                    { 2, new DateTime(2026, 1, 10, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6158), 25, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 2", 372.20418236321m },
                    { 3, new DateTime(2025, 12, 21, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6164), 25, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 3", 138.660698946873m },
                    { 4, new DateTime(2025, 6, 14, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6168), 1, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 4", 268.725549913349m },
                    { 5, new DateTime(2025, 7, 8, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6172), 4, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 5", 86.0965401195439m },
                    { 6, new DateTime(2026, 2, 2, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6177), 35, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 6", 32.0735690193593m },
                    { 7, new DateTime(2026, 3, 23, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6220), 9, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 7", 268.206857022926m },
                    { 8, new DateTime(2025, 9, 7, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6224), 0, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 8", 420.532575990321m },
                    { 9, new DateTime(2026, 3, 31, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6227), 7, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 9", 202.286845851823m },
                    { 10, new DateTime(2026, 1, 9, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6234), 5, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 10", 323.228192186555m },
                    { 11, new DateTime(2026, 3, 14, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6237), 7, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 11", 334.072953697328m },
                    { 12, new DateTime(2025, 7, 14, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6241), 21, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 12", 35.3973440385411m },
                    { 13, new DateTime(2025, 12, 30, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6244), 18, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 13", 16.6268874828829m },
                    { 14, new DateTime(2026, 3, 9, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6247), 23, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 14", 45.4714708102268m },
                    { 15, new DateTime(2026, 3, 8, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6250), 24, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 15", 266.748119488707m },
                    { 16, new DateTime(2025, 8, 31, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6254), 3, "High quality electronics product for daily use.", "/images/products/placeholder.png", "Electronics Item 16", 11.5370042536114m },
                    { 17, new DateTime(2025, 11, 13, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6257), 23, "High quality stationery product for daily use.", "/images/products/placeholder.png", "Stationery Item 17", 474.485383343178m },
                    { 18, new DateTime(2025, 10, 9, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6261), 7, "High quality electronics product for daily use.", "/images/products/placeholder.png", "Electronics Item 18", 196.383614636205m },
                    { 19, new DateTime(2025, 5, 15, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6265), 14, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 19", 210.349496305152m },
                    { 20, new DateTime(2025, 4, 22, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6269), 44, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 20", 19.7060832240181m },
                    { 21, new DateTime(2025, 10, 23, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6272), 5, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 21", 91.1814030544746m },
                    { 22, new DateTime(2026, 1, 15, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6277), 6, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 22", 84.274555348919m },
                    { 23, new DateTime(2025, 7, 11, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6280), 38, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 23", 503.510795986983m },
                    { 24, new DateTime(2025, 9, 1, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6283), 49, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 24", 286.030006714179m },
                    { 25, new DateTime(2026, 1, 25, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6286), 1, "High quality furniture product for daily use.", "/images/products/placeholder.png", "Furniture Item 25", 474.531421179199m },
                    { 26, new DateTime(2025, 10, 30, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6290), 29, "High quality electronics product for daily use.", "/images/products/placeholder.png", "Electronics Item 26", 118.061852216749m },
                    { 27, new DateTime(2025, 12, 23, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6293), 5, "High quality stationery product for daily use.", "/images/products/placeholder.png", "Stationery Item 27", 70.6966738406088m },
                    { 28, new DateTime(2026, 3, 7, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6296), 0, "High quality kitchen product for daily use.", "/images/products/placeholder.png", "Kitchen Item 28", 422.91395989848m },
                    { 29, new DateTime(2025, 5, 24, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6300), 46, "High quality stationery product for daily use.", "/images/products/placeholder.png", "Stationery Item 29", 129.036826826184m },
                    { 30, new DateTime(2026, 1, 24, 20, 0, 59, 478, DateTimeKind.Utc).AddTicks(6303), 31, "High quality appliance product for daily use.", "/images/products/placeholder.png", "Appliance Item 30", 327.237977086212m }
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
