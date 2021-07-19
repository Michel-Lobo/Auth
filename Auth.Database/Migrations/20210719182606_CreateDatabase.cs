using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auth.Database.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteddOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "VarChar(100)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteddOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteddOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VarChar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "VarChar(250)", maxLength: 250, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "VarChar(100)", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteddOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Name", "UpdatedOn" },
                values: new object[] { new Guid("aa11d528-2518-4a19-8e39-1108ecaa75be"), new DateTime(2021, 7, 19, 15, 26, 5, 929, DateTimeKind.Local).AddTicks(861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aplicação teste", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Email", "Name", "UpdatedOn" },
                values: new object[] { new Guid("72bb23e0-2870-400b-8fc7-22def251c7e5"), new DateTime(2021, 7, 19, 15, 26, 5, 932, DateTimeKind.Local).AddTicks(1766), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michellobo@gmail.com", "Cliente teste", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("51cb73a1-1708-4c3f-bcf4-b371e1ad964a"), new DateTime(2021, 7, 19, 15, 26, 5, 940, DateTimeKind.Local).AddTicks(3363), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76eb43d8-7365-4fa3-afa9-c97eeedd637a"), new DateTime(2021, 7, 19, 15, 26, 5, 940, DateTimeKind.Local).AddTicks(4018), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_ApplicationId",
                table: "User",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CustomerId",
                table: "User",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
