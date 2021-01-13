using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dinda.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afilhadas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Hobbies = table.Column<string>(nullable: false),
                    DaysAvailable = table.Column<string>(nullable: false),
                    WantToLearn = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afilhadas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Madrinhas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Hobbies = table.Column<string>(nullable: false),
                    DaysAvailable = table.Column<string>(nullable: false),
                    CanTeach = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madrinhas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afilhadas");

            migrationBuilder.DropTable(
                name: "Madrinhas");
        }
    }
}
