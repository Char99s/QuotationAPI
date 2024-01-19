using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuotationAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyOwners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuotationStatus = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotations_PolicyOwners_PolicyOwnerId",
                        column: x => x.PolicyOwnerId,
                        principalTable: "PolicyOwners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfMake = table.Column<int>(type: "int", nullable: false),
                    QuotationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PolicyOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("17a7be3b-77ad-45d8-9e57-efc86d3fdacd"), "Ethan", "Anderson" },
                    { new Guid("22652cf1-83e0-4f60-ae98-f0e108ccc332"), "Olivia", "Garcia" },
                    { new Guid("255ea053-4c40-4dc2-80b0-1871b53385bb"), "Georges", "White" },
                    { new Guid("3935a636-2e24-4c97-974a-885f26e3378b"), "William", "Shakespeare" },
                    { new Guid("6636bf22-5903-4042-9311-c07aba1eafbe"), "Amelia", "Taylor" },
                    { new Guid("6968dcc3-a7ee-4df4-8cbd-b005c3afc7ae"), "Alexander", "Smith" },
                    { new Guid("6b00a876-56ec-47b7-9c4d-cbc491438560"), "Maya", "Miller" },
                    { new Guid("9fa70264-11ef-4bad-8ef5-e134f149a190"), "Eleanor", "Jones" },
                    { new Guid("e836e35b-1497-4354-87e8-975f3d1da676"), "Liam", "Parker" },
                    { new Guid("ef264c54-1310-440a-9f43-ee550d8d3a6d"), "Noah", "Brown" }
                });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "CreationDate", "PolicyOwnerId", "QuotationStatus" },
                values: new object[,]
                {
                    { new Guid("084564b7-f2f5-4b94-8060-10b878c4cadf"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6290), new Guid("6636bf22-5903-4042-9311-c07aba1eafbe"), 0 },
                    { new Guid("1f90fa97-6894-4343-a83a-200682cbcb12"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6264), new Guid("9fa70264-11ef-4bad-8ef5-e134f149a190"), 0 },
                    { new Guid("2f29a06d-1ee9-4f89-98b3-6a5670286855"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6292), new Guid("22652cf1-83e0-4f60-ae98-f0e108ccc332"), 0 },
                    { new Guid("4f2191fb-ac74-48b7-ab36-7b9164f029e5"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6280), new Guid("9fa70264-11ef-4bad-8ef5-e134f149a190"), 0 },
                    { new Guid("503113ca-d149-4a23-87ee-9383f0906a1a"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6276), new Guid("17a7be3b-77ad-45d8-9e57-efc86d3fdacd"), 0 },
                    { new Guid("54a09153-a864-47b6-aad1-1436bd3a82e9"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6278), new Guid("ef264c54-1310-440a-9f43-ee550d8d3a6d"), 1 },
                    { new Guid("54f0c926-0981-4898-8f99-6031670692e4"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6257), new Guid("e836e35b-1497-4354-87e8-975f3d1da676"), 0 },
                    { new Guid("68705687-2332-4b63-a98f-7b36cd538a22"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6192), new Guid("3935a636-2e24-4c97-974a-885f26e3378b"), 1 },
                    { new Guid("76474e11-26b2-4fe4-a945-409fdf8d5569"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6254), new Guid("255ea053-4c40-4dc2-80b0-1871b53385bb"), 0 },
                    { new Guid("771937e2-a726-42e6-b36a-6b82587333a3"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6268), new Guid("6b00a876-56ec-47b7-9c4d-cbc491438560"), 1 },
                    { new Guid("917c3001-5d56-4500-807b-8f80971200e9"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6260), new Guid("6636bf22-5903-4042-9311-c07aba1eafbe"), 0 },
                    { new Guid("a5bfa199-a4f3-4c85-af9c-5a257d8c76fc"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6288), new Guid("22652cf1-83e0-4f60-ae98-f0e108ccc332"), 1 },
                    { new Guid("ac0fd75e-f0ed-4648-afb6-fb696ed4e470"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6286), new Guid("3935a636-2e24-4c97-974a-885f26e3378b"), 1 },
                    { new Guid("b152185e-2758-4869-bf5a-7b8e7c4cebca"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6270), new Guid("9fa70264-11ef-4bad-8ef5-e134f149a190"), 1 },
                    { new Guid("d86cff03-1995-46b2-b343-1c44973938e2"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6282), new Guid("e836e35b-1497-4354-87e8-975f3d1da676"), 1 },
                    { new Guid("dcad5558-5c15-4fa0-b599-9f0f9e132e40"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6284), new Guid("6636bf22-5903-4042-9311-c07aba1eafbe"), 0 },
                    { new Guid("dfb4a00e-0fd6-4887-9d11-4ad63ca02542"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6262), new Guid("6968dcc3-a7ee-4df4-8cbd-b005c3afc7ae"), 1 },
                    { new Guid("eed6f41b-6b49-4f3f-98e6-338c0a5d3e80"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6274), new Guid("6b00a876-56ec-47b7-9c4d-cbc491438560"), 1 },
                    { new Guid("f3cd659f-8fc0-4a2d-ad34-82e5c42ece93"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6272), new Guid("e836e35b-1497-4354-87e8-975f3d1da676"), 0 },
                    { new Guid("ffeba65a-c549-4e9a-ae66-56e336181f66"), new DateTime(2024, 1, 17, 18, 50, 15, 417, DateTimeKind.Local).AddTicks(6266), new Guid("ef264c54-1310-440a-9f43-ee550d8d3a6d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "QuotationId", "YearOfMake" },
                values: new object[,]
                {
                    { new Guid("00d60f20-d994-4551-95c6-eba328cfd548"), "Hyundai", new Guid("4f2191fb-ac74-48b7-ab36-7b9164f029e5"), 2022 },
                    { new Guid("0c012b55-8cbb-4fc1-8261-d652e839e766"), "Honda", new Guid("2f29a06d-1ee9-4f89-98b3-6a5670286855"), 2023 },
                    { new Guid("11fcae53-b1a5-4615-8465-0771ff068ab9"), "BMW", new Guid("54f0c926-0981-4898-8f99-6031670692e4"), 2012 },
                    { new Guid("17f31492-a544-476a-8e94-70a9186bbbe5"), "Hyundai", new Guid("54a09153-a864-47b6-aad1-1436bd3a82e9"), 2018 },
                    { new Guid("20e3b7f4-a797-47b5-912e-a16403833c29"), "Kia", new Guid("eed6f41b-6b49-4f3f-98e6-338c0a5d3e80"), 2013 },
                    { new Guid("276efad2-ce90-4e26-b902-6485707958d9"), "BMW", new Guid("ac0fd75e-f0ed-4648-afb6-fb696ed4e470"), 2010 },
                    { new Guid("2ce1d87b-3db1-487a-8fe8-77cc1269bdcb"), "Mercedes", new Guid("76474e11-26b2-4fe4-a945-409fdf8d5569"), 2016 },
                    { new Guid("41cf071b-3588-4a85-9eb5-f3cfc5e42a1e"), "Kia", new Guid("dcad5558-5c15-4fa0-b599-9f0f9e132e40"), 2023 },
                    { new Guid("4219ed35-e311-41e6-bfe6-1097de9252fe"), "BMW", new Guid("ffeba65a-c549-4e9a-ae66-56e336181f66"), 2016 },
                    { new Guid("47566373-6e02-412c-814e-97e356d3c7c4"), "Mercedes", new Guid("771937e2-a726-42e6-b36a-6b82587333a3"), 2008 },
                    { new Guid("58e2bab6-a2b2-4e59-835d-6685e7db659a"), "Ford", new Guid("68705687-2332-4b63-a98f-7b36cd538a22"), 2020 },
                    { new Guid("65ae53c6-59db-47a8-a5d8-89968b479a5b"), "Dodge", new Guid("dfb4a00e-0fd6-4887-9d11-4ad63ca02542"), 2020 },
                    { new Guid("7c96acba-6221-4dcb-a9d2-523938e30f00"), "Porsche", new Guid("084564b7-f2f5-4b94-8060-10b878c4cadf"), 2024 },
                    { new Guid("821a68df-338d-4831-9ae8-a4b141d684c7"), "Audi", new Guid("917c3001-5d56-4500-807b-8f80971200e9"), 2013 },
                    { new Guid("a67468cb-b782-4278-851c-89226973025a"), "Dodge", new Guid("503113ca-d149-4a23-87ee-9383f0906a1a"), 2019 },
                    { new Guid("d05e22dd-67e0-49e0-ad87-a1878554a1a0"), "Ford", new Guid("d86cff03-1995-46b2-b343-1c44973938e2"), 2023 },
                    { new Guid("d6e11d03-56e0-441e-8464-9de1b6aa14f1"), "Chevrolet", new Guid("a5bfa199-a4f3-4c85-af9c-5a257d8c76fc"), 2022 },
                    { new Guid("edd60d96-0705-4236-a530-f55e4257f24e"), "Audi", new Guid("b152185e-2758-4869-bf5a-7b8e7c4cebca"), 2009 },
                    { new Guid("f4435f6d-4d8b-4b15-9180-18161da22fcf"), "Porsche", new Guid("1f90fa97-6894-4343-a83a-200682cbcb12"), 2013 },
                    { new Guid("f79415ff-bc8a-4918-903d-8dfcb725258e"), "Kia", new Guid("f3cd659f-8fc0-4a2d-ad34-82e5c42ece93"), 2011 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_QuotationId",
                table: "Cars",
                column: "QuotationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_PolicyOwnerId",
                table: "Quotations",
                column: "PolicyOwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "PolicyOwners");
        }
    }
}
