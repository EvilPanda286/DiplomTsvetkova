using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomTsvetkova.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Storages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Storages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Clients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Clients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), "1.jpg", "BANAN1", 1m },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), "1.jpg", "BANAN2", 12m },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"), "1.jpg", "BANAN3", 123m },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"), "1.jpg", "BANAN4", 1234m },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), "1.jpg", "BANAN5", 12345m }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11"), "Ново-Московская ул., 2/8, Смоленск, Смоленская обл., 214000", 54.795332076323433, 32.055647589620733, "BANANOSKLAD1" },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12"), "ул. 25 Сентября, 35А, Смоленск, Смоленская обл., 214031", 54.770775521219925, 32.079753946338514, "BANANOSKLAD2" },
                    { new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13"), "ул. Нормандии-Неман, 35, Смоленск, Смоленская обл., 214025", 54.780128699072407, 32.016695035303151, "BANANOSKLAD3" }
                });

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "ProductId", "Quantity", "StorageId" },
                values: new object[,]
                {
                    { new Guid("0548faf4-13e7-4c12-b8d2-a777f9bc2b49"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("17f6f2aa-7280-440a-a3b3-141890e369b9"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("2c0bc8fd-46f7-4270-b739-9d55cb97d331"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") },
                    { new Guid("4a54338e-b135-44a7-bf20-d5207c62fd8f"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("5ef82f0d-97c9-4c40-aee1-eb619f062278"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("6d9522e6-c2a0-45b5-906a-f72a55259c0f"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("b2c5f900-4908-4274-97dd-6be57465be6e"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") },
                    { new Guid("d18d7dd9-8552-429c-ae51-b3ee5b17c697"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("f9db223f-8ad3-4e1b-bbaa-fcf199aadb25"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("0548faf4-13e7-4c12-b8d2-a777f9bc2b49"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("17f6f2aa-7280-440a-a3b3-141890e369b9"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("2c0bc8fd-46f7-4270-b739-9d55cb97d331"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("4a54338e-b135-44a7-bf20-d5207c62fd8f"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("5ef82f0d-97c9-4c40-aee1-eb619f062278"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("6d9522e6-c2a0-45b5-906a-f72a55259c0f"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("b2c5f900-4908-4274-97dd-6be57465be6e"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("d18d7dd9-8552-429c-ae51-b3ee5b17c697"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("f9db223f-8ad3-4e1b-bbaa-fcf199aadb25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13"));

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Clients");
        }
    }
}
