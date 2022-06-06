using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomTsvetkova.Migrations
{
    public partial class Number666 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "ProductId", "Quantity", "StorageId" },
                values: new object[,]
                {
                    { new Guid("0cd515d3-a863-40d0-97dc-50fe419d6384"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") },
                    { new Guid("256b0c54-73aa-4c8d-80af-6ec378e66bf9"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("269dd2ac-fdb6-4482-8231-73b01c219b1c"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("2e174abb-b309-48c7-9164-0887fdc21ee3"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("a87ee831-7d8b-476f-b1e8-2da57ff05fba"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("ab9031f3-8a4d-45c5-ad94-313e21b8606b"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("bc35d3c5-42b3-498e-83a5-79c900e575c7"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("c5745ae3-58fd-4aeb-813c-3883a740b6d0"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("f03243da-5609-4beb-98aa-730c1d4f66e4"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("0cd515d3-a863-40d0-97dc-50fe419d6384"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("256b0c54-73aa-4c8d-80af-6ec378e66bf9"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("269dd2ac-fdb6-4482-8231-73b01c219b1c"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("2e174abb-b309-48c7-9164-0887fdc21ee3"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("a87ee831-7d8b-476f-b1e8-2da57ff05fba"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("ab9031f3-8a4d-45c5-ad94-313e21b8606b"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("bc35d3c5-42b3-498e-83a5-79c900e575c7"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("c5745ae3-58fd-4aeb-813c-3883a740b6d0"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("f03243da-5609-4beb-98aa-730c1d4f66e4"));

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
    }
}
