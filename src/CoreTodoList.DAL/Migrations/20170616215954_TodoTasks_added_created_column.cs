using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTodoList.DAL.Migrations
{
    public partial class TodoTasks_added_created_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TodoTasks",
                nullable: false,
                defaultValue: DateTime.Now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "TodoTasks");
        }
    }
}
