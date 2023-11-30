﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoomCategoryId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "roomCategories",
                columns: table => new
                {
                    RoomCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomCategories", x => x.RoomCategoryId);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2024, 9, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2024, 8, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2024, 3, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2024, 7, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2024, 3, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2024, 5, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 48, 17, 171, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("2e5948bb-07bb-44f8-9732-132bbaabc3ad"),
                column: "RoomCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("39561959-db4b-4894-a5dc-497713074cb0"),
                column: "RoomCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("89c0c8f1-5911-41ec-9f43-e66388409d86"),
                column: "RoomCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("d37304a2-1117-447f-aaf1-b9386f97505c"),
                column: "RoomCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("e7515010-b1da-4ede-94a4-0724baff54d8"),
                column: "RoomCategoryId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_roomCategories_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId",
                principalTable: "roomCategories",
                principalColumn: "RoomCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_roomCategories_RoomCategoryId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "roomCategories");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomCategoryId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomCategoryId",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2024, 9, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2024, 8, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2024, 3, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2024, 7, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2024, 3, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2024, 5, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2023, 11, 30, 15, 40, 48, 886, DateTimeKind.Local).AddTicks(8056));
        }
    }
}
