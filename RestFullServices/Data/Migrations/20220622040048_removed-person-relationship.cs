using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class removedpersonrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PersonTypes_PersonTypeId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonTypeId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonTypeId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonTypeId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonTypes_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId",
                principalTable: "PersonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
