﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalaxyAuction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "AdditionalInformation", "AuctionPrice", "BrandAndModel", "Color", "EndTime", "EngineCapacity", "Image", "IsActive", "ManufacturingYear", "Millage", "PlateNumber", "Price", "SellerId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Excellent condition, single owner", 200.0, "Toyota Camry", "Silver", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1743), 2.5m, "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg", true, 2020, 15000, "34AA21", 25000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1730) },
                    { 2, "Good condition, one previous owner", 200.0, "Honda Civic", "Blue", new DateTime(2024, 11, 27, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1752), 1.8m, "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg", false, 2019, 20000, "34AA21", 18000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1751) },
                    { 3, "Low mileage, well-maintained", 200.0, "Ford F-150", "Red", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1755), 5.0m, "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg", true, 2018, 25000, "34AA21", 28000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1754) },
                    { 4, "Great condition, low mileage", 200.0, "Nissan Altima", "Black", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1757), 2.5m, "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg", true, 2017, 30000, "34AA21", 16000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1757) },
                    { 5, "Well-maintained, single owner", 200.0, "Chevrolet Malibu", "Silver", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1760), 2.4m, "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg", true, 2017, 28000, "34AA21", 15500.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1759) },
                    { 6, "Like new, low mileage", 200.0, "Ferrari 488 GTB", "Red", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1763), 3.9m, "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg", true, 2022, 1000, "34AA21", 300000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1763) },
                    { 7, "Excellent condition, one owner", 0.0, "Lamborghini Huracan", "Yellow", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1765), 5.2m, "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg", true, 2021, 2000, "34AA21", 280000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1765) },
                    { 8, "Low mileage, well-maintained", 0.0, "Porsche 911", "White", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1768), 3.0m, "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900", true, 2020, 5000, "34AA21", 180000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1767) },
                    { 9, "Excellent condition, low mileage", 0.0, "Aston Martin DB11", "Black", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1770), 5.2m, "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg", true, 2019, 6000, "34AA21", 250000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1770) },
                    { 10, "Like new, low mileage", 0.0, "McLaren 720S", "Orange", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1772), 4.0m, "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg", true, 2021, 4000, "34AA21", 280000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1772) },
                    { 11, "Rare, collector's item", 0.0, "Bugatti Chiron", "Blue", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1775), 8.0m, "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg", true, 2018, 3000, "34AA21", 350000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1774) },
                    { 12, "High-performance masterpiece", 0.0, "Koenigsegg Jesko", "Silver", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1777), 5.0m, "https://wallpapercave.com/wp/wp5031567.jpg", true, 2022, 1500, "34AA21", 400000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1777) },
                    { 13, "Hybrid supercar, low mileage", 0.0, "Ferrari SF90 Stradale", "Red", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1780), 4.0m, "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg", true, 2021, 2000, "34AA21", 275000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1779) },
                    { 14, "Exotic masterpiece, low mileage", 0.0, "Pagani Huayra", "Green", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1782), 6.0m, "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg", true, 2020, 2500, "34AA21", 320000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1782) },
                    { 15, "Luxury sports coupe", 0.0, "Lexus LC 500", "Black", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1784), 5.0m, "https://wallpapercave.com/wp/wp6603188.jpg", true, 2019, 5000, "34AA21", 60000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1784) },
                    { 16, "High-performance electric car", 0.0, "Tesla Model S", "Blue", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1789), 0.0m, "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg", true, 2022, 1500, "34AA21", 90000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1789) },
                    { 17, "Luxury sports car, low mileage", 0.0, "Audi R8", "Silver", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1791), 5.2m, "https://wallpapercave.com/wp/wp8343229.jpg", true, 2021, 3000, "34AA21", 120000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1791) },
                    { 18, "High-performance luxury car", 0.0, "Mercedes-AMG GT", "Black", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1795), 4.0m, "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg", true, 2020, 4000, "34AA21", 110000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1794) },
                    { 19, "High-performance Japanese sports car", 0.0, "Nissan GT-R", "Blue", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1797), 3.8m, "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg", true, 2021, 2500, "34AA21", 95000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1797) },
                    { 20, "High-performance American muscle car", 0.0, "Ford Mustang Shelby GT500", "Red", new DateTime(2025, 1, 14, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1800), 5.2m, "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg", true, 2022, 1500, "34AA21", 75000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1799) },
                    { 21, "Sports car with exceptional handling", 0.0, "Porsche Cayman GT4", "Yellow", new DateTime(2024, 12, 21, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1802), 4.0m, "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg", true, 2021, 3500, "34AA21", 95000.00m, "89e6aebe-97d5-4c9d-bd55-9f7c77ed86dc", new DateTime(2024, 11, 3, 16, 13, 57, 733, DateTimeKind.Local).AddTicks(1802) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21);
        }
    }
}
