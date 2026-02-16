using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day08.Migrations
{
    /// <inheritdoc />
    public partial class addAllItialTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "SalesOffices",
                columns: table => new
                {
                    OfficeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MangerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOffices", x => x.OfficeNumber);
                    table.ForeignKey(
                        name: "FK_SalesOffices_Employees_MangerId",
                        column: x => x.MangerId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_SalesOffices_SalesOfficeId",
                        column: x => x.SalesOfficeId,
                        principalTable: "SalesOffices",
                        principalColumn: "OfficeNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeName", "SalesOfficeId" },
                values: new object[,]
                {
                    { 1, "Emp1", null },
                    { 2, "Emp2", null },
                    { 3, "Emp3", null }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "OwnerName" },
                values: new object[,]
                {
                    { 1, "owner1" },
                    { 2, "owner2" }
                });

            migrationBuilder.InsertData(
                table: "SalesOffices",
                columns: new[] { "OfficeNumber", "Location", "MangerId" },
                values: new object[,]
                {
                    { 1, "loc1", 1 },
                    { 2, "loc2", 2 },
                    { 3, "loc3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "City", "SalesOfficeId", "State", "ZipCode" },
                values: new object[] { 1, "add1", "city1", 1, "stat1", "zib1" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesOfficeId",
                table: "Employees",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_SalesOfficeId",
                table: "Properties",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffices_MangerId",
                table: "SalesOffices",
                column: "MangerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SalesOffices_SalesOfficeId",
                table: "Employees",
                column: "SalesOfficeId",
                principalTable: "SalesOffices",
                principalColumn: "OfficeNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SalesOffices_SalesOfficeId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "SalesOffices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
