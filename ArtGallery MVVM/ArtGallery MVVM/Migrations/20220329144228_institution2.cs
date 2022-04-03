using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtGallery_MVVM.Migrations
{
    public partial class institution2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "painting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sculpture",
                table: "sculpture");

            migrationBuilder.RenameTable(
                name: "sculpture",
                newName: "art");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "art",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InstitutionId",
                table: "art",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technique",
                table: "art",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sculpture_Type",
                table: "art",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_art",
                table: "art",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "instutution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instutution", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_art_InstitutionId",
                table: "art",
                column: "InstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_art_instutution_InstitutionId",
                table: "art",
                column: "InstitutionId",
                principalTable: "instutution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_art_instutution_InstitutionId",
                table: "art");

            migrationBuilder.DropTable(
                name: "instutution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_art",
                table: "art");

            migrationBuilder.DropIndex(
                name: "IX_art_InstitutionId",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "art");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Technique",
                table: "art");

            migrationBuilder.DropColumn(
                name: "Sculpture_Type",
                table: "art");

            migrationBuilder.RenameTable(
                name: "art",
                newName: "sculpture");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sculpture",
                table: "sculpture",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "painting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArtistName = table.Column<string>(type: "text", nullable: true),
                    Technique = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_painting", x => x.Id);
                });
        }
    }
}
