using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyAuction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class PaymentHistoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7198), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7273), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7998), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 11, 5, 16, 38, 51, 111, DateTimeKind.Local).AddTicks(8000) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(483), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(520), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(546), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(556), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(558), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(567), new DateTime(2024, 11, 3, 16, 26, 8, 445, DateTimeKind.Local).AddTicks(566) });
        }
    }
}
