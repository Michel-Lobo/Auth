using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auth.Database.Migrations
{
    public partial class AlterColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Application",
                keyColumn: "Id",
                keyValue: new Guid("aa11d528-2518-4a19-8e39-1108ecaa75be"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("72bb23e0-2870-400b-8fc7-22def251c7e5"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("51cb73a1-1708-4c3f-bcf4-b371e1ad964a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("76eb43d8-7365-4fa3-afa9-c97eeedd637a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Role",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Customer",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Application",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Application",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Name", "UpdatedOn" },
                values: new object[] { new Guid("c0abe2fa-20e4-4f47-94dc-ea44ada5f67a"), new DateTime(2021, 7, 19, 15, 42, 5, 741, DateTimeKind.Local).AddTicks(8789), null, "Aplicação teste", null });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Email", "Name", "UpdatedOn" },
                values: new object[] { new Guid("6fc36b08-9173-4e40-8687-326d6cb9f647"), new DateTime(2021, 7, 19, 15, 42, 5, 744, DateTimeKind.Local).AddTicks(9397), null, "michellobo@gmail.com", "Cliente teste", null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedOn", "DeleteddOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("75e26236-3a19-42d2-9fde-6dae684aacf6"), new DateTime(2021, 7, 19, 15, 42, 5, 753, DateTimeKind.Local).AddTicks(6896), null, "ADMIN", null },
                    { new Guid("cfe68fdb-e769-444c-987c-85546efeaa31"), new DateTime(2021, 7, 19, 15, 42, 5, 753, DateTimeKind.Local).AddTicks(7652), null, "USER", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Application",
                keyColumn: "Id",
                keyValue: new Guid("c0abe2fa-20e4-4f47-94dc-ea44ada5f67a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6fc36b08-9173-4e40-8687-326d6cb9f647"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("75e26236-3a19-42d2-9fde-6dae684aacf6"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cfe68fdb-e769-444c-987c-85546efeaa31"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Application",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteddOn",
                table: "Application",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}
