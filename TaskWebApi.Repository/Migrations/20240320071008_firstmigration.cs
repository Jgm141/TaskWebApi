using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskWebApi.Repository.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(35)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(35)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(35)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GetDate()"),
                    picture = table.Column<string>(type: "nvarchar(115)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    PhoneNumberType = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelativePersons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    RelativeToId = table.Column<int>(type: "int", nullable: false),
                    RelativePersonType = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativePersons", x => new { x.PersonId, x.RelativeToId });
                    table.ForeignKey(
                        name: "FK_RelativePersons_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_RelativePersons_Persons_RelativeToId",
                        column: x => x.RelativeToId,
                        principalTable: "Persons",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CityId",
                table: "Persons",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_PersonId",
                table: "PhoneNumbers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RelativePersons_RelativeToId",
                table: "RelativePersons",
                column: "RelativeToId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "RelativePersons");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
