using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomTsvetkova.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    NumberPhone = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStorages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStorages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStorages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStorages_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductStorageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quatity = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ProductStorages_ProductStorageId",
                        column: x => x.ProductStorageId,
                        principalTable: "ProductStorages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { new Guid("0dc8f6f5-6ad7-4e9a-abe8-fa91a816da3d"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("473aa405-5dd8-44cb-9176-23d3790f5f76"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("5684de6b-e6b3-48ad-92fc-cd797fb43a08"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("698857d4-21e3-42f0-a744-a772d415b2e8"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") },
                    { new Guid("8dfd89bb-307f-40b7-80a2-ac38dcb11894"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("b0f01730-f221-410e-a513-5762ee5061c5"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") },
                    { new Guid("d0a312f6-ee5f-456c-8b6a-ebd16fadc167"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12") },
                    { new Guid("dd0eab9e-494f-4fda-8385-ab9adc00e7a0"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11") },
                    { new Guid("e1e10b2a-a35d-4339-bd0d-673336e7a4a1"), new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"), 100, new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductStorageId",
                table: "Orders",
                column: "ProductStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStorages_ProductId",
                table: "ProductStorages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStorages_StorageId",
                table: "ProductStorages",
                column: "StorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ProductStorages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Storages");
        }
    }
}
