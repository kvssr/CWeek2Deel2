using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Week2Deel1.Migrations
{
    public partial class MySecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Huisen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Huisen",
                table: "Huisen",
                column: "HuisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Huisen",
                table: "Huisen");

            migrationBuilder.RenameTable(
                name: "Huisen",
                newName: "Blogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "HuisId");
        }
    }
}
