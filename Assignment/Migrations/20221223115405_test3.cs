using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "35f83089-16f1-4fc5-935f-23df6216bdcf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "52463584-ab8f-46e0-be47-cba6eb2453b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "10ca77e8-7b33-4176-99bc-4dfb5c369c57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fa08866-4420-4afb-931c-be91bd501044", "AQAAAAEAACcQAAAAEEuJHk4CI1ou2C5P5CUOVcFNvAWJsqdUXdJLfbpyiFHMRx5rL1Fod26nnET/9p7b5A==", "2cb1cdc5-da32-4972-8a57-5a74d6d58972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bcc396f-af13-4de9-97e0-9957c1e8c2bf", "AQAAAAEAACcQAAAAEGfgHtl2Q1vbMDFT0dGnbFLTBZfa8zYm/jYyP0QV0NIZ6YhnIq91VX0045RQA6aVSQ==", "2bab6d2e-f407-4bb6-9d16-226d3144bfe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f77d8fa-1f8c-41d8-a061-3eeddaa56718", "AQAAAAEAACcQAAAAEB4vLOZSgqrH7R3x09HnbEBDlP7GV/WouPSdfa0LrjlBj5+hIzUMUlel/ushW3XcOA==", "8de5ecf5-b454-4e72-ab83-b07b3637c636" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5853b943-3a80-49f9-bbbe-477de984c30c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a8cd641-6497-477b-b2e1-7a9e723e63b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "857f5d79-1f12-482c-8dae-49eed4800967");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ae4fd2-bb0b-4f5e-a8ce-7860f2136126", "AQAAAAEAACcQAAAAEB3ZncNYP5L+ZLRSUgEMyWtoKOuzsi/ZMvC/u1caYRh/ZWee9v7s002MUMfpkkR7/A==", "9a66dd34-3ac6-4fcb-bb64-23a4a2880477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d348b5-aacb-4455-9046-5479d984f957", "AQAAAAEAACcQAAAAEEWG7ltEzA92bcUWGDHHM5vNq1dY5yMSEzjrSkqKH2JSY1+gUqaCC+jX4OnO9Prr+w==", "5efa5ebf-39b9-4fe2-a0b6-f3f6a482b008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f882f3-d1ff-43a3-90e7-371f37992afd", "AQAAAAEAACcQAAAAEOtsNoSRuGiS0sRRGMa16sJaeTLcPO0SwVC0hYrgnIGBGZjMEcSaBLn/CWBxbgQkbQ==", "3036f144-b69a-47e7-bb5c-ca599e7ef6cd" });
        }
    }
}
