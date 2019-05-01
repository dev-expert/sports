using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sports.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TestTypes",
                columns: table => new
                {
                    TestTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypes", x => x.TestTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    AthleteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AthleteName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.AthleteId);
                    table.ForeignKey(
                        name: "FK_Athletes_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestTypeID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_Tests_TestTypes_TestTypeID",
                        column: x => x.TestTypeID,
                        principalTable: "TestTypes",
                        principalColumn: "TestTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSubscriptions",
                columns: table => new
                {
                    TestSubscriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Distance = table.Column<string>(nullable: true),
                    TestID = table.Column<int>(nullable: false),
                    AthleteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSubscriptions", x => x.TestSubscriptionID);
                    table.ForeignKey(
                        name: "FK_TestSubscriptions_Athletes_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "Athletes",
                        principalColumn: "AthleteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSubscriptions_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Role" },
                values: new object[,]
                {
                    { 1, "Athlete" },
                    { 2, "Coach" }
                });

            migrationBuilder.InsertData(
                table: "TestTypes",
                columns: new[] { "TestTypeId", "TestName" },
                values: new object[,]
                {
                    { 1, "Cooper test" },
                    { 2, "sprint test" }
                });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "AthleteName", "Password", "RoleId" },
                values: new object[,]
                {
                    { 2, "Queen Jacobi", "Admin123#", 1 },
                    { 3, "Magen Faye", "Admin123#", 1 },
                    { 4, "Delicia Ledonne", "Admin123#", 1 },
                    { 5, "Camille Grantham", "Admin123#", 1 },
                    { 6, "Marc Voth", "Admin123#", 1 },
                    { 7, "Randy Rondon", "Admin123#", 1 },
                    { 8, "Delora Saville ", "Admin123#", 1 },
                    { 9, "Rosario Reuben", "Admin123#", 1 },
                    { 10, "Lula Uhlman ", "Admin123#", 1 },
                    { 1, "Mitchel Fausto", "Admin123#", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_RoleId",
                table: "Athletes",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestTypeID",
                table: "Tests",
                column: "TestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TestSubscriptions_AthleteId",
                table: "TestSubscriptions",
                column: "AthleteId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSubscriptions_TestID",
                table: "TestSubscriptions",
                column: "TestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestSubscriptions");

            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TestTypes");
        }
    }
}
