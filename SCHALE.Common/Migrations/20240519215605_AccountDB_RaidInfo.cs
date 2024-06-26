﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCHALE.Common.Migrations
{
    /// <inheritdoc />
    public partial class AccountDB_RaidInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaidSeasonId",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "RaidInfo",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaidInfo",
                table: "Accounts");

            migrationBuilder.AddColumn<long>(
                name: "RaidSeasonId",
                table: "Accounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
